using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230305
{
    class gameGroundUI
    {
        private int nexusHP;
        public gameGroundUI(int nexusHP)
        {
            this.nexusHP = nexusHP;
        }
        public void DrawgameGroundUI()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(@"









                ┌────┐     
               ┌      ┐   =======================================================================       
              ┌        ┐                                                                                 
              ┌ _______┐                                                                                   
               |       |                                                                                    
               |       |                                                                                   
               |       |                                                                                 
               |_______|  =======================================================================     ");
            Console.WriteLine("");
            Console.Write($"               내구도: {nexusHP}     ");
        }
        public void DrawgameGroundUI2()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(@"









                             
                          =======================================================================       
                                                                                                         
                                                                                                           
                                                                                                            
                                                                                                           
                                                                                                         
                          =======================================================================     ");
        }
        public void DrawgameGroundUI3()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(@"









                   ─     
                ┌─ ─┐     =======================================================================       
              ┌┌     ↖                                                                                   
              ┌   _ _ _┐†                                                                                   
                _  ☆     |                                                                                    
             / ☆     ☆                                                                                   
              /     ☆                                                                                    
               |_______|  =======================================================================     ");
            Console.WriteLine("");
            Console.Write($"               내구도: {nexusHP}     ");
        }
        public void DrawgameGroundUI4()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(@"









                       
                          =======================================================================       
                  ┌ㅁ ─                                                                                 
                  /  ← ↖                                                                              
                 〓   ┐▨  †                                                                                    
               /     ▧ ↖  ▤                                                                                    
              /          ↖                                                                           
               ＠|_ __ __ =======================================================================     ");
            Console.WriteLine("");
            Console.Write($"               내구도: {nexusHP}     ");
        }
        public void DrawgameGroundUI5()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(@"









                       
                          =======================================================================       
                                                                                                       
                  ┌ㅁ ─                                                                                
                  / ← ┐  ↖                                                                                    
               〓  ▧     †                                                                                   
             / /    ▨_▤                                                                                 
             ＠   _  _ __ =======================================================================     ");
            Console.WriteLine("");
            Console.Write($"               내구도: {nexusHP}     ");
        }
    }
}
