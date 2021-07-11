using GestionEstacionesModel.DAL;
using GestionEstacionesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionEstacionesWeb
{
    public partial class RegistrarEstacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void button_registrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int capacidad = Convert.ToInt32(capacidad_estacion.Text.Trim());
                string hora_inicio = hora_comienzo.Text.Trim();
                string hora_end = hora_termino.Text.Trim();
                Estacion estacion = new Estacion();
                estacion.CapacidadMax = capacidad;
                estacion.Horario = hora_inicio + " a " + hora_end;
                IEstacionesDAL dal = EstacionesDALFactory.CreateDAL();
                estacion.IdEstacion = dal.ReadAll().Count() + 1;
                dal.Create(estacion);
                Response.Redirect("VerEstaciones.aspx");
            }
        }

        protected void capacidad_cv_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(capacidad_estacion.Text.ToString() == string.Empty)
            {
                capacidad_cv.ErrorMessage = "Debes ingresar la capacidad máxima de la estación";
                args.IsValid = false;
            } else
            {
                int capacidad = Convert.ToInt32(capacidad_estacion.Text.Trim());
                if (capacidad < 0)
                {
                    capacidad_cv.ErrorMessage = "Ingresa un valor mayor 0";
                    args.IsValid = false;
                }
            }
        }

        protected void cv_comienzo_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(hora_comienzo.Text.Trim() == string.Empty)
            {
                cv_comienzo.ErrorMessage = "Debes ingresar el horario de inicio";
                args.IsValid = false;
            }
        }

        protected void cv_termino_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (hora_termino.Text.Trim() == string.Empty)
            {
                cv_termino.ErrorMessage = "Debes ingresar el horario de término";
                args.IsValid = false;
            }
        }
    }
}