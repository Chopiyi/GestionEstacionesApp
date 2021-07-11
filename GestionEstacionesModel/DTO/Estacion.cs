using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesModel.DTO
{
    public class Estacion
    {
        private int idEstacion;
        private int capacidadMax;
        private string horario;

        public int IdEstacion { get => idEstacion; set => idEstacion = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public string Horario { get => horario; set => horario = value; }
    }
}
