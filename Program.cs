using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace EvcilHayvan
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {


            // Uygulamayı başlat
            ApplicationConfiguration.Initialize();
            Application.Run(new UserLogin()); // Ana formun buysa bırak, değilse adını değiştir
        }

    }
}
