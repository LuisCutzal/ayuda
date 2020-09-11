using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace IPC2_201700841.Controllers
{
    public class ArchivoCargaController : Controller
    {
        
        // GET: FileUpload
        public ActionResult Index()
        {
            //var items = GetFiles();
            //return View(items);
            
            return View();
        }

        
    }
}