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
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }
        /*
         Burada ne yapıyoruz?
            1. pnlWindow adlı panelin içeriğini temizliyoruz.
            2. Açılacak formun TopLevel özelliğini false yaparak, formun alt form olarak davranmasını sağlıyoruz.
            3. Formun kenarlıklarını kaldırıyoruz.
            4. Formun Dock özelliğini Fill yaparak, paneli tamamen kaplamasını sağlıyoruz.
            5. Formu panelin Controls koleksiyonuna ekliyoruz.
            6. Son olarak formu gösteriyoruz.
            7. Bu yöntem, farklı formları tek bir panel içinde dinamik olarak açmak için kullanışlıdır.
            8. Böylece kullanıcı arayüzü daha düzenli ve kullanıcı dostu olur.
        Formlar arasında geçiş yaparken, her formu ayrı ayrı açmak yerine, 
        bu yöntemi kullanarak tek bir panel içinde formlar arasında geçiş yapabilirsiniz.
         */
        public void FormuPaneldeAc(Form form)
        {
            pnlWindow.Controls.Clear(); // Önceki formu temizle, arkaplanda çalışmasını engelle
            form.TopLevel = false;    // Formu alt form olarak ayarla
            form.FormBorderStyle = FormBorderStyle.None; // Kenarlık kaldır
            form.Dock = DockStyle.Fill; // Paneli tamamen kaplasın
            pnlWindow.Controls.Add(form); // Forma paneli ekle
            form.Show(); // Göster
        }
        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {

            lblBaslik.Text = "BANKA BAKİYELERİ";
            FormuPaneldeAc(new FrmBanks());
        }

       
        private void btnBanks_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "BANKA BAKİYELERİ";
            FormuPaneldeAc(new FrmBanks());
        }

       
        private void btnBills_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "ÖDEME FATURA FORMU";
            FormuPaneldeAc(new FrmBilling());
        }
        

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "DASHBOARD / GENEL BAKIŞ";
            FormuPaneldeAc(new FrmDashboard());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "KATEGORİLER";
            FormuPaneldeAc(new FrmCategories());
        }

        private void btnBankProcesess_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "BANKA İŞLEMLERİ";
            FormuPaneldeAc(new FrmBankProcesses());
        }
    }
}
