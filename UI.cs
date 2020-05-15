using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapperGameProject
{
    class UI
    {
        #region ======----- PRIVATE DATA ------======

        //private readonly IGameFieldViewer _owner;

        #endregion

        public void PrintGameMenu()
        {
            Console.WriteLine("---------------------- SAPPER CLASSIC ---------------------");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("----------------------- GAME MENU -------------------------");
            Console.WriteLine("```````````````````````````````````````````````````````````");            
            Console.WriteLine("```````````````````````````````````````````````````````````");
            Console.WriteLine("`````````````Press <ENTER> to START the game ``````````````");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("````````` Press <ESC> to EXIT ``````````");
            Console.WriteLine("`Left Arrow ◄ -  Up Arrow ▲ - Down Arrow ▼ - Right Arrow - ► `");
        } 
    }
}
