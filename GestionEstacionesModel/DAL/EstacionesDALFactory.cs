using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesModel.DAL
{
    public class EstacionesDALFactory
    {
        public static IEstacionesDAL CreateDAO()
        {
            return EstacionesDAL.GetInstance();
        }
    }
}
