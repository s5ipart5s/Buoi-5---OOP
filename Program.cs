using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Day1_Basic
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<DongVat> dongVats = new List<DongVat>();

            dongVats.Add(new Chim("Anivia", "Freljord"));
            dongVats.Add(new Cho("Nasus", "Noxus"));
            dongVats.Add(new Meo("Yuumi", "Bandle City"));
            dongVats.Add(new Chuot("Twitch", "Zaun"));

            foreach (DongVat dongVat in dongVats)
            {
                dongVat.HienThi();
                dongVat.Keu();
                dongVat.VaiTro();
                Console.WriteLine();
            }

        }
    }
}
