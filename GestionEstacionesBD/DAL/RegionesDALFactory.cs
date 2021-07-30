using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesBD.DAL
{
    public class RegionesDALFactory
    {
        public static IRegionesDAL CreateDAL()
        {
            return RegionesDAL.GetInstance();
        }
    }
}
