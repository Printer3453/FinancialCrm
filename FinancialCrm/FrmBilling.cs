using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;
namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();


        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriot.Text;
            Bills bill = new Bills();
            bill.BillTitle = title;
            bill.BillAmount = amount;
            bill.BillPeriod = period;
            db.Bills.Add(bill);
            db.SaveChanges();
            MessageBox.Show("Fatura Oluşturuldu");
            var valuse = db.Bills.ToList();
            dataGridView1.DataSource = valuse;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id=int .Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi");
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            string title = txtBillTitle.Text;
            decimal amount=decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriot.Text;
            var updateValue = db.Bills.Find(id);
            
            updateValue.BillTitle = title;
            updateValue.BillAmount = amount;
            updateValue.BillPeriod = period;
            db.SaveChanges();
            
            MessageBox.Show("Fatura Başarıyla Güncellendi");
            var valuse = db.Bills.ToList();
            dataGridView1.DataSource=valuse;
        }
    }
}
