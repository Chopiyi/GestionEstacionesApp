<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerEstaciones.aspx.cs" Inherits="GestionEstacionesWeb.VerEstaciones" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
   <div class="row justify-content-center mt-5 py-3">
        <div class="col-10 col-md-6 col-lg-4 mt-4">
            <asp:GridView ID="grid_estaciones" runat="server" AutoGenerateColumns="false" EmptyDataText="No se han registrado Estaciones"
                CssClass="table table-hover table-striped table-info table-responsive" OnRowCommand="grid_estaciones_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="idEstacion"/>
                    <asp:BoundField HeaderText="Capacidad Máxima" DataField="capacidadMax"/>
                    <asp:BoundField HeaderText="Horario" DataField="horario"/>
                    <asp:TemplateField HeaderText="Eliminar">
                           <ItemTemplate>
                               <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn btn-lg btn-danger" CommandName="eliminar"
                                   CommandArgument= <%# Eval("idEstacion") %>> </asp:Button>
                           </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
