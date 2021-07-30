using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesBD.DAL
{
    public class EstacionesDAL : IEstacionesDAL
    {
        public estaciones_bdEntities entities = new estaciones_bdEntities();

        private EstacionesDAL()
        {

        }

        private static IEstacionesDAL instance;

        public static IEstacionesDAL GetInstance()
        {
            if (instance == null)
            {
                instance = new EstacionesDAL();
            }
            return instance;
        }

        public void Create(Estacion estacion)
        {
            entities.Estacion.Add(estacion);
            entities.SaveChanges();
        }

        public List<Estacion> ReadAll()
        {
            return entities.Estacion.ToList();
        }

        public void Remove(int id)
        {
            Estacion e = entities.Estacion.Find(id);
            entities.Estacion.Remove(e);
            entities.SaveChanges();
        }
    }
}
