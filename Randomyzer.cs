using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SapperGameProject
{
    public class Randomyzer
    {
        #region ======----- PRIVATE DATA ------=======

        private Random _random;
        private static Randomyzer _instance = null;

        #endregion

        #region ======----- CTOR -----======

        private Randomyzer()
        {
            _random = new Random();
        }

        #endregion

        public static Randomyzer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Randomyzer();
            }

            return _instance;
        }

        public Coordinate GetRandomCoordinate(int numRows, int numCols)
        {
            Coordinate someCoordinate = null;

            int x = _random.Next(0, numRows);
            int y = _random.Next(0, numCols);

            someCoordinate = new Coordinate(x, y);

            return someCoordinate;
        }
    }
}