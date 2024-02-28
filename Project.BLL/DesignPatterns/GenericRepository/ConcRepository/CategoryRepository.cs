using Project.BLL.DesignPatterns.GenericRepository.EFBaseRepository;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRepository
{
    public class CategoryRepository : BaseRepository<Category>
    {

        public void CategoryListele()
        {


            List<Category> Categories = new List<Category>()
        {

            new Category { CategoryName = "Kozmetik" },
            new Category { CategoryName = "SuperMarket" },
             new Category { CategoryName = "Elektornik" }

        };




            _db.Categories.AddRange(Categories);

            Save();






        }
    }
}
