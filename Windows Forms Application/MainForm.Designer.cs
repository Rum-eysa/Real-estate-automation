namespace Windows_Forms_Application
{
    partial class MainForm
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
            btnEvEkleme = new Button();
            btnSorgulama = new Button();
            SuspendLayout();
            // 
            // btnEvEkleme
            // 
            btnEvEkleme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEvEkleme.Location = new Point(127, 180);
            btnEvEkleme.Name = "btnEvEkleme";
            btnEvEkleme.Size = new Size(153, 43);
            btnEvEkleme.TabIndex = 0;
            btnEvEkleme.Text = "Yeni Ev Ekleme";
            btnEvEkleme.UseVisualStyleBackColor = true;
            btnEvEkleme.Click += btnEvEkleme_Click;
            // 
            // btnSorgulama
            // 
            btnSorgulama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSorgulama.Location = new Point(376, 180);
            btnSorgulama.Name = "btnSorgulama";
            btnSorgulama.Size = new Size(188, 43);
            btnSorgulama.TabIndex = 1;
            btnSorgulama.Text = "Sorgulama Listeleme";
            btnSorgulama.UseVisualStyleBackColor = true;
            btnSorgulama.Click += btnSorgulama_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(btnSorgulama);
            Controls.Add(btnEvEkleme);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEvEkleme;
        private Button btnSorgulama;
    }
}