using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesModel.DTO
{
    public class Estacion
    {
        private int idEstaciom;
        private int capacidadMax;
        private string horario;

        public int IdEstaciom { get => idEstaciom; set => idEstaciom = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public string Horario { get => horario; set => horario = value; }
    }
}
