using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEstacionesModel.DTO;

namespace GestionEstacionesModel.DAL
{
    public class PuntosCargaDAL : IPuntosCargaDAL
    {
        private static List<PuntoCarga> puntosCarga = new List<PuntoCarga>();

        private PuntosCargaDAL()
        {

        }

        private static IPuntosCargaDAL instance;

        public static IPuntosCargaDAL GetInstance()
        {
            if(instance == null)
            {
                instance = new PuntosCargaDAL();
            }
            return instance;
        }

        public void Create(PuntoCarga puntoCarga)
        {
            puntosCarga.Add(puntoCarga);
        }

        public List<PuntoCarga> ReadAll()
        {
            return puntosCarga;
        }

        public List<PuntoCarga> ReadByTipo(string tipo)
        {
            return puntosCarga.FindAll(p => p.Tipo.ToString().Equals(tipo));
        }

        public void Update(PuntoCarga puntoCarga)
        {
            puntosCarga.Remove(puntosCarga.Find(p => p.IdPunto == puntoCarga.IdPunto));
            puntosCarga.Add(puntoCarga);
        }
    }
}
