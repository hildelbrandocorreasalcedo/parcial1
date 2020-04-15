using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    
        public abstract class Creditos
        {
            public int Identificacion { get; set; }
            public string TipodeTasa { get; set; }
            public decimal ValorCapital { get; set; }
            public decimal TasaDeInteres { get; set; }
            public decimal PeriodoTiempo { get; set; }
            public decimal ValorPagar { get; set; }


            public abstract void CalcularCapitalFinal();
            public Creditos(int identificacion, String tipodeTasa, decimal VA, decimal i, decimal n, decimal VF)
            {
                Identificacion = identificacion;
                TipodeTasa = tipodeTasa;
                ValorCapital = VA;
                TasaDeInteres = i;
                PeriodoTiempo = n;
                ValorPagar = VF;
            }

            public Creditos()
            {
            }


          

            public override string ToString()
            {
                 
                return $"{Identificacion};{TipodeTasa};{ValorCapital};{TasaDeInteres};{PeriodoTiempo}{ValorPagar}"
            }
        }
    }
}
