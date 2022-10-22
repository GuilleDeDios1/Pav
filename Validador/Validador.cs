using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TPI.Validador
{
    internal class validador
    {   public validador(){}

        public static bool validar(Control.ControlCollection a)
        {   bool van = true;
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }
            foreach (Control item in a) {
                if (item is GroupBox) {
                    foreach (Control item1 in item.Controls) 
                    {
                        if (item1.Text.Trim().Equals(""))
                        {
                            van = false;
                        }
                    }
                    
                    
                }
            }
            if (!van)
            {
                MessageBox.Show("Hay campos incorrectos");
            }
            return van;
        }

        public static void validar_existente() { }
        
    }
}

