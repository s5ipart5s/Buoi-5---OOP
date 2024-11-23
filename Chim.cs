using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Basic
{
    internal class Chim : DongVat
    {
        public Chim(string Ten, string Loai)
        {
            this.Ten = Ten;
            this.Loai = Loai;
        }
        public override void HienThi()
        {
            Console.WriteLine("Ten: " + Ten + " _ Loai:" + Loai);

        }
        public override void Keu()
        {
            Console.WriteLine("Tieng keu [" + Ten + "]: " + "tieng chim keu");
        }
        public override void VaiTro()
        {
            Console.WriteLine("Duong Giua [MidLane]");
        }
    }
}
