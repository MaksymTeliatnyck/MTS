namespace MTS.BLL.DTO.ReportsDTO
{
    public class StoreHouseInventoryDTO
    {
        public int RecId { get; set; }
        public string BalanceNum { get; set; }
        public string Nomenclature { get; set; }
        public string Name { get; set; }
        public decimal RemainsQuantity { get; set; }
        public decimal RemainsSum { get; set; }
    }
}
