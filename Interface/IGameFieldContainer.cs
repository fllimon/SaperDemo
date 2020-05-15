using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SapperGameProject
{
    public interface IGameFieldContainer
    {
        int NumCols { get; }

        int NumRows { get; }

    }
}