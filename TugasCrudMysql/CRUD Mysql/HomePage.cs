using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Mysql
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            FileStream fs = new FileStream("nama.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string nama = (string)bf.Deserialize(fs);
            fs.Close();

            // Set value pada textbox
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kategoriBuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            KategoriElektronik katelektronik = new KategoriElektronik();
            katelektronik.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pegawai pegawai = new Pegawai();
            pegawai.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvElektronik invelektronik = new InvElektronik();
            invelektronik.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
