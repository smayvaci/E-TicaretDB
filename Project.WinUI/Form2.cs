using Project.BLL.DesignPatterns.GenericRepository.ConcRepository;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form2 : Form
    {
        CategoryRepository _crep;
        ProductRepository _prep;

        public Form2()
        {
            InitializeComponent();
            _crep = new CategoryRepository();
            _prep = new ProductRepository();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _crep.CategoryListele();
            KategoriListele();
            UrunlerVeKategorileriListele();
        }

        private void UrunlerVeKategorileriListele()
        {
            Product p = new Product();
            p.ProductName = txtUrun.Text;
            p.Category = cmbKategoriler.SelectedItem as Category;
            lstUrunler.Items.Add(p);
            lstUrunler.DisplayMember = "ProductName";
            lstUrunler.DisplayMember = "UnitPrice";
            cmbKategoriler.ValueMember = "CategoryID";
            cmbKategoriler.SelectedIndex = -1;
            lstUrunler.SelectedIndex = -1;
            cmbKategoriler.SelectedIndex = lstUrunler.SelectedIndex = -1;
            txtUrun.Text = txtFiyat.Text = "";
        }




        Product _secilen;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                ProductName = txtUrun.Text,
                UnitPrice = Convert.ToDecimal(txtFiyat.Text)

            };


            p.CategoryID = cmbKategoriler.SelectedItem != null ? Convert.ToInt32(cmbKategoriler.SelectedValue) : default(int?);


            UrunlerVeKategorileriListele();
        }

        private void lstUrunler_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                _secilen = lstUrunler.SelectedItem as Product;
                txtFiyat.Text = _secilen.UnitPrice.ToString();
                txtUrun.Text = _secilen.ProductName;
                cmbKategoriler.SelectedValue = _secilen.CategoryID != null ? _secilen.CategoryID : -1;
            }
        }

        private void btnResetle_Click(object sender, EventArgs e)
        {
            cmbKategoriler.SelectedIndex = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_secilen != null)
            {
                _prep.Delete(_secilen);
                UrunlerVeKategorileriListele();
                _secilen = null;

            }
            else
            {
                MessageBox.Show("Lutfen silinecek urunu seciniz");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilen != null)
            {
                _secilen.ProductName = txtUrun.Text;
                _secilen.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
                _secilen.CategoryID = cmbKategoriler.SelectedItem != null ? Convert.ToInt32
                    (cmbKategoriler.SelectedValue) : default(int?);
                UrunlerVeKategorileriListele();
                _secilen = null;
            }
    }
        Category _category;
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKategoriler.SelectedIndex > -1)
            {
                _category=cmbKategoriler.SelectedItem as Category;  
            }
          

        }

        private void KategoriListele()
        {
            cmbKategoriler.SelectedIndex = -1;
            cmbKategoriler.DataSource = _crep.GetActives();
            cmbKategoriler.DisplayMember = "CategoryName";
        }
    }
}
