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
        FinancialCrmDbGuncelEntities db = new FinancialCrmDbGuncelEntities();


        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            // fatura dönemlerini getir
            var periodValues = db.BillPeriods.ToList();
            cmbPeriod.DisplayMember = "PeriodName";
            cmbPeriod.ValueMember = "BillPeriodId";
            cmbPeriod.DataSource = periodValues;

            // fatura ödeme durumlarını getir
            cmbIsPaid.Items.Add("Ödendi");
            cmbIsPaid.Items.Add("Ödenmedi");
            cmbIsPaid.SelectedIndex = 0;

            // bankaları getir
            var bankValues = db.Banks.ToList();
            cmbBanks.DisplayMember = "BankTitle";
            cmbBanks.ValueMember = "BankId";
            cmbBanks.DataSource = bankValues;


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
            int period = (int)cmbPeriod.SelectedValue;
            int bankId = (int)cmbBanks.SelectedValue;
            //burada 
            bool isPaid = cmbIsPaid.SelectedItem.ToString() == "Ödendi" ? true : false;
            Bills bill = new Bills();
            bill.BillTitle = title;
            bill.BillAmount = amount;
            bill.BillPeriodId = period;
            bill.IsPaid = isPaid;
            bill.BankId = bankId;
            bill.UserId = 1;
            db.Bills.Add(bill);
            //eğer isPaid true ise, bankadan parayı düş
            if (isPaid)
            {
                var bank= db.Banks.Find(bankId);
                bank.BankBalance -= amount;

            }
            // iki ayrı işlem yaptık, biri fatura ekleme, diğeri banka bakiyesi güncelleme
            // bu yüzden ikisini tek seferde kaydettik
            // tek bir SaveChanges çağrısı ile her iki işlemi de veritabanına yansıttık
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Eklendi");

        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id=int .Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            // eğer fatura ödenmiş ise, bankaya parayı geri ekle
            if (removeValue.IsPaid==true)
            {
                var bank = db.Banks.Find(removeValue.BankId);
                bank.BankBalance += removeValue.BillAmount ?? 0; // null ise 0 ekle
            }
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
            int period = (int)cmbPeriod.SelectedValue;
            bool isPaid = cmbIsPaid.SelectedItem.ToString() == "Ödendi" ? true : false;
            int bankId = (int)cmbBanks.SelectedValue;


            var updateValue = db.Bills.Find(id);
            // eğer ödeme durumu değişmiş ise, bankaya göre işlem yap
            if (updateValue.IsPaid != isPaid)
            {
                var bank = db.Banks.Find(updateValue.BankId);
                if (isPaid) // ödeme durumu ödendi ise, bankadan parayı düş
                {
                    bank.BankBalance -= amount;
                }
                else // ödeme durumu ödenmedi ise, bankaya parayı geri ekle
                {
                    bank.BankBalance += updateValue.BillAmount ?? 0; // null ise 0 ekle
                }
            }
            // fatura bilgilerini güncelle

            updateValue.BillTitle = title;
            updateValue.BillAmount = amount;
            updateValue.BillPeriodId = period;
            updateValue.IsPaid = isPaid;
            updateValue.BankId = bankId;

            db.SaveChanges();
                        
            MessageBox.Show("Fatura Başarıyla Güncellendi");
            var valuse = db.Bills.ToList();
            dataGridView1.DataSource=valuse;
        }

        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtBillId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtBillTitle.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtBillAmount.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cmbPeriod.TabIndex = (int)dataGridView1.Rows[selected].Cells[3].Value;
            cmbIsPaid.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            cmbBanks.TabIndex = (int)dataGridView1.Rows[selected].Cells[5].Value;


        }

        private void btnPaiding_Click(object sender, EventArgs e)
        {
            // burada seçilen fatura id sine göre ödeme yap
            int id = int.Parse(txtBillId.Text);
            var payValue = db.Bills.Find(id);
            if (payValue != null)
            {
                if (payValue.IsPaid == false) // eğer fatura ödenmemiş ise
                {
                    payValue.IsPaid = true; // faturayı ödenmiş yap
                    var bank = db.Banks.Find(payValue.BankId);
                    bank.BankBalance -= payValue.BillAmount ?? 0; // null ise 0 ekle
                    db.SaveChanges();
                    MessageBox.Show("Fatura Başarıyla Ödendi");
                }
                else
                {
                    MessageBox.Show("Fatura Zaten Ödenmiş");
                }
            }
        }
    }
}
