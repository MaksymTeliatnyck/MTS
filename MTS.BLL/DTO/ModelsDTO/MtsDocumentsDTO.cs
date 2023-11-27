namespace MTS.BLL.DTO.ModelsDTO
{
    public class MtsDocumentsDTO
    {
        public int Id { get; set; }
        public long MtsSpecificationId { get; set; }
        public char[] DocumentScan { get; set; }
        public string FileName { get; set; }
    }
}
