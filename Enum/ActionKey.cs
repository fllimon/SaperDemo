using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapperGameProject.Enum
{
    [Flags]
    enum ActionKey
    {
        NoAction,
        PressEnter,
        PressExit,
        PressLeft,
        PressRight,
        PressUp,
        PressDown
    }
}
