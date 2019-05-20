
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Microsoft.AspNet.OData.Builder;

namespace ODataTables2.Models
{
    [Table(Name = "Locations")]
    public class Location
    {
        //private EntityRef<ExpensiveStatistic> _stats;
        //private EntitySet<LocationOperators> _locationsOperators;

        [Column(Name = "LocationId", IsPrimaryKey = true)]
        public int LocationId { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "PersonResponsible")]
        public string PersonResponsible { get; set; }

        //[Association(
        //    Storage=nameof(_stats),
        //    ThisKey=nameof(LocationId),
        //    OtherKey=nameof(ExpensiveStatistic.LocationId), IsForeignKey = true)]
        //public ExpensiveStatistic Statistic {
        //    get => _stats.Entity;
        //    set => _stats.Entity = value;
        //}
        
        //[Association(
        //    Storage=nameof(_locationsOperators),
        //    ThisKey = nameof(LocationId),
        //    OtherKey = nameof(Models.LocationOperators.LocationId), IsForeignKey = true)]
        //public EntitySet<LocationOperators> LocationOperators { get; set; }
    }
}
