﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Basic
{
    internal class Chuot : DongVat
    {
        public Chuot(string Ten, string Loai)
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
            Console.WriteLine( "Tieng keu [" + Ten + "]: " + "Chit Chit");
        }
        public override void VaiTro()
        {
            base.VaiTro();
        }
    }
}
