﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.BLL.DTO.ModelsDTO
{
    public class MTSCustomerOrdersDTO
    {
        public int Id { get; set; }
        public int? SpecificationId { get; set; }
        public int? CustomerOrderId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }

        public string OrderNumber { get; set; }
        public string ContractorName { get; set; }
        public DateTime? DataCreateCustomerOrder { get; set; }
    }
}
