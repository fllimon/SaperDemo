using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SapperGameProject
{
    public class GameField : IGameFieldContainer, IGameFieldViewer
    {
        #region =====----- PRIVATE DATA -----=====

        private int _maxBomb = -1;
        private int _maxCheckCell = -1;
        private int _numRows = -1;
        private int _numCols = -1;
        private readonly Cell[,] _cells;
        private readonly Dictionary<Coordinate, Cell> _gamefield;
        
        #endregion

        #region =====---- CTOR -----=====

        public GameField(int numRows = DefaultSettings.DEFAULT_MAX_ROWS,
                         int numCols = DefaultSettings.DEFAULT_MAX_COLS)
        {
            _numRows = numRows;
            _numCols = numCols;
            _maxCheckCell = DefaultSettings.DEFAULT_MAX_CHECKCELL;
            _maxBomb = DefaultSettings.DEFAULT_MAX_BOMB;
            _cells = new Cell[numRows, numCols];
            _gamefield = new Dictionary<Coordinate, Cell>(DefaultSettings.DEFAULT_MAX_ROWS * DefaultSettings.DEFAULT_MAX_COLS);
        }

        #endregion

        #region =====----- PROPERTIES -----=====

        public int NumRows
        {
            get
            {
                return _numRows;
            }
        }

        public int NumCols
        {
            get
            {
                return _numCols;
            }
        }

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

        public char this[int firstIndex, int secondIndex]
        {
            get
            {
                char img = (char)DefaultImage.NoImage;
                if (_cells[firstIndex, secondIndex] != null)
                {
                    img = _cells[firstIndex, secondIndex].Image;
                }

                return img;

                //return this[new Coordinate(firstIndex, secondIndex)];
            }
        }

        public char this[Coordinate c]
        {
            get
            {
                //                _gamefield[c]

                Cell result = null;

                char img = (char)DefaultImage.NoImage;

                if (_gamefield.TryGetValue(c, out result))
                {
                    img = result.Image;
                }
                
                return img;

                //try
                //{
                //    return _gamefield[c].Image;
                //}
                //catch (KeyNotFoundException)
                //{
                //    return (char)DefaultImage.NoImage;
                //}

            }
        }

        private bool IsEmptyCell(Coordinate coordinate)
        {
            return (_cells[coordinate.X, coordinate.Y] == null);
        }

        public void Add(Cell someEntity)
        {
            _cells[someEntity.Position.X, someEntity.Position.Y] = someEntity;
        }

        public Coordinate GetCoordinateEmptyCell()
        {
            Coordinate someCoordinate = null;
            Randomyzer rand = Randomyzer.GetInstance();

            do
            {
                someCoordinate = rand.GetRandomCoordinate(NumRows, NumCols);
            } while (!IsEmptyCell(someCoordinate));

            return someCoordinate;
        }
    }
}