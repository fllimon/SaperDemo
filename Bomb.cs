using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SapperGameProject
{
    public class Bomb : Cell
    {
        #region =====----- CTOR -----======

        public Bomb(GameField owner, Coordinate someCoordinate)
            : base(owner, someCoordinate)
        {

        }

        #endregion

        #region =====----- PROPERTIES -----======

        public override char Image 
        {
            get
            {
                return (char)DefaultImage.BombImage;
            }
        }

        #endregion
    }
}