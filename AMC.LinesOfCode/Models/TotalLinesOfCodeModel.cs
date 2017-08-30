using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AMC.LinesOfCode.Models
{
    public class TotalLinesOfCodeModel
    {
        public int Id;
        public string FileDirectory;
        public int TotalFilesProccessed;
        public int TotalFilesContainCode;
        public int TotalLinesOfCode;
    }
}