using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEstacionesModel.DTO;

namespace GestionEstacionesModel.DAL
{
    public class EstacionesDAL : IEstacionesDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>();

        private EstacionesDAL()
        {

        }

        private static IEstacionesDAL instance;

        public static IEstacionesDAL GetInstance()
        {
            if(instance == null)
            {
                instance = new EstacionesDAL();
            }
            return instance;
        }

        public void Create(Estacion estacion)
        {
            estaciones.Add(estacion);
        }

        public List<Estacion> ReadAll()
        {
            return estaciones;
        }

        public void Remove(Estacion estacion)
        {
            estaciones.Remove(estacion);
        }
    }
}
