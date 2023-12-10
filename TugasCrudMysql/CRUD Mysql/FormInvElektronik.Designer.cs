namespace CRUD_Mysql
{
    partial class FormInvElektronik
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
            this.txtCabang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategoriElektronik = new System.Windows.Forms.ComboBox();
            this.txtTahunRilis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateKat = new System.Windows.Forms.Button();
            this.txtJudulElektronik = new System.Windows.Forms.TextBox();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 149);
            this.panel1.TabIndex = 12;
            // 
            // judulForm
            // 
            this.judulForm.AutoSize = true;
            this.judulForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulForm.Location = new System.Drawing.Point(16, 58);
            this.judulForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.judulForm.Name = "judulForm";
            this.judulForm.Size = new System.Drawing.Size(265, 32);
            this.judulForm.TabIndex = 4;
            this.judulForm.Text = "Tambah Data Elektronik";
            this.judulForm.Click += new System.EventHandler(this.judulForm_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtCabang);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbKategoriElektronik);
            this.panel2.Controls.Add(this.txtTahunRilis);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCreateKat);
            this.panel2.Controls.Add(this.txtJudulElektronik);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(49, 175);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 576);
            this.panel2.TabIndex = 13;
            // 
            // txtCabang
            // 
            this.txtCabang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCabang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabang.Location = new System.Drawing.Point(60, 282);
            this.txtCabang.Margin = new System.Windows.Forms.Padding(4);
            this.txtCabang.Name = "txtCabang";
            this.txtCabang.Size = new System.Drawing.Size(487, 24);
            this.txtCabang.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cabang :";
            // 
            // cmbKategoriElektronik
            // 
            this.cmbKategoriElektronik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategoriElektronik.FormattingEnabled = true;
            this.cmbKategoriElektronik.Location = new System.Drawing.Point(60, 177);
            this.cmbKategoriElektronik.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategoriElektronik.Name = "cmbKategoriElektronik";
            this.cmbKategoriElektronik.Size = new System.Drawing.Size(487, 26);
            this.cmbKategoriElektronik.TabIndex = 18;
            // 
            // txtTahunRilis
            // 
            this.txtTahunRilis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTahunRilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTahunRilis.Location = new System.Drawing.Point(60, 383);
            this.txtTahunRilis.Margin = new System.Windows.Forms.Padding(4);
            this.txtTahunRilis.Name = "txtTahunRilis";
            this.txtTahunRilis.Size = new System.Drawing.Size(487, 24);
            this.txtTahunRilis.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tahun Rilis :";
            // 
            // btnCreateKat
            // 
            this.btnCreateKat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreateKat.FlatAppearance.BorderSize = 0;
            this.btnCreateKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateKat.ForeColor = System.Drawing.Color.Black;
            this.btnCreateKat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateKat.Location = new System.Drawing.Point(424, 494);
            this.btnCreateKat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateKat.Name = "btnCreateKat";
            this.btnCreateKat.Size = new System.Drawing.Size(165, 58);
            this.btnCreateKat.TabIndex = 12;
            this.btnCreateKat.Text = "Simpan";
            this.btnCreateKat.UseVisualStyleBackColor = false;
            this.btnCreateKat.Click += new System.EventHandler(this.btnCreateKat_Click);
            // 
            // txtJudulElektronik
            // 
            this.txtJudulElektronik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJudulElektronik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudulElektronik.Location = new System.Drawing.Point(60, 62);
            this.txtJudulElektronik.Margin = new System.Windows.Forms.Padding(4);
            this.txtJudulElektronik.Name = "txtJudulElektronik";
            this.txtJudulElektronik.Size = new System.Drawing.Size(487, 24);
            this.txtJudulElektronik.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Elektronik :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk Elektronik :";
            // 
            // FormInvElektronik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 887);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInvElektronik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInvElektronik";
            this.Load += new System.EventHandler(this.FormInvElektronik_Load);
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
        private System.Windows.Forms.TextBox txtTahunRilis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateKat;
        private System.Windows.Forms.TextBox txtJudulElektronik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategoriElektronik;
        private System.Windows.Forms.TextBox txtCabang;
        private System.Windows.Forms.Label label5;
    }
}