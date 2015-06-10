using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using vk.auth.sample.UI;
using vk.groups.sample.UI;

namespace vk.auth.sample
{
    static class Program {
        public static readonly Icon AppIcon = Icon.ExtractAssociatedIcon( Application.ExecutablePath );
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAction());
        }
    }
}
