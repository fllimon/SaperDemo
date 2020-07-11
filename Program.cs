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

            someAction = GetPressKey(viewer);

            if (ActionKey.PressEnter.HasFlag(someAction))
            {
                Console.Clear();
                manager.Run();
                viewer.Show();
                Console.SetCursorPosition(DefaultSettings.DEFAULT_CURSOR_POSITION_LEFT,
                                          DefaultSettings.DEFAULT_CURSOR_POSITION_TOP);
            }

            do
            {
                someAction = GetPressKey(viewer);

                if (someAction == ActionKey.PressExit)
                {
                    break;
                }

                if (someAction == ActionKey.PressEnter)
                {
                    if ((new Coordinate(Console.CursorLeft, Console.CursorTop) == bomb.Position))
                    {
                        exitGame = true;

                        break;
                    }
                }

            } while ((someAction != ActionKey.PressExit) || (!exitGame));

            Console.ReadKey();
        }

        private static ActionKey GetPressKey(SaperViewer viewer)
        {
            ActionKey someAction;
            do
            {
                someAction = viewer.GetActionKey(Console.ReadKey(true).Key);
            } while (someAction == 0);

            return someAction;
        }
    }
}
