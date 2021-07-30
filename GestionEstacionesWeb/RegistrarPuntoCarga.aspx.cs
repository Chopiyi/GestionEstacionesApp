using GestionEstacionesBD;
using GestionEstacionesBD.DAL;
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
        private List<Estacion> estaciones = EstacionesDALFactory.CreateDAL().ReadAll();
        private string format = "dd-MM-yyyy";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(estaciones.Count > 0)
                {
                    ddl_estaciones.DataSource = estaciones;
                    ddl_estaciones.DataValueField = "idEstacion";
                    ddl_estaciones.DataBind();
                    for (int i = 0; i < estaciones.Count; i++)
                    {
                        ddl_estaciones.Items[i].Text = estaciones[i].idEstacion + ": " + estaciones[i].Direccion.calle + " "
                            + estaciones[i].Direccion.numero + ", " + estaciones[i].Region.nombre;

                    }
                    ddl_estaciones.Items.Insert(0, "Seleccione una opción");
                } else
                {
                    ddl_estaciones.Items.Insert(0, "No hay estaciones registradas");
                }
            }

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
                punto.vencimiento = fecha;
                punto.capacidadMax = capacidad;
                punto.tipo = tipo;
                punto.idEstacion = Convert.ToInt32(ddl_estaciones.SelectedValue);
                IPuntosCargaDAL dal = PuntosCargaDALFactory.CreateDAL();
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
            if (fecha_vencimiento.Text.Trim() == string.Empty)
            {
                cv_fecha.ErrorMessage = "Debes ingresar la fecha de vencimiento";
                args.IsValid = false;
            }
            else
            {

                string fechaTxt = Convert.ToDateTime(fecha_vencimiento.Text).ToString(format);
                DateTime fecha = DateTime.ParseExact(fechaTxt, format, null);
                if (fecha <= DateTime.Today)
                {
                    cv_fecha.ErrorMessage = "La fecha debe ser posterior a la fecha actual";
                    args.IsValid = false;
                }
            }
        }

        protected void cv_tipo_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (tipo_punto.SelectedIndex == 0)
            {
                cv_tipo.ErrorMessage = "Debes seleccionar una opción primero";
                args.IsValid = false;
            }
        }

        protected void cv_estaciones_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(ddl_estaciones.SelectedIndex == 0)
            {
                cv_estaciones.ErrorMessage = "Debes seleccionar la estacion del punto de carga";
                args.IsValid = false;
            }
        }
    }
}