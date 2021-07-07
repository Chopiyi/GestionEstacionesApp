using GestionEstacionesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesModel.DAL
{
    public interface IPuntosCargaDAL
    {
        void Create(PuntoCarga puntoCarga);
        List<PuntoCarga> ReadAll();
        void Update(PuntoCarga puntoCarga);
        List<PuntoCarga> ReadByTipo(string tipo);
    }
}
