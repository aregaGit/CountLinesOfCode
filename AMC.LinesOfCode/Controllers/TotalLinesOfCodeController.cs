using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMC.LinesOfCode.Models;
using System.IO;

namespace AMC.LinesOfCode.Controllers
{
    public class TotalLinesOfCodeController : Controller
    {

        
        // GET: TotalLinesOfCode
        public ActionResult Index(TotalLinesOfCodeModel model)

        {
            string rootPath = Server.MapPath("~");

            string path =  rootPath + "Files\\";
            model.FileDirectory = path;
            return View(model);
        }
        
        [HttpPost]
        public ActionResult LinesOfCode(string FileDirectory)
        {
            string path = FileDirectory;
            LineCounterRepository _repository = new LineCounterRepository();
            TotalLinesOfCodeModel model = new TotalLinesOfCodeModel();
            if (String.IsNullOrEmpty(path))
            {
                path = Server.MapPath("~");
            }
            else
            {
                path = @path;
            }
                model.TotalLinesOfCode = _repository.GetCountOfTotalLinesOfCode(path);
                model.TotalFilesProccessed = _repository.GetTotalFilesProcessed(path);
                model.TotalFilesContainCode = _repository.GetTotalFilesProcessed(path);

            return View(model);
        }
    }
}