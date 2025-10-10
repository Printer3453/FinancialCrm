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
        FinancialCrmDbGuncelEntities db = new FinancialCrmDbGuncelEntities();

        void BankaBakiye()
        {
            var ziraatBankBalance = db.Banks.Where(b =>
            b.BankTitle == "Ziraat Bankası").Select(y =>
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
        }

        void BankaHareketleri()
        {
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount + " ₺" + " " + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(1).Take(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " ₺" + " " + bankProcess2.ProcessDate;
            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(2).Take(1).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " ₺" + " " + bankProcess3.ProcessDate;
            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(3).Take(1).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " ₺" + " " + bankProcess4.ProcessDate;
            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(4).Take(1).FirstOrDefault();

            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " ₺" + " " + bankProcess5.ProcessDate;

        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyelerini Yeniden Hesapla
            BankaBakiyeleriniYenidenHesapla();
            //BANKA BAKİYELERİ
            BankaBakiye();

            //Banka Hareketleri
            BankaHareketleri();
            

        }

        


        public void BankaBakiyeleriniYenidenHesapla()
        {
            //Burada bir banka bakiyelerini yeniden hesaplama fonksiyonu yazıyoruz.
            //Ama şöyle bir durum var:
            //1. BankProcesses (Gelen/Giden Havale)
            //2. Bills (Ödenmiş faturalar)
            //3. Spendings (Harcamalar)
            // Yukarıdaki üç tablodaki işlemleri dikkate alarak, her bankanın bakiyesini yeniden hesaplayacağız.
            //
            var bankalar = db.Banks.ToList();

            foreach (var banka in bankalar)
            {
                decimal toplamBakiye = 0;

                // 1. BankProcesses (Gelen/Giden Havale)
                var islemler = db.BankProcesses
                    .Where(x => x.BankId == banka.BankId)
                    .ToList();

                foreach (var islem in islemler)
                {
                    var processType = db.ProcessTypes
                        .Where(pt => pt.ProcessTypeId == islem.ProcessTypeId)
                        .Select(pt => pt.ProcessTypeName)
                        .FirstOrDefault();

                    if (processType == "Gelen Havale")
                        toplamBakiye += decimal.Parse( islem.Amount.ToString());
                    else if (processType == "Giden Havale")
                        toplamBakiye -=decimal.Parse(islem.Amount.ToString());
                }




                // 2. Bills (Ödenmiş faturalar)
                var odenenFaturalar = db.Bills
                    .Where(b => b.BankId == banka.BankId && b.IsPaid == true)
                    .ToList();

                foreach (var fatura in odenenFaturalar)
                {
                    toplamBakiye -= decimal.Parse(fatura.BillAmount.ToString());
                }

                // 3. Spendings (Harcamalar)
                var harcamalar = db.Spendings
                    .Where(s => s.BankId == banka.BankId)
                    .ToList();

                foreach (var harcama in harcamalar)
                {
                    toplamBakiye -= decimal.Parse(harcama.SpendingAmount.ToString());
                }

                // Güncelle
                banka.BankBalance = toplamBakiye;
            }

            db.SaveChanges();
        }

        private void btnBakiyeReset_Click(object sender, EventArgs e)
        {
            BankaBakiyeleriniYenidenHesapla();
        }
    }

}

