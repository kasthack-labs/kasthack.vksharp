using System;
using System.Drawing;
using System.Windows.Forms;
using vk.groups.sample.UI;

namespace vk.groups.sample
{
    static class Program
    {
        public static readonly Icon AppIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
