﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WinUI.ViewModels
{
    public class CategoryVM
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Product> Products { get; set; }


        public override string ToString()
        {
            return CategoryName;
        }

      
    }
}
