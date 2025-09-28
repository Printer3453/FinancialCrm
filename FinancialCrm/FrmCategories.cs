using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string title = txtCategoryTitle.Text;
            Categories category = new Categories();
            category.CategoryName = title;
            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori Oluşturuldu");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int _id= int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(_id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int _id = int.Parse(txtCategoryId.Text);
            var updateValue = db.Categories.Find(_id);
            updateValue.CategoryName = txtCategoryTitle.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi");
        }

        private void btnGetByCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbCategories.SelectedValue.ToString());
            var values = db.Categories.Where(x=> x.CategoryId==id).ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            //KATEGORİLERi comboBoxa çekme
            var values=db.Categories.ToList();
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.DataSource = values;

        }
    }
}
