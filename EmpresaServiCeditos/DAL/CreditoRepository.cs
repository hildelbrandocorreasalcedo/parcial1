using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;

namespace DAL
{
    public class CreditoRepository
    {
        List<Creditos> liquidacionesCuotasModeradoras = new List<Creditos>();
        public List<Creditos> LCreditos { get; set; }

        public void Guardar(Creditos creditos)

        {
            FileStream fileStream = new FileStream(@"C:\Users\Brayan\Documents\Visual Studio 2015\Projects\EmpresaServiCreditos\EmpresaServiCeditos\EmpresaServiCeditos\bin\Debug\Creditos.txt", FileMode.Append);
            StreamWriter stream = new StreamWriter(fileStream);
            stream.WriteLine(creditos.ToString());
            stream.Close();
            fileStream.Close();

        }

        public void Eliminar(int Identificacion)
        {
            liquidacionesCuotasModeradoras.Clear();
            liquidacionesCuotasModeradoras = Consultar();
            FileStream fileStream = new FileStream(@"C:\Users\Brayan\Documents\Visual Studio 2015\Projects\EmpresaServiCreditos\EmpresaServiCeditos\EmpresaServiCeditos\bin\Debug\Creditos.txt", FileMode.Create);
            fileStream.Close();
            foreach (var item in liquidacionesCuotasModeradoras)
            {
                if (item.Identificacion != Identificacion)
                {
                    Guardar(item);
                }
            }

        }

    }
}
