using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio
{
    public static class PConfig
    {
        public static string getnoSoyLaCadena
        {
            get { return Properties.Settings.Default.noSoyLaCadena; }
        }

    }
}
