using System.ComponentModel.DataAnnotations;

namespace MTS.DAL.Entities.Models
{
    public class MTS_MEASURE
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }

    }
}
