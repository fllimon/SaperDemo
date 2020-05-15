using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapperGameProject
{
    class CheckCell : Cell
    {
        #region ======------ CTOR -----=====

        public CheckCell(GameField owner, Coordinate someCoordinate)
            : base(owner, someCoordinate)
        {

        }

        #endregion

        #region ======----- PROPERTIES -----======

        public override char Image
        {
            get
            {
                return (char)DefaultImage.NoImage;
            }
        }

        #endregion
    }
}
