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
using static System.Windows.Forms.DataFormats;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _categoryRepository;
        public Form1()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
        }


        void ListCategories()
        {
            lstCategories.DataSource = _categoryRepository.Select(x => new CategoryVM
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description,
                Products = x.Products
            });
            lstCategories.DataSource = _categoryRepository.GetActives();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
        }

        private void btnListCategories_Click(object sender, EventArgs e)
        {
            ListCategories();
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
    }
}
