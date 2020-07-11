using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapperGameProject
{
    public interface IGameFieldViewer
    {
        int NumCols { get; }

        int NumRows { get; }

        Cell this[int firstIndex, int secondIndex] { get; set; }

        char this[Coordinate someCoordinate] { get; }
    }
}
