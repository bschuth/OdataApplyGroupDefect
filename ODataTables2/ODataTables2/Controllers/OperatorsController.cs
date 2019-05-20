using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataTables2.Common;
using ODataTables2.Models;

namespace ODataTables2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorsController: ODataController
    {
        [EnableQuery]
         public IQueryable<Operator> Get()
        {
            return DataContextFactory.GetContext().GetTable<Operator>();
        }

    }
}
