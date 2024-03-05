using Project.BLL.DesignPatterns.GenericRepository.ConcRepository;
using Project.BLL.DesignPatterns.GenericRepository.EFBaseRepository;
using Project.ENTITIES.Models;
using Project.WinUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _categoryRepository;
        ProductRepository _productRepository;
        public Form1()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();
        }


        void ListCategories()
        {
            lstCategories.DataSource = _categoryRepository.Select(x => new CategoryVM
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description,
                
            });
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts();
        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Kategori ismi Giriniz");
                return;
            }
            Category category = new Category
            {
                CategoryName = txtName.Text,
                Description = txtDescription.Text,
            };
            _categoryRepository.Add(category);
            ListCategories();

           
        }
        CategoryVM _selected;
        private void lstCategories_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex > -1)
            {
                _selected = (CategoryVM)lstCategories.SelectedItem;
                txtName.Text =_selected.CategoryName;
                txtDescription.Text =_selected.Description;
            }
        }

        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Category toBeDeletedCategory = _categoryRepository.Find(_selected.ID);
                _categoryRepository.Delete(toBeDeletedCategory);
                ListCategories();
                _selected = null;
                txtDescription.Text = txtName.Text = null;
            }
            else
            {
                MessageBox.Show("Lütfen Kategori Seçin");
            }
            
            

        }

        private void btnUpdateCategories_Click(object sender, EventArgs e)
        {
            if (_selected !=null)
            {
                Category toBeUpdated = _categoryRepository.Find(_selected.ID);
                toBeUpdated.CategoryName = txtName.Text;
                toBeUpdated.Description = txtDescription.Text;
                _categoryRepository.Update(toBeUpdated);
                ListCategories();
                _selected = null;
                txtDescription.Text=txtName.Text = null;
            }
            else
            {
                MessageBox.Show("Lütfen Kategori Secin");
            }
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();



        }

        void ListProducts()
        {
            lstProducts.DataSource = _productRepository.Select(x => new ProductVM
            {
                ID = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
            });

        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
            {
                MessageBox.Show("Urun ismi Giriniz");
                return;
            }
             Product product = new Product()
            {
                ProductName = txtName.Text,
                UnitPrice = Convert.ToDecimal(txtProductPrice.Text),
                
            };
            _productRepository.Add(product);
            ListProducts();

        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Product toBeDeletedProduct = _productRepository.Find(_selected.ID);
                _productRepository.Delete(toBeDeletedProduct);
                ListProducts();
                _selected = null;
                txtProductName.Text = txtProductPrice.Text = null;
            }
            else
            {
                MessageBox.Show("Lütfen Urun Seçiniz");
            }
        }

        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            if (_selected !=null)
            {
                Product toBeUpdated = _productRepository.Find(_selected.ID);
                toBeUpdated.ProductName = txtProductName.Text;
                toBeUpdated.UnitPrice = Convert.ToDecimal(txtProductPrice.Text);
                _productRepository.Update(toBeUpdated);
                ListProducts();
                _selected = null;
                txtProductName.Text=txtProductPrice.Text = null;
            }
            else
            {
                MessageBox.Show("Lütfen Urun Seciniz");
            }
        }
    }
}
