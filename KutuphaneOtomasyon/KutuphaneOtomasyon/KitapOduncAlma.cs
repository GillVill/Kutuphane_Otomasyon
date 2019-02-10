using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    class KitapOduncAlma
    {
        private string ogrenciAdi;
        private string ogrenciSoyadi;
        private string kitapAdi;
        private string yazarAdi;
        private DateTime alisTarihi;
        private DateTime teslimTarihi;

        public string OgrenciAdi { get => ogrenciAdi; set => ogrenciAdi = value; }
        public string OgrenciSoyadi { get => ogrenciSoyadi; set => ogrenciSoyadi = value; }
        public string KitapAdi { get => kitapAdi; set => kitapAdi = value; }
        public string YazarAdi { get => yazarAdi; set => yazarAdi = value; }
        public DateTime AlisTarihi { get => alisTarihi; set => alisTarihi = value; }
        public DateTime TeslimTarihi { get => teslimTarihi; set => teslimTarihi = value; }
    }
}
