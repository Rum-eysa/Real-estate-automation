namespace Windows_Forms_Application
{
    partial class KayitForm
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
            comboBoxİl = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtOdaSayisi = new TextBox();
            txtAlani = new TextBox();
            radioButtonKiralik = new RadioButton();
            radioButtonSatilik = new RadioButton();
            btnAddHouse = new Button();
            comboBoxSemt = new ComboBox();
            dtpYapimTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // comboBoxİl
            // 
            comboBoxİl.FormattingEnabled = true;
            comboBoxİl.Location = new Point(320, 151);
            comboBoxİl.Name = "comboBoxİl";
            comboBoxİl.Size = new Size(169, 28);
            comboBoxİl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 67);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Oda sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 112);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Alan:";
            // 
            // txtOdaSayisi
            // 
            txtOdaSayisi.Location = new Point(154, 60);
            txtOdaSayisi.Name = "txtOdaSayisi";
            txtOdaSayisi.Size = new Size(125, 27);
            txtOdaSayisi.TabIndex = 3;
            // 
            // txtAlani
            // 
            txtAlani.Location = new Point(154, 105);
            txtAlani.Name = "txtAlani";
            txtAlani.Size = new Size(125, 27);
            txtAlani.TabIndex = 4;
            // 
            // radioButtonKiralik
            // 
            radioButtonKiralik.AutoSize = true;
            radioButtonKiralik.Location = new Point(432, 65);
            radioButtonKiralik.Name = "radioButtonKiralik";
            radioButtonKiralik.Size = new Size(71, 24);
            radioButtonKiralik.TabIndex = 5;
            radioButtonKiralik.TabStop = true;
            radioButtonKiralik.Text = "Kiralık";
            radioButtonKiralik.UseVisualStyleBackColor = true;
            // 
            // radioButtonSatilik
            // 
            radioButtonSatilik.AutoSize = true;
            radioButtonSatilik.Location = new Point(529, 67);
            radioButtonSatilik.Name = "radioButtonSatilik";
            radioButtonSatilik.Size = new Size(70, 24);
            radioButtonSatilik.TabIndex = 6;
            radioButtonSatilik.TabStop = true;
            radioButtonSatilik.Text = "Satılık";
            radioButtonSatilik.UseVisualStyleBackColor = true;
            // 
            // btnAddHouse
            // 
            btnAddHouse.Location = new Point(580, 242);
            btnAddHouse.Name = "btnAddHouse";
            btnAddHouse.Size = new Size(94, 29);
            btnAddHouse.TabIndex = 7;
            btnAddHouse.Text = "Kaydet";
            btnAddHouse.UseVisualStyleBackColor = true;
            
            // 
            // comboBoxSemt
            // 
            comboBoxSemt.FormattingEnabled = true;
            comboBoxSemt.Location = new Point(505, 151);
            comboBoxSemt.Name = "comboBoxSemt";
            comboBoxSemt.Size = new Size(169, 28);
            comboBoxSemt.TabIndex = 8;
            // 
            // dtpYapimTarihi
            // 
            dtpYapimTarihi.Location = new Point(174, 241);
            dtpYapimTarihi.Name = "dtpYapimTarihi";
            dtpYapimTarihi.Size = new Size(250, 27);
            dtpYapimTarihi.TabIndex = 9;
            // 
            // KayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpYapimTarihi);
            Controls.Add(comboBoxSemt);
            Controls.Add(btnAddHouse);
            Controls.Add(radioButtonSatilik);
            Controls.Add(radioButtonKiralik);
            Controls.Add(txtAlani);
            Controls.Add(txtOdaSayisi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxİl);
            Name = "KayitForm";
            Text = "KayitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxİl;
        private Label label1;
        private Label label2;
        private TextBox txtOdaSayisi;
        private TextBox txtAlani;
        private RadioButton radioButtonKiralik;
        private RadioButton radioButtonSatilik;
        private Button btnAddHouse;
        private ComboBox comboBoxSemt;
        private DateTimePicker dtpYapimTarihi;
    }
}