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
        public void FormuPaneldeAc(Form form)
        {
            pnlWindow.Controls.Clear(); // Önceki formu temizle
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

        private void button2_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "BANKA BAKİYELERİ";
            FormuPaneldeAc(new FrmBanks());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "ÖDEME FATURA FORMU";
            FormuPaneldeAc(new FrmBilling());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblBaslik.Text ="DASHBOARD / GENEL BAKIŞ";
            FormuPaneldeAc(new FrmDashboard());
        }
    }
}
