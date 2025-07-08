using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.DAL.Entities.Models
{
    public class CustomerOrderSpecifications
    {
        [Key]
        public int Id { get; set; }
        public int CustomerOrderId { get; set; }
        public string Name { get; set; }
        public decimal? SinglePrice { get; set; }
        public decimal? SingleCurrencyPrice { get; set; }
        public decimal? Quantity { get; set; }
    }
}
