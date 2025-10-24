using System.ComponentModel.DataAnnotations.Schema;

namespace Test0001.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public int? OperatorId { get; set; } = 1;
        public Operator Operator { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;
    }
}
