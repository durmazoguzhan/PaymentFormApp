namespace OdemeFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbPaymentTypes = new ComboBox();
            label2 = new Label();
            txtTutar = new TextBox();
            btnPay = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 58);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Yöntemi :";
            // 
            // cmbPaymentTypes
            // 
            cmbPaymentTypes.FormattingEnabled = true;
            cmbPaymentTypes.Items.AddRange(new object[] { "KrediKarti", "MailOrder", "SmsOdeme", "PesinOdeme" });
            cmbPaymentTypes.Location = new Point(283, 55);
            cmbPaymentTypes.Name = "cmbPaymentTypes";
            cmbPaymentTypes.Size = new Size(151, 28);
            cmbPaymentTypes.TabIndex = 1;
            cmbPaymentTypes.SelectedIndexChanged += cmbPaymentTypes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 135);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Tutar :";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(283, 132);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(151, 27);
            txtTutar.TabIndex = 3;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(154, 202);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(280, 35);
            btnPay.TabIndex = 4;
            btnPay.Text = "Ödeme Yap";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(193, 269);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(50, 20);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 340);
            Controls.Add(lblSonuc);
            Controls.Add(btnPay);
            Controls.Add(txtTutar);
            Controls.Add(label2);
            Controls.Add(cmbPaymentTypes);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPaymentTypes;
        private Label label2;
        private TextBox txtTutar;
        private Button btnPay;
        private Label lblSonuc;
    }
}