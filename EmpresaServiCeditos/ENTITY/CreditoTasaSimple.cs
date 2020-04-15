using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class CreditoTasaSimple : Creditos
    {
        public CreditoTasaSimple(int identificacion, String tipodeTasa, decimal VA, decimal i, decimal n, decimal VF)
        {
            Identificacion = identificacion;
            TipodeTasa = tipodeTasa;
            ValorCapital = VA;
            TasaDeInteres = i;
            PeriodoTiempo = n;
            ValorPagar = VF;
        }

        public CreditoTasaSimple()
        {
        }

        public override void CalcularCapitalFinal()
        {

            ValorPagar = ValorCapital * (1 + PeriodoTiempo + TasaDeInteres);
            
        }
    }
}
