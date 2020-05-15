using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapperGameProject
{
    class GameManager
    {
        #region ======------ PRIVATE DATA -------======

        private readonly GameField _owner;
        private int _bombCount = 0;
        
        #endregion

        #region ======------ CTOR ------======

        public GameManager(GameField owner)
        {
            _owner = owner;
        }

        #endregion

        #region ======------ PROPERTIES ------======

        public int BombCount
        {
            get
            {
                return _bombCount;
            }
        }

        #endregion

        private void AddBomb()
        {
            for (int i = 0; i < _owner.MaxBomb; i++)
            {
                Coordinate someCoordinate = _owner.GetCoordinateEmptyCell();

                _owner.Add(new Bomb(_owner, someCoordinate));

                _bombCount++;
            }
        }

        private void AddCheckCell()
        {
            for (int i = 0; i < _owner.MaxCheckCell; i++)
            {
                Coordinate someCoordinate = _owner.GetCoordinateEmptyCell();

                _owner.Add(new CheckCell(_owner, someCoordinate));
            }
        }

        public void Run()
        {
            AddBomb();
            AddCheckCell();
        }
    }
}
