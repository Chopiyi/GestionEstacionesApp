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
    public partial class RegistrarPuntoCarga : System.Web.UI.Page
    {
        private string format = "dd-MM-yyyy";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_registrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string dateTxt = Convert.ToDateTime(fecha_vencimiento.Text).ToString(format);
                DateTime fecha = DateTime.ParseExact(dateTxt, format, null);
                int capacidad = Convert.ToInt32(capacidad_punto.Text.Trim());
                string tipo = tipo_punto.SelectedValue;
                PuntoCarga punto = new PuntoCarga();
                punto.Vencimiento = fecha;
                punto.CapacidadMax = capacidad;
                switch (tipo)
                {
                    case "Dual":
                        punto.Tipo = TipoPunto.Dual;
                        break;
                    case "Eléctrico":
                        punto.Tipo = TipoPunto.Eléctrico;
                        break;
                }
                IPuntosCargaDAL dal = PuntosCargaDALFactory.CreateDAL();
                punto.IdPunto = dal.ReadAll().Count() + 1;
                dal.Create(punto);
                Response.Redirect("VerPuntosCarga.aspx");

            }
        }

        protected void cv_capacidad_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (capacidad_punto.Text.ToString() == string.Empty)
            {
                cv_capacidad.ErrorMessage = "Debes ingresar la capacidad máxima del punto de carga";
                args.IsValid = false;
            }
            else
            {
                int capacidad = Convert.ToInt32(capacidad_punto.Text.Trim());
                if (capacidad < 0)
                {
                    cv_capacidad.ErrorMessage = "Ingresa un valor mayor 0";
                    args.IsValid = false;
                }
            }
        }

        protected void cv_fecha_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(fecha_vencimiento.Text.Trim() == string.Empty)
            {
                cv_fecha.ErrorMessage = "Debes ingresar la fecha de vencimiento";
                args.IsValid = false;
            } else
            {

                string fechaTxt = Convert.ToDateTime(fecha_vencimiento.Text).ToString(format);
                DateTime fecha = DateTime.ParseExact(fechaTxt, format, null);
                if(fecha <= DateTime.Today)
                {
                    cv_fecha.ErrorMessage = "La fecha debe ser posterior a la fecha actual";
                    args.IsValid = false;
                }
            }
        }

        protected void cv_tipo_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(tipo_punto.SelectedIndex == 0)
            {
                cv_tipo.ErrorMessage = "Debes seleccionar una opción primero";
                args.IsValid = false;
            }
        }
    }
}