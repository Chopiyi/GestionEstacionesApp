using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesBD.DAL
{
    public class PuntosCargaDAL :IPuntosCargaDAL
    {
        public estaciones_bdEntities entities = new estaciones_bdEntities();

        private PuntosCargaDAL()
        {

        }

        private static IPuntosCargaDAL instance;

        public static IPuntosCargaDAL GetInstance()
        {
            if (instance == null)
            {
                instance = new PuntosCargaDAL();
            }
            return instance;
        }

        public void Create(PuntoCarga puntoCarga)
        {
            entities.PuntoCarga.Add(puntoCarga);
            entities.SaveChanges();
        }

        public List<PuntoCarga> ReadAll()
        {
            return entities.PuntoCarga.ToList();
        }

        public List<PuntoCarga> ReadByTipo(string tipo)
        {
            return entities.PuntoCarga.ToList().FindAll(p => p.tipo == tipo);
        }

        public void Update(PuntoCarga puntoCarga)
        {
            PuntoCarga punto = entities.PuntoCarga.Where(p => p.idPunto == puntoCarga.idPunto).First();
            punto.tipo = puntoCarga.tipo;
            punto.capacidadMax = puntoCarga.capacidadMax;
            punto.vencimiento = puntoCarga.vencimiento;
            entities.SaveChanges();
        }
    }
}
