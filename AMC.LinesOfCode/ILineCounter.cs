using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMC.LinesOfCode
{
    interface ILineCounter
    {
        int GetTotalFilesProcessed();
        int GetCountOfLinesOfCode(string dir);
        int GetTotalNumberOfFilesContainsCode();
    }
}
