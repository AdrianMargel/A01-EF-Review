using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("PaymentTypes")]
    class PaymentType
    {
        [Key]
        public int PaymentTypeID { get; set; }
        public string PaymentTypeDescription { get; set; }
    }
}
