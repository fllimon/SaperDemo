using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SapperGameProject.Enum;

namespace SapperGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitGame = false;

            ActionKey someAction = ActionKey.NoAction;

            Coordinate coordinate = new Coordinate(0, 0);
            GameField gameField = new GameField();
            GameManager manager = new GameManager(gameField);
            Bomb bomb = new Bomb(gameField, coordinate);
            SaperViewer viewer = new SaperViewer(gameField);
            UI viewMenu = new UI();

            viewMenu.PrintGameMenu();

            do
            {
                someAction = viewer.GetActionKey(Console.ReadKey().Key);
            } while (someAction == 0);

            if (ActionKey.PressEnter.HasFlag(someAction))
            {
                Console.Clear();
                manager.Run();
                viewer.PrintImage();
                viewer.SetHideField();

                Console.SetCursorPosition(1, 1);
            }
            Console.ReadKey();
        }
    }
}
