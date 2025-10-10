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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbGuncelEntities db = new FinancialCrmDbGuncelEntities();
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString()+" ₺";

            var internetFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
            lblBillAmount.Text = internetFaturasi.ToString() + " ₺";
            lblBillTitle.Text = "İnternet Faturası";

            var gelenSonHavale= db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            var gelenSonHavaleAciklama = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Description).FirstOrDefault();
            lblLastBankProcessTitle.Text = gelenSonHavaleAciklama;
            lblLastBankProcessAmount.Text = gelenSonHavale.ToString() + " ₺";

            //char
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            var series = chart1.Series["Series1"];
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            var series2 = chart2.Series["Faturalar"];
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        int count = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count %4 ==1)
            {
                var elektrikFaturasi = db.Bills.Where(x=> x.BillTitle== "Elektrik Faturası").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
            }
            if (count % 4 == 2)
            {
                
                var dogalgazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillAmount.Text = dogalgazFaturasi.ToString() + " ₺";
                lblBillTitle.Text = "Doğalgaz Faturası";
            }
            if (count % 4 == 3)
            {
                
                var suFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillAmount.Text = suFaturasi.ToString() + " ₺";
                lblBillTitle.Text = "Su Faturası";
            }
            if (count % 4 == 0)
            {
                
                var internetFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillAmount.Text = internetFaturasi.ToString() + " ₺";
                lblBillTitle.Text = "İnternet Faturası";
               
            }

        }
    }
}
