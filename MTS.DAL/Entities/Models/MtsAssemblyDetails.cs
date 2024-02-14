using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MtsAssemblyDetails
    {
        [Key]
        public long Id { get; set; }
        public long MtsSpecificationId { get; set; }
        public long MtsCreatedDetails { get; set; }
        public decimal QuantityOfBlanks { get; set; }
        public decimal Quantity { get; set; }
        public short Changes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
