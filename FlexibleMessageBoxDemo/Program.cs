using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FlexibleMessageBoxDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Culture = "ja-JP";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static CultureInfo _cultureInfo;
        static string Culture
        {
            get
            {
                if (_cultureInfo == null)
                    return String.Empty;

                return _cultureInfo.Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _cultureInfo = null;
                    return;
                }

                _cultureInfo = new CultureInfo(value);
                System.Threading.Thread.CurrentThread.CurrentCulture = _cultureInfo;
                System.Threading.Thread.CurrentThread.CurrentUICulture = _cultureInfo;
            }
        }
    }
}
