using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SapperGameProject
{
    public class GameField : IGameFieldContainer, IGameFieldViewer
    {
        #region =====----- PRIVATE DATA -----=====

        private int _maxBomb = -1;
        private int _maxCheckCell = -1;
        private Dictionary<Coordinate, Cell> _gamefield;
        
        #endregion

        #region =====---- CTOR -----=====

        public GameField()
        {
            _maxCheckCell = DefaultSettings.DEFAULT_MAX_CHECKCELL;
            _maxBomb = DefaultSettings.DEFAULT_MAX_BOMB;
            _gamefield = new Dictionary<Coordinate, Cell>(DefaultSettings.DEFAULT_SIZE_GAME_FIELD * 
                                                          DefaultSettings.DEFAULT_SIZE_GAME_FIELD);
        }

        #endregion

        #region =====----- PROPERTIES -----=====

        public int NumRows { get; set; } = DefaultSettings.DEFAULT_MAX_ROWS;

        public int NumCols { get; set; } = DefaultSettings.DEFAULT_MAX_COLS;

        public int MaxBomb
        {
            get
            {
                return _maxBomb;
            }
        }

        public int MaxCheckCell
        {
            get
            {
                return _maxCheckCell;
            }
        }

        #endregion

        public Cell this[int x, int y]     // ToDo : Вопрос?
        {
            get
            {
                Coordinate position = new Coordinate(x, y);

                return _gamefield[position];
            }

            set
            {
                Coordinate position = new Coordinate(x, y);

                _gamefield[position] = value;
            }
        }

        public char this[Coordinate c]
        {
            get
            {
                ////                _gamefield[c]

                //Cell result = null;

                //char img = (char)DefaultImage.NoImage;

                //if (_gamefield.TryGetValue(c, out result))
                //{
                //    img = result.Image;
                //}

                //return img;

                try
                {
                    return _gamefield[c].Image;
                }
                catch (KeyNotFoundException)
                {
                    return (char)DefaultImage.NoImage;
                }

            }
        }

        //private bool IsEmptyCell(Coordinate coordinate)
        //{
        //    return (_cells[coordinate.X, coordinate.Y] == null);
        //}

        private bool IsEmptyCell(Coordinate coordinate)
        {
            return (_gamefield.ContainsKey(coordinate));
        }

        public bool IsChekBomb(Coordinate c)
        {
            return _gamefield[c] is Bomb;
        } 

        //public void Add(Cell someEntity)
        //{
        //    _gamefield[someEntity.Position.X, someEntity.Position.Y] = someEntity;
        //}

        public void Add(Cell someEntity)
        {
            _gamefield[someEntity.Position] = someEntity;    //ToDo: Вопрос?
        }

        public Coordinate GetCoordinateEmptyCell()
        {
            Coordinate someCoordinate = null;
            Randomyzer rand = Randomyzer.GetInstance();

            do
            {
                someCoordinate = rand.GetRandomCoordinate(NumRows, NumCols);
            } while (IsEmptyCell(someCoordinate));

            return someCoordinate;
        }
    }
}