﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Supplier : BaseEntity
    {
        public string CompanyName { get; set; }
        public string SupplierName {  get; set; }
            
            //Relational Properties
        
        public virtual List<ProductSupplier> ProductSuppliers { get; set; }
    }
}
