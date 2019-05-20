using System.Data.Linq.Mapping;

namespace ODataTables2.Models
{
    [Table(Name="ExpensiveStatistic")]
    public class ExpensiveStatistic
    {
        [Column(Name="LocationId", IsPrimaryKey = true)]
        public int LocationId { get; set; }
        [Column(Name="StatisticValue")]
        public int StatisticValue { get; set; }
    }
}
