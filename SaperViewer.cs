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
        private char[,] _hideField;    // ToDo: Dictionary

        #endregion

        #region =======------ CTOR ------======

        public SaperViewer(GameField owner)
        {
            _owner = owner;
            _hideField = new char[_owner.NumRows, _owner.NumCols];
        }

        #endregion

        public void PrintImage()
        {
            for (int i = 0; i < _owner.NumRows; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write("\n");

                for (int j = 0; j < _owner.NumCols; j++)
                {
                    Console.Write($"{_owner[i, j]}");
                }
            }

            Console.Write("\n");
        }

        public void SetHideField()
        {
            for (int i = 0; i < _owner.NumRows; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < _owner.NumCols; j++)
                {
                    Console.SetCursorPosition(j, i + 1);
                    Console.Write($"{_hideField[i, j] = (char)DefaultImage.HideImage}");
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
                    break;
                case ConsoleKey.UpArrow:
                    pressKey = ActionKey.PressUp;
                    break;
                case ConsoleKey.RightArrow:
                    pressKey = ActionKey.PressRight;
                    break;
                case ConsoleKey.DownArrow:
                    pressKey = ActionKey.PressDown;
                    break;
                
                default:
                    break;
            }

            return pressKey;
        }

        //public void OpenHideField()
        //{
        //    for (int i = 0; i < _hideField.Length; i++)
        //    {
        //        for (int j = 0; j < _hideField.Length; j++)
        //        {
        //            _hideField[i, j] = (char)DefaultImage.NoImage;
        //        }
        //    }
        //}

        //public void GetPressKey(ConsoleKey pressKey)
        //{
        //    GetKeys[pressKey] = Console.ReadKey();  // ToDo: ?????
        //}

        //private KeyInfo[] GetKeys =
        //{
        //    new KeyInfo(ConsoleKey.Enter),
        //    new KeyInfo(ConsoleKey.Escape),
        //    new KeyInfo(ConsoleKey.LeftArrow),
        //    new KeyInfo(ConsoleKey.RightArrow),
        //    new KeyInfo(ConsoleKey.UpArrow),
        //    new KeyInfo(ConsoleKey.DownArrow),
        //};

        //private class KeyInfo
        //{
        //    private ConsoleKey _someKey;

        //    public KeyInfo(ConsoleKey someKey)
        //    {
        //        _someKey = someKey;
        //    }
        //}
    }
}
