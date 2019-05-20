using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;

namespace ODataTables2.Models
{
    [Table(Name="LocationOperators")]
    public class LocationOperators
    {
        private EntityRef<Operator> _op;
        private EntityRef<Location> _loc;
        
        [Column(Name="LocationId", IsPrimaryKey = true)]
        public int LocationId { get; set; }
        [Column(Name="OperatorId", IsPrimaryKey = true)]
        public int OperatorId { get; set;  }

        [Association(Storage = nameof(_op),
            ThisKey = nameof(OperatorId),
            OtherKey = nameof(Models.Operator.OperatorId),
            IsForeignKey = true)]
        public Operator Operator
        {
            get => _op.Entity;
            set => _op.Entity = value;
        }

        [Association(Storage = nameof(_loc),
            ThisKey = nameof(LocationId),
            OtherKey = nameof(Models.Location.LocationId),
            IsForeignKey = true)]
        public Location Location
        {
            get => _loc.Entity;
            set => _loc.Entity = value;
        }
    }
}
