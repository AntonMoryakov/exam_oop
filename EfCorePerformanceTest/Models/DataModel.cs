using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCorePerformanceTest.Models
{
    [Table("DataRecords")]
    public class DataRecord
    {
        [Key]
        public int Id { get; set; }
        
        public string Value { get; set; }
    }
}
