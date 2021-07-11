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
    public partial class VerPuntosCarga : System.Web.UI.Page
    {
        private IPuntosCargaDAL dal = PuntosCargaDALFactory.CreateDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(dal);
            }
        }

        protected void CargarTabla(IPuntosCargaDAL dal)
        {
            string tipo_selected = ddl_filtro.SelectedValue;
            if (tipo_selected == "nada")
            {
                grid_puntos.DataSource = dal.ReadAll();
            }
            else
            {
                grid_puntos.DataSource = dal.ReadByTipo(tipo_selected);
            }
            grid_puntos.DataBind();
        }

        protected void ddl_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTabla(dal);
        }

        protected void grid_puntos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grid_puntos.EditIndex = e.NewEditIndex;
            CargarTabla(dal);
        }

        protected void grid_puntos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grid_puntos.EditIndex = -1;
            CargarTabla(dal);
        }

        protected void grid_puntos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox textCap = grid_puntos.Rows[e.RowIndex].FindControl("capacidad_punto") as TextBox;
            TextBox textDate = grid_puntos.Rows[e.RowIndex].FindControl("fecha_vencimiento") as TextBox;
            DropDownList ddlTipo = grid_puntos.Rows[e.RowIndex].FindControl("tipo_punto") as DropDownList;
            TextBox idField = grid_puntos.Rows[e.RowIndex].FindControl("id_punto") as TextBox;
            int capTxt = Convert.ToInt32(textCap.Text.Trim());
            string fechaTxt = Convert.ToDateTime(textDate.Text.Trim()).ToString("dd-MM-yyyy");
            string tipoTxt = ddlTipo.SelectedValue;
            int id = Convert.ToInt32(idField.Text.Trim());
            PuntoCarga punto = new PuntoCarga();
            punto.IdPunto = id;
            punto.CapacidadMax = capTxt;
            punto.Vencimiento = DateTime.ParseExact(fechaTxt, "dd-MM-yyyy", null);
            switch (tipoTxt)
            {
                case "Dual":
                    punto.Tipo = TipoPunto.Dual;
                    break;
                case "Eléctrico":
                    punto.Tipo = TipoPunto.Eléctrico;
                    break;
            }
            dal.Update(punto);
            grid_puntos.EditIndex = -1;
            CargarTabla(dal);
        }
    }
}