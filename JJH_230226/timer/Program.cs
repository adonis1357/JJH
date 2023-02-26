﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //타이머 쓰기 위한 변수들
        //==============================
        static IntPtr ConsoleWindowHnd = GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("User32.Dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
        const int VK_RETURN = 0x0D;
        const int WM_KEYDOWN = 0x100;
        //==============================

        static void Main(string[] args)
        {
            //타이머 시작
            theThreadTimer();



            // (진행 하게 될 게임 내용)
            //==============================
            var key = Console.ReadLine();

            //==============================
            System.Console.WriteLine("is done");       //<- 타이머 종료시 ReadLine() 종료됨.

            Thread.Sleep(1000); //1초동안 정지
        }

        static async Task theThreadTimer()
        {
            int theTime = 0;            // 현재 타이머 시간
            int timeLimit = 5;          // 타이머 종료 시간(해당 시간이 되면 꺼짐. 3 -> 3초)
            int count = 0;
            while (theTime < timeLimit)
            {
                await Task.Delay(1000); //1초의 딜레이 (1초가 지났다는 뜻)\
                theTime++;
                count = timeLimit - theTime;
                Console.Clear();
                Console.WriteLine($"카운트 다운: {count}");
            }

            //해당 메세지를 보내면 ReadLine 강제 종료
            //===================================================
            PostMessage(ConsoleWindowHnd, WM_KEYDOWN, VK_RETURN, 0);
            //===================================================
        }

    }
}