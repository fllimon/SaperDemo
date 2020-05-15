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

        char this[int firstIndex, int secondIndex] { get; }
    }
}
