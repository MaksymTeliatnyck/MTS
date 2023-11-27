using System.ComponentModel.DataAnnotations;

namespace MTS.DAL.Entities.Models
{
    public class MTS_ADDIT_CALCULATION
    {
        [Key]
        public int ID { get; set; }
        //  public int UnitId { get; set; }
        public int MEASURE_ID { get; set; }
    }
}
