using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //BANKA BAKİYELERİ
            var ziraatBankBalance = db.Banks.Where(b => 
            b.BankTitle == "Ziraat").Select(y=>
            y.BankBalance).FirstOrDefault();
            var vakıfBankBalance = db.Banks.Where(b => 
            b.BankTitle == "VakıfBank").Select(y => 
            y.BankBalance).FirstOrDefault();
            var IsBankBalance = db.Banks.Where(b =>
            b.BankTitle == "İş Bankası").Select(y =>
            y.BankBalance).FirstOrDefault();
            lblZiraatBank.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakıfBank.Text = vakıfBankBalance.ToString() + " ₺";
            lblIsBank.Text = IsBankBalance.ToString() + " ₺";
        //Banka Hareketleri
             var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount + " ₺"+" "+ bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(1).Take(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " ₺" + " " + bankProcess2.ProcessDate;
            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(2).Take(1).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " ₺" + " " + bankProcess3.ProcessDate;
            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(3).Take(1).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " ₺" + " " + bankProcess4.ProcessDate;
            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(4).Take(1).FirstOrDefault();

            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " ₺" + " " + bankProcess5.ProcessDate;

        }
    }
}
