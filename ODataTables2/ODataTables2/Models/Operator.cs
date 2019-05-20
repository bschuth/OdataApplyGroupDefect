using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Threading.Tasks;

namespace ODataTables2.Models
{
    [Table(Name="Operators")]
    public class Operator
    {
        [Column(Name="OperatorId", IsPrimaryKey = true)]
        public int OperatorId { get; set; }
        [Column(Name="OperatorName")]
        public string OperatorName { get; set; }
    }
}
