using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Basic
{
    internal abstract class DongVat
    {
        public string Ten;
        public string Loai;

        public abstract void HienThi();
        public abstract void Keu();

        public virtual void VaiTro()
        {
            Console.WriteLine("Duong Duoi [BotLane]");
        }
    }
}
