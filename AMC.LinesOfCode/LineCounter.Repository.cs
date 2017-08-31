using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMC.LinesOfCode
{
        public class LineCounterRepository 
        {
        public LineCounterRepository()
        {
           
        }
        public DirectoryInfo _directoryInfo;
        public int totalFilesProcessed;
        public int totalNoOfFilesContainsCode;
        public int totalLinesOfCode;
        public List<string> fileNameExtensions = new List<string>
        {
            ".cs",
            ".aspx",
            ".ascx",
            ".css",
            ".html",
            ".htm",
            ".js",
            ".xsl",
            ".xslt"
        };
            public int GetCountOfTotalLinesOfCode( string path )
            {

                if (path == null)
                {
                    path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                }
                else
                {
                    path = @path;
                }
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                FileInfo[] files = dirInfo.GetFiles("*.*",SearchOption.AllDirectories);
                foreach (var file in files) 
                {
                    if (fileNameExtensions.Contains(file.Extension))
                    {
                        totalLinesOfCode += CountLines(file);
                        totalFilesProcessed++;  
                    }
                }
            return totalLinesOfCode;
            }

            private int CountLines(FileInfo file)
            {
                int count=0;
                StreamReader rd = file.OpenText();
                while (rd.ReadLine() != null)
                count++;
                if (count> 0)
                totalNoOfFilesContainsCode++;

                return count;
            }

            public int GetTotalFilesProcessed(string path)
            {
          
                return totalFilesProcessed;
            }

            public int GetTotalNumberOfFilesContainsCode()
            {
                 return totalNoOfFilesContainsCode;
            }
        }
}