using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Mysql
{
    internal class Inven
    {
        internal object kategori_elektronik;
        internal object kategori_Elektronik;

        public string judul_elektronik { get; set; }

        //public string kategori_elektronik { get; set; }
        
        public string cabang { get; set; }
        
        public string tahun_rilis { get; set; }

        public Inven(string judul_elektronik, string kategori_elektronik, string cabang, string tahun_rilis)
        {
            this.judul_elektronik = judul_elektronik;
            this.kategori_elektronik = kategori_elektronik;
            this.cabang = cabang;
            this.tahun_rilis = tahun_rilis;
        }
    }
}
