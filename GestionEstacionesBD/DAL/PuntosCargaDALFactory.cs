using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesBD.DAL
{
    public class PuntosCargaDALFactory
    {
        public static IPuntosCargaDAL CreateDAL()
        {
            return PuntosCargaDAL.GetInstance();
        }
    }
}
