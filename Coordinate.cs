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
            return GetShift(X.GetHashCode(), 2) ^ Y.GetHashCode();
        }

        private int GetShift(int value, int positions)
        {
            positions = positions & 0x1F;

            uint number = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
            uint warpped = number >> (32 - positions);

            return BitConverter.ToInt32(BitConverter.GetBytes((number << positions) | warpped), 0);
        }
    }
}