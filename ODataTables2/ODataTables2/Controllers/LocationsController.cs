using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using ODataTables2.Common;
using ODataTables2.Models;

namespace ODataTables2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ODataController
    {
        //[EnableQuery]
        //public IQueryable<Location> Get()
        //{
        //    return DataContextFactory.GetContext().GetTable<Location>();
        //}

        public ActionResult<Location> Get(ODataQueryOptions<Location> opts, string format="")
        {
            //var table =  DataContextFactory.GetContext().GetTable<Location>();
            //return Ok(opts.ApplyTo(table));
            var locations = new List<Location>
            {
                new Location {LocationId = 1, Name = "Loc1", PersonResponsible = "foo"},
                new Location {LocationId = 2, Name = "loc2", PersonResponsible = "bar"},
                new Location {LocationId = 3, Name = "loc3", PersonResponsible = "foo"}
            };
            return Ok(opts.ApplyTo(locations.AsQueryable()));
        }
    }
}
