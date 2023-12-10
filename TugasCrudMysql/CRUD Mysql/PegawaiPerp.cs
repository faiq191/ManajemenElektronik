using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Mysql
{
    internal class PegawaiPerp
    {
        public string nama { get; set; }

        public string alamat { get; set; }

        public DateTime tanggal_lahir { get; set; }

        public string no_telp { get; set; }

        public PegawaiPerp(string nama, string alamat, DateTime tanggal_lahir, string no_telp)
        {
            this.nama = nama;
            this.alamat = alamat;
            this.tanggal_lahir = tanggal_lahir;
            this.no_telp = no_telp;
        }
    }
}
