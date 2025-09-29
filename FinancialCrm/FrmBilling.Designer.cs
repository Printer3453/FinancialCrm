namespace FinancialCrm
{
    partial class FrmBilling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnRemoveBill = new System.Windows.Forms.Button();
            this.btnBillList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.cmbIsPaid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBanks = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPaiding = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPaiding);
            this.panel1.Controls.Add(this.cmbBanks);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbIsPaid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbPeriod);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnUpdateBill);
            this.panel1.Controls.Add(this.btnCreateBill);
            this.panel1.Controls.Add(this.btnRemoveBill);
            this.panel1.Controls.Add(this.btnBillList);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBillAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBillTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBillId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 244);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 13;
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBill.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBill.Location = new System.Drawing.Point(605, 134);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(145, 55);
            this.btnUpdateBill.TabIndex = 12;
            this.btnUpdateBill.Text = "Fatura Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateBill.ForeColor = System.Drawing.Color.White;
            this.btnCreateBill.Location = new System.Drawing.Point(221, 134);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(145, 55);
            this.btnCreateBill.TabIndex = 11;
            this.btnCreateBill.Text = "Fatura  Ekle";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnRemoveBill
            // 
            this.btnRemoveBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.btnRemoveBill.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveBill.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBill.Location = new System.Drawing.Point(413, 134);
            this.btnRemoveBill.Name = "btnRemoveBill";
            this.btnRemoveBill.Size = new System.Drawing.Size(145, 55);
            this.btnRemoveBill.TabIndex = 11;
            this.btnRemoveBill.Text = "Fatura  Sil";
            this.btnRemoveBill.UseVisualStyleBackColor = false;
            this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.btnBillList.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillList.ForeColor = System.Drawing.Color.White;
            this.btnBillList.Location = new System.Drawing.Point(29, 134);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(145, 55);
            this.btnBillList.TabIndex = 10;
            this.btnBillList.Text = "Fatura Listele";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ödeme Dönemi:";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillAmount.Location = new System.Drawing.Point(793, 12);
            this.txtBillAmount.Multiline = true;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(149, 23);
            this.txtBillAmount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(657, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fatura Ücreti:";
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillTitle.Location = new System.Drawing.Point(501, 12);
            this.txtBillTitle.Multiline = true;
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(149, 23);
            this.txtBillTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fatura Başlık:";
            // 
            // txtBillId
            // 
            this.txtBillId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillId.Location = new System.Drawing.Point(164, 12);
            this.txtBillId.Multiline = true;
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(149, 23);
            this.txtBillId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fatura Id:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 347);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Location = new System.Drawing.Point(164, 76);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(149, 21);
            this.cmbPeriod.TabIndex = 14;
            // 
            // cmbIsPaid
            // 
            this.cmbIsPaid.FormattingEnabled = true;
            this.cmbIsPaid.Location = new System.Drawing.Point(501, 76);
            this.cmbIsPaid.Name = "cmbIsPaid";
            this.cmbIsPaid.Size = new System.Drawing.Size(149, 21);
            this.cmbIsPaid.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(331, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ödeme Durumu:";
            // 
            // cmbBanks
            // 
            this.cmbBanks.FormattingEnabled = true;
            this.cmbBanks.Location = new System.Drawing.Point(793, 76);
            this.cmbBanks.Name = "cmbBanks";
            this.cmbBanks.Size = new System.Drawing.Size(149, 21);
            this.cmbBanks.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(716, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Banka:";
            // 
            // btnPaiding
            // 
            this.btnPaiding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.btnPaiding.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaiding.ForeColor = System.Drawing.Color.White;
            this.btnPaiding.Location = new System.Drawing.Point(797, 134);
            this.btnPaiding.Name = "btnPaiding";
            this.btnPaiding.Size = new System.Drawing.Size(145, 55);
            this.btnPaiding.TabIndex = 19;
            this.btnPaiding.Text = "Faturayı Öde";
            this.btnPaiding.UseVisualStyleBackColor = false;
            this.btnPaiding.Click += new System.EventHandler(this.btnPaiding_Click);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBilling";
            this.Text = "FrmBilling";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnRemoveBill;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.ComboBox cmbBanks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIsPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPaiding;
    }
}