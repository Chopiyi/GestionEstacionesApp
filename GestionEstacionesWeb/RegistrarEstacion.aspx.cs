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
    public partial class RegistrarEstacion : System.Web.UI.Page
    {
        private List<Region> regiones = RegionesDALFactory.CreateDAL().ReadAll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_region.DataSource = regiones;
                ddl_region.DataValueField = "idRegion";
                ddl_region.DataTextField = "nombre";
                ddl_region.DataBind();
                ddl_region.Items.Insert(0, "Seleccione una opción");
                ddl_region.SelectedIndex = 0;
            }
        }
        protected void button_registrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int capacidad = Convert.ToInt32(capacidad_estacion.Text.Trim());
                string hora_inicio = hora_comienzo.Text.Trim();
                string hora_end = hora_termino.Text.Trim();
                int id_select = Convert.ToInt32(ddl_region.SelectedValue);
                string calle = direccion_calle.Text.Trim();
                int numero = Convert.ToInt32(direccion_numero.Text.Trim());
                string sector = direccion_sector.Text.Trim();
                Direccion dir = new Direccion()
                {
                    calle = calle,
                    numero = numero,
                    sector = sector
                };
                Estacion estacion = new Estacion();
                estacion.capacidadMax = capacidad;
                estacion.horario = hora_inicio + " a " + hora_end;
                estacion.Direccion = dir;
                estacion.idRegion = id_select;
                IEstacionesDAL dal = EstacionesDALFactory.CreateDAL();
                dal.Create(estacion);
                Response.Redirect("VerEstaciones.aspx");
            }
        }

        protected void capacidad_cv_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (capacidad_estacion.Text.ToString() == string.Empty)
            {
                capacidad_cv.ErrorMessage = "Debes ingresar la capacidad máxima de la estación";
                args.IsValid = false;
            }
            else
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
            if (hora_comienzo.Text.Trim() == string.Empty)
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

        protected void cv_calle_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(direccion_calle.Text.Trim() == string.Empty)
            {
                cv_calle.ErrorMessage = "Debes ingresar el nombre de la calle";
                args.IsValid = false;
            }
        }

        protected void cv_numero_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(direccion_numero.Text.Trim() == string.Empty)
            {
                cv_numero.ErrorMessage = "Debes ingresar el número de la dirección";
                args.IsValid = false;
            } else if(Convert.ToInt32(direccion_numero.Text.Trim()) < 0)
            {
                cv_numero.ErrorMessage = "Ingresa un número mayor a 0. Si no tiene número, dejalo en 0";
                args.IsValid = false;
            }
        }

        protected void cv_sector_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(direccion_sector.Text.Trim() == string.Empty)
            {
                cv_sector.ErrorMessage = "Ingresa el sector donde está ubicada la estación";
                args.IsValid = false;
            }
        }

        protected void cv_region_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(ddl_region.SelectedIndex == 0)
            {
                cv_region.ErrorMessage = "Debes seleccionar la región";
                args.IsValid = false;
            }
        }
    }
}