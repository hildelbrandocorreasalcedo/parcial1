using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class CreditoTasaCompuesta : Creditos
    {
        decimal variable1=0;
        decimal variable2=0;
        public CreditoTasaCompuesta(int identificacion, String tipodeTasa, decimal VA, decimal i, decimal n, decimal VF)
        {
            Identificacion = identificacion;
            TipodeTasa = tipodeTasa;
            ValorCapital = VA;
            TasaDeInteres = i;
            PeriodoTiempo = n;
            ValorPagar = VF;
        }

        public CreditoTasaCompuesta()
        {
        }

        public override void CalcularCapitalFinal()
        {
            variable1 = (1 + TasaDeInteres);
            variable2 = Math.Pow(variable1,PeriodoTiempo);
            ValorPagar = ValorCapital * variable2;
        }
    }
}
