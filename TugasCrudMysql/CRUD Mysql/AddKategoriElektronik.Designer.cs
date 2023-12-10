namespace CRUD_Mysql
{
    partial class AddKategoriElektronik
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
            this.judulForm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateKat = new System.Windows.Forms.Button();
            this.cmbPenanggungJawab = new System.Windows.Forms.ComboBox();
            this.txtNamaKat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.judulForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 149);
            this.panel1.TabIndex = 10;
            // 
            // judulForm
            // 
            this.judulForm.AutoSize = true;
            this.judulForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulForm.Location = new System.Drawing.Point(16, 58);
            this.judulForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.judulForm.Name = "judulForm";
            this.judulForm.Size = new System.Drawing.Size(305, 32);
            this.judulForm.TabIndex = 4;
            this.judulForm.Text = "Tambah Kategori Elektronik";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCreateKat);
            this.panel2.Controls.Add(this.cmbPenanggungJawab);
            this.panel2.Controls.Add(this.txtNamaKat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(47, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 400);
            this.panel2.TabIndex = 11;
            // 
            // btnCreateKat
            // 
            this.btnCreateKat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreateKat.FlatAppearance.BorderSize = 0;
            this.btnCreateKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateKat.ForeColor = System.Drawing.Color.Black;
            this.btnCreateKat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateKat.Location = new System.Drawing.Point(383, 316);
            this.btnCreateKat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateKat.Name = "btnCreateKat";
            this.btnCreateKat.Size = new System.Drawing.Size(165, 58);
            this.btnCreateKat.TabIndex = 12;
            this.btnCreateKat.Text = "Simpan";
            this.btnCreateKat.UseVisualStyleBackColor = false;
            this.btnCreateKat.Click += new System.EventHandler(this.btnCreateKat_Click);
            // 
            // cmbPenanggungJawab
            // 
            this.cmbPenanggungJawab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPenanggungJawab.FormattingEnabled = true;
            this.cmbPenanggungJawab.Location = new System.Drawing.Point(60, 209);
            this.cmbPenanggungJawab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPenanggungJawab.Name = "cmbPenanggungJawab";
            this.cmbPenanggungJawab.Size = new System.Drawing.Size(487, 26);
            this.cmbPenanggungJawab.TabIndex = 3;
            // 
            // txtNamaKat
            // 
            this.txtNamaKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaKat.Location = new System.Drawing.Point(60, 62);
            this.txtNamaKat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNamaKat.Name = "txtNamaKat";
            this.txtNamaKat.Size = new System.Drawing.Size(487, 24);
            this.txtNamaKat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Penanggung Jawab :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kategori :";
            // 
            // AddKategoriElektronik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 714);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddKategoriElektronik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddKategoriElektronik";
            this.Load += new System.EventHandler(this.AddKategoriElektronik_Load);
            this.Shown += new System.EventHandler(this.AddKategoriElektronik_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label judulForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPenanggungJawab;
        private System.Windows.Forms.TextBox txtNamaKat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateKat;
    }
}