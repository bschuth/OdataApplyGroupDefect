using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ODataTables2.Controllers
{
    public class ReportsController : Controller
    {
        public FileContentResult Index(string guid)
        {
            return new FileContentResult(Encoding.UTF8.GetBytes("foobar"), "text/plain"); 
        }
    }
}