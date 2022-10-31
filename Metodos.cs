using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace estacionamentoApp01
{
    internal class Metodos
    {
        public static double CalcularValor(int tempo, int tipo)
        {
            Convert.ToInt32(tempo);
            Convert.ToInt32(tipo);
            double valor = 4;

            if (tipo == 1)
            {
                valor = 2.00;
                if (tempo <= 120)
                {
                    valor = + 2;
                    if (tempo > 120)
                    valor = 7.00;
                }

            }

            if (tipo == 2)
            {
                valor = 4.00;
                if (tempo <= 120)
                {
                    valor += 4;
                    if (tempo > 120)
                        valor = 12.00;
                }

            }

            if (tipo == 3)
            {
                valor = 5.00;
                if (tempo <= 120)
                {
                    valor = + 5;
                    if(tempo > 120)
                        valor = 15.00;
                }
                
            }
            return valor;

        }
        

        

    }
}
