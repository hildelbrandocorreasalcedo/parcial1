using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class CreditoService
    {
        private CreditoRepository creditoRepository;
        public CreditoService()
        {
            creditoRepository = new CreditoRepository();
        }
        public string Guardar(Creditos Creditos)
        {
            try
            {
                if (creditoRepository.Buscar(Creditos.Identificacion) == null)
                {
                    creditoRepository.Guardar(Creditos);
                    return $"Los datos de la cuenta numero {Creditos.Identificacion} han sido guardados correctamente";
                }
                return $"!! No es posible registrar la cuenta con numero {Creditos.Identificacion}, porque ya se encuentra registrada!!";
            }
            catch (Exception E)
            {
                return "Error de lectura o escritura de archivos" + E.Message;
            }
        }
        public string Eliminar(int numerodeliquidacion)
        {
            try
            {
                Creditos liquidacioncuotamoderadora = creditoRepository.Buscar(numerodeliquidacion);
                if (liquidacioncuotamoderadora != null)
                {
                    creditoRepository.Eliminar(numerodeliquidacion);
                    Console.WriteLine();
                    Console.WriteLine($"!!Los datos de la cuenta numero {numerodeliquidacion} han sido eliminados correctamente!!");
                    return null;
                }
                Console.WriteLine();
                Console.WriteLine($"!!No es posible eliminar la cuenta con numero {numerodeliquidacion}, porque no se encuentra registrada!!");
                return null;
            }
            catch (Exception E)
            {
                Console.WriteLine("Error de lectura o escritura de archivos" + E.Message);
                return null;
            }
        }

    }
}
