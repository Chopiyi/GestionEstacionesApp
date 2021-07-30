using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesBD.DAL
{
    public class RegionesDAL : IRegionesDAL
    {
        public estaciones_bdEntities entities = new estaciones_bdEntities();

        private RegionesDAL()
        {

        }

        private static IRegionesDAL instance;

        public static IRegionesDAL GetInstance()
        {
            if (instance == null)
            {
                instance = new RegionesDAL();
            }
            return instance;
        }

        public List<Region> ReadAll()
        {
            return entities.Region.ToList();
        }
    }
}
