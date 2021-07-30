using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesBD.DAL
{
    public interface IEstacionesDAL
    {
        void Create(Estacion estacion);
        List<Estacion> ReadAll();
        void Remove(int id);
    }
}
