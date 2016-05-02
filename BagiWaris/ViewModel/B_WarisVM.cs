using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BagiWaris.Model;

namespace BagiWaris.ViewModel
{
    public class B_WarisVM
    {
    public List<Bwaris> _bwaris { get; set; }
    public void loadData()
    {
            _bwaris = new List<Bwaris>();
            _bwaris.Add(new Bwaris() { Isi = "Aplikasi ini dibuat agar memudahkan pengguna dalam menghitung harta waris. jika terdapat kesalahan atau bug yang terjadi bisa menghubungi alamat email : qarni73@outlook.com"});
    }
    }
}
