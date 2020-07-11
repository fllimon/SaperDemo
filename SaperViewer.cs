using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SapperGameProject.Enum;

namespace SapperGameProject
{
    class SaperViewer
    {
        #region ========------ PRIVATE DATA --------=======

        private readonly IGameFieldViewer _owner;

        #endregion

        #region =======------ CTOR ------======

        public SaperViewer(GameField owner)
        {
            _owner = owner;
        }

        #endregion

        public void Show()
        {
            for (int i = 0; i < _owner.NumRows; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < _owner.NumCols; j++)
                {
                    

                    Console.Write($"{_owner[i, j].Image}");
                }
            }
            Console.Write("\n");
        }

        public ActionKey GetActionKey(ConsoleKey someKey)
        {
            ActionKey pressKey = ActionKey.NoAction;
            switch (someKey)
            {
                case ConsoleKey.Enter:
                    pressKey = ActionKey.PressEnter;
                    break;
                case ConsoleKey.Escape:
                    pressKey = ActionKey.PressExit;
                    break;
                case ConsoleKey.LeftArrow:

                    pressKey = ActionKey.PressLeft;
                    Console.CursorLeft--;

                    break;
                case ConsoleKey.UpArrow:

                    pressKey = ActionKey.PressUp;
                    Console.CursorTop--;

                    break;
                case ConsoleKey.RightArrow:

                    pressKey = ActionKey.PressRight;
                    Console.CursorLeft++;

                    break;
                case ConsoleKey.DownArrow:

                    pressKey = ActionKey.PressDown;
                    Console.CursorTop++;

                    break;
                
                default:
                    break;
            }

            return pressKey;
        }
    }
}
