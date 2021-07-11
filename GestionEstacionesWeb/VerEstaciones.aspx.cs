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
    public partial class VerEstaciones : System.Web.UI.Page
    {
        private IEstacionesDAL dal = EstacionesDALFactory.CreateDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(dal.ReadAll());
            }
        }

        

        protected void CargarTabla(List<Estacion> estaciones)
        {
            grid_estaciones.DataSource = estaciones;
            grid_estaciones.DataBind();
        }

        protected void grid_estaciones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int idEliminado = Convert.ToInt32(e.CommandArgument.ToString());
                dal.Remove(idEliminado);
                CargarTabla(dal.ReadAll());
            }
        }
    }
}