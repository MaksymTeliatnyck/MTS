namespace MTS.DAL.Entities.Models
{
    public class MTS_USER_RIGHTS
    {
        public int ID { get; set; }
        public short? CAN_WRITE { get; set; }
        public short? EDIT_NOMENCLATURES { get; set; }
        public short? STOREHOUSE_SORTING { get; set; }
    }
}
