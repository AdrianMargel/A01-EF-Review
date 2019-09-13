﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Orders")]
    class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int SalesRepID { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal Freight { get; set; }
        public Boolean Shipped { get; set; }
        public string ShipName { get; set; }
        public int ShipAddressID { get; set; }
        public string Comments { get; set; }
    }
}