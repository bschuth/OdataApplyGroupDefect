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
        public ActionResult<Location> Get(ODataQueryOptions<Location> opts, string format="")
        {
            // If one attempts to access /odata/locations?$apply=groupby((PersonResponsible))
            // to this context, you get
            // System.NotSupportedException: Comparison operators not supported
            // for type 'Syste m.Collections.Generic.Dictionary`2[System.String, System.Object]'.
            var table = DataContextFactory.GetContext().GetTable<Location>();
            return Ok(opts.ApplyTo(table));

            // Comment the above and uncomment the below to show
            // $apply=groupby((PersonResponsible)) working correctly.

            //var locations = new List<Location>
            //{
            //    new Location {LocationId = 1, Name = "Loc1", PersonResponsible = "foo"},
            //    new Location {LocationId = 2, Name = "loc2", PersonResponsible = "bar"},
            //    new Location {LocationId = 3, Name = "loc3", PersonResponsible = "foo"}
            //};
            //return Ok(opts.ApplyTo(locations.AsQueryable()));
        }
    }
}
