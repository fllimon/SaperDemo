using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SapperGameProject
{
    public abstract class Cell
    {
        #region =====----- PRIVATE DATA -----======

        private readonly IGameFieldContainer _owner;
        private readonly Coordinate _coordinate;

        #endregion

        #region =====----- CTOR -----=====

        public Cell(GameField gameField, Coordinate coordinate)
        {
            _owner = gameField;
            _coordinate = coordinate;
        }

        public Cell(GameField gameField, int x, int y)
            : this(gameField, new Coordinate(x, y))
        {

        }

        #endregion

        #region =====----- PROPERTIES -----=====

        public Coordinate Position
        {
            get
            {
                return new Coordinate(_coordinate);
            }
        }

        #endregion

        public abstract char Image { get; }

    }
}