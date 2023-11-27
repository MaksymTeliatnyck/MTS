using System.ComponentModel.DataAnnotations;

namespace MTS.DAL.Entities.Models
{
    public class MTS_DEATAILS_PROCESSING
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public int? QUANTITY_OF_PARAMS { get; set; }
    }
}
