using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SapperGameProject
{
    public class Coordinate
    {
        #region ======----- PRIVATE DATA -------=======

        private int _x = -1;
        private int _y = -1;

        #endregion

        #region =====----- PROPERTIES -----======

        public int X
        {
            get 
            {
                return _x; 
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        #endregion

        #region ======------ CTOR -----======

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Coordinate(Coordinate source)
            : this(source._x, source._y)
        {

        }

        #endregion

        public override bool Equals(object obj)
        {
            Coordinate someObject = obj as Coordinate;

            if (someObject == null)
            {
                return false;
            }

            return ((X == someObject.X) && (Y == someObject.Y));
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }
    }
}