using System;
using System.Threading;

namespace JJH_Tetris
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "JJH Tetris";
            var game = new TetrisGame();
            game.Run();
        }
    }

    internal sealed class TetrisGame
    {
        private const int BoardWidth = 10;
        private const int BoardHeight = 20;
        private const int CellRenderWidth = 2;

        private static readonly ConsoleColor[] PieceColors =
        {
            ConsoleColor.Black,
            ConsoleColor.Cyan,
            ConsoleColor.Blue,
            ConsoleColor.DarkYellow,
            ConsoleColor.Magenta,
            ConsoleColor.Green,
            ConsoleColor.Red,
            ConsoleColor.Yellow
        };

        private readonly int[,] board = new int[BoardHeight, BoardWidth];
        private readonly Tetromino[] tetrominoes = TetrominoFactory.BuildPieces();
        private readonly Random random = new Random();

        private Tetromino currentPiece;
        private Tetromino nextPiece;
        private int currentRow;
        private int currentCol;
        private int currentRotation;
        private bool isGameOver;
        private int score;
        private int clearedLines;
        private TimeSpan dropInterval = TimeSpan.FromMilliseconds(600);
        private DateTime nextFall;

        public void Run()
        {
            Console.Clear();
            Console.CursorVisible = false;
            nextPiece = GetRandomTetromino();
            SpawnPiece();
            ResetFallTimer();

            while (!isGameOver)
            {
                HandleInput();
                if (DateTime.UtcNow >= nextFall)
                {
                    StepDown();
                    ResetFallTimer();
                }

                DrawFrame();
                Thread.Sleep(16);
            }

            DrawFrame();
            Console.SetCursorPosition(0, BoardHeight + 10);
            Console.ResetColor();
            Console.WriteLine("Game over! Final score: {0}", score);
            Console.WriteLine("Press Enter to exit...");
            Console.CursorVisible = true;
            Console.ReadLine();
        }

        private void HandleInput()
        {
            while (!isGameOver && Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        TryMove(0, -1);
                        break;
                    case ConsoleKey.RightArrow:
                        TryMove(0, 1);
                        break;
                    case ConsoleKey.DownArrow:
                        score += 1;
                        StepDown();
                        ResetFallTimer();
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.X:
                        Rotate(1);
                        break;
                    case ConsoleKey.Z:
                        Rotate(-1);
                        break;
                    case ConsoleKey.Spacebar:
                        HardDrop();
                        break;
                    case ConsoleKey.Escape:
                        isGameOver = true;
                        break;
                }
            }
        }

        private void HardDrop()
        {
            if (isGameOver)
            {
                return;
            }

            while (TryMove(1, 0))
            {
                score += 2;
            }

            StepDown();
            ResetFallTimer();
        }

        private void StepDown()
        {
            if (isGameOver)
            {
                return;
            }

            if (TryMove(1, 0))
            {
                return;
            }

            LockPiece();
            var cleared = ClearLines();
            if (cleared > 0)
            {
                ApplyScore(cleared);
                UpdateSpeed();
            }

            SpawnPiece();
        }

        private void ResetFallTimer()
        {
            nextFall = DateTime.UtcNow + dropInterval;
        }

        private void ApplyScore(int cleared)
        {
            int reward;
            switch (cleared)
            {
                case 1:
                    reward = 100;
                    break;
                case 2:
                    reward = 300;
                    break;
                case 3:
                    reward = 500;
                    break;
                case 4:
                    reward = 800;
                    break;
                default:
                    reward = 0;
                    break;
            }

            score += reward;
            clearedLines += cleared;
        }

        private void UpdateSpeed()
        {
            var level = CurrentLevel - 1;
            var interval = 600 - (level * 40);
            if (interval < 120)
            {
                interval = 120;
            }

            dropInterval = TimeSpan.FromMilliseconds(interval);
        }

        private int CurrentLevel => (clearedLines / 10) + 1;

        private bool TryMove(int rowOffset, int colOffset)
        {
            var targetRow = currentRow + rowOffset;
            var targetCol = currentCol + colOffset;

            if (!IsValidPosition(targetRow, targetCol, currentRotation))
            {
                return false;
            }

            currentRow = targetRow;
            currentCol = targetCol;
            return true;
        }

        private void Rotate(int direction)
        {
            if (currentPiece == null)
            {
                return;
            }

            int desiredRotation;
            if (direction > 0)
            {
                desiredRotation = (currentRotation + 1) % 4;
            }
            else
            {
                desiredRotation = (currentRotation + 3) % 4;
            }

            int[] kicks = { 0, -1, 1, -2, 2 };
            foreach (var offset in kicks)
            {
                if (IsValidPosition(currentRow, currentCol + offset, desiredRotation))
                {
                    currentCol += offset;
                    currentRotation = desiredRotation;
                    return;
                }
            }
        }

        private bool IsValidPosition(int targetRow, int targetCol, int rotationIndex)
        {
            if (currentPiece == null)
            {
                return false;
            }

            var shape = currentPiece.Rotations[rotationIndex];
            var rows = shape.GetLength(0);
            var cols = shape.GetLength(1);

            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < cols; c++)
                {
                    if (!shape[r, c])
                    {
                        continue;
                    }

                    var boardRow = targetRow + r;
                    var boardCol = targetCol + c;

                    if (boardCol < 0 || boardCol >= BoardWidth)
                    {
                        return false;
                    }

                    if (boardRow >= BoardHeight)
                    {
                        return false;
                    }

                    if (boardRow >= 0 && board[boardRow, boardCol] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void LockPiece()
        {
            if (currentPiece == null)
            {
                return;
            }

            var shape = currentPiece.Rotations[currentRotation];
            var rows = shape.GetLength(0);
            var cols = shape.GetLength(1);

            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < cols; c++)
                {
                    if (!shape[r, c])
                    {
                        continue;
                    }

                    var boardRow = currentRow + r;
                    var boardCol = currentCol + c;
                    if (boardRow < 0)
                    {
                        continue;
                    }

                    if (boardRow >= 0 && boardRow < BoardHeight && boardCol >= 0 && boardCol < BoardWidth)
                    {
                        board[boardRow, boardCol] = currentPiece.Id;
                    }
                }
            }
        }

        private int ClearLines()
        {
            var cleared = 0;
            for (var row = BoardHeight - 1; row >= 0; row--)
            {
                var full = true;
                for (var col = 0; col < BoardWidth; col++)
                {
                    if (board[row, col] == 0)
                    {
                        full = false;
                        break;
                    }
                }

                if (!full)
                {
                    continue;
                }

                cleared++;
                RemoveRow(row);
                row++;
            }

            return cleared;
        }

        private void RemoveRow(int row)
        {
            for (var r = row; r > 0; r--)
            {
                for (var c = 0; c < BoardWidth; c++)
                {
                    board[r, c] = board[r - 1, c];
                }
            }

            for (var c = 0; c < BoardWidth; c++)
            {
                board[0, c] = 0;
            }
        }

        private void SpawnPiece()
        {
            currentPiece = nextPiece ?? GetRandomTetromino();
            nextPiece = GetRandomTetromino();
            currentRotation = 0;
            currentRow = -2;
            var shape = currentPiece.Rotations[currentRotation];
            var pieceWidth = shape.GetLength(1);
            currentCol = (BoardWidth - pieceWidth) / 2;

            if (!IsValidPosition(currentRow, currentCol, currentRotation))
            {
                isGameOver = true;
            }
        }

        private Tetromino GetRandomTetromino()
        {
            var index = random.Next(tetrominoes.Length);
            return tetrominoes[index];
        }

        private void DrawFrame()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Gray;
            DrawHorizontalBorder();

            for (var row = 0; row < BoardHeight; row++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write('|');
                for (var col = 0; col < BoardWidth; col++)
                {
                    var id = board[row, col];
                    if (IsFallingCell(row, col, out var fallingId))
                    {
                        id = fallingId;
                    }

                    if (id > 0)
                    {
                        var color = PieceColors[id];
                        Console.ForegroundColor = color;
                        Console.Write("[]");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" .");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine('|');
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            DrawHorizontalBorder();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Score : {score}");
            Console.WriteLine($"Lines : {clearedLines}");
            Console.WriteLine($"Level : {CurrentLevel}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Next:");
            DrawNextPiecePreview();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Controls: ←/→ move  ↓ soft drop  ↑ rotate  Space hard drop  Esc quit");
            Console.ResetColor();
        }

        private void DrawHorizontalBorder()
        {
            Console.Write('+');
            Console.Write(new string('-', BoardWidth * CellRenderWidth));
            Console.WriteLine('+');
        }

        private bool IsFallingCell(int row, int col, out int id)
        {
            id = 0;
            if (currentPiece == null)
            {
                return false;
            }

            var shape = currentPiece.Rotations[currentRotation];
            var rows = shape.GetLength(0);
            var cols = shape.GetLength(1);

            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < cols; c++)
                {
                    if (!shape[r, c])
                    {
                        continue;
                    }

                    var boardRow = currentRow + r;
                    var boardCol = currentCol + c;
                    if (boardRow == row && boardCol == col)
                    {
                        id = currentPiece.Id;
                        return true;
                    }
                }
            }

            return false;
        }

        private void DrawNextPiecePreview()
        {
            var preview = nextPiece?.Rotations[0];
            var previewSize = 4;
            for (var r = 0; r < previewSize; r++)
            {
                for (var c = 0; c < previewSize; c++)
                {
                    var filled = preview != null && r < preview.GetLength(0) && c < preview.GetLength(1) && preview[r, c];
                    if (filled)
                    {
                        Console.ForegroundColor = nextPiece.Color;
                        Console.Write("[]");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" .");
                    }
                }

                Console.WriteLine();
            }
        }
    }

    internal sealed class Tetromino
    {
        public Tetromino(int id, string name, bool[][,] rotations, ConsoleColor color)
        {
            Id = id;
            Name = name;
            Rotations = rotations;
            Color = color;
        }

        public int Id { get; }
        public string Name { get; }
        public bool[][,] Rotations { get; }
        public ConsoleColor Color { get; }
    }

    internal static class TetrominoFactory
    {
        public static Tetromino[] BuildPieces()
        {
            return new[]
            {
                Create(1, "I", ConsoleColor.Cyan, new[]
                {
                    "....",
                    "####",
                    "....",
                    "...."
                }),
                Create(2, "J", ConsoleColor.Blue, new[]
                {
                    "#...",
                    "###.",
                    "....",
                    "...."
                }),
                Create(3, "L", ConsoleColor.DarkYellow, new[]
                {
                    "..#.",
                    "###.",
                    "....",
                    "...."
                }),
                Create(4, "O", ConsoleColor.Magenta, new[]
                {
                    ".##.",
                    ".##.",
                    "....",
                    "...."
                }),
                Create(5, "S", ConsoleColor.Green, new[]
                {
                    ".##.",
                    "##..",
                    "....",
                    "...."
                }),
                Create(6, "T", ConsoleColor.Red, new[]
                {
                    ".#..",
                    "###.",
                    "....",
                    "...."
                }),
                Create(7, "Z", ConsoleColor.Yellow, new[]
                {
                    "##..",
                    ".##.",
                    "....",
                    "...."
                })
            };
        }

        private static Tetromino Create(int id, string name, ConsoleColor color, string[] pattern)
        {
            var rotations = new bool[4][,];
            rotations[0] = PatternToMatrix(pattern);
            for (var i = 1; i < 4; i++)
            {
                rotations[i] = Rotate(rotations[i - 1]);
            }

            return new Tetromino(id, name, rotations, color);
        }

        private static bool[,] PatternToMatrix(string[] pattern)
        {
            var rows = pattern.Length;
            var cols = pattern[0].Length;
            var matrix = new bool[rows, cols];
            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < cols; c++)
                {
                    matrix[r, c] = pattern[r][c] == '#';
                }
            }

            return matrix;
        }

        private static bool[,] Rotate(bool[,] source)
        {
            var rows = source.GetLength(0);
            var cols = source.GetLength(1);
            var result = new bool[cols, rows];
            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < cols; c++)
                {
                    result[c, rows - 1 - r] = source[r, c];
                }
            }

            return result;
        }
    }
}
