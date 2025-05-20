using MTS.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.BLL.DTO.ModelsDTO
{
    public class CustomerOrdersDTO : ObjectBase
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int? ContractorId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Details { get; set; }
        public decimal? OrderPrice { get; set; }
        public decimal? CurrencyPrice { get; set; }
        public long? AssemblyId { get; set; }
        public int? AgreementId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CustomerOrderId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateShipping { get; set; }
        public int UserId { get; set; }

        public string AssemblyName { get; set; }
        public string Drawing { get; set; }
        public string DesignerName { get; set; }
        public string CurrencyName { get; set; }
        public string ContractorName { get; set; }
        public string AgreementName { get; set; }
        public string UserName { get; set; }

        public string ReceiptNum { get; set; }
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Quantity { get; set; }
        public string UnitLocalName { get; set; }

        public bool Selected { get; set; }
        public string OrderNumberParse { get; set; }
        public int Enable { get; set; }
    }
}
