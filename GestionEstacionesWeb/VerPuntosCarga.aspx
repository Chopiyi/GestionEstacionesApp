<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerPuntosCarga.aspx.cs" Inherits="GestionEstacionesWeb.VerPuntosCarga" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row justify-content-center mt-5">
        <div class="col-6 col-md-4 col-lg-2 mt-5">
            <asp:DropDownList ID="ddl_filtro" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_filtro_SelectedIndexChanged">
                <asp:ListItem Value="nada" Selected="True" Text="Mostrar Todo"></asp:ListItem>
                <asp:ListItem Value="Eléctrico" Text="Eléctrico"></asp:ListItem>
                <asp:ListItem Value="Dual" Text="Dual"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row justify-content-center mt-5 py-3">
        <div class="col-10 col-md-6 col-lg-4 mt-4">
            <asp:GridView ID="grid_puntos" runat="server" AutoGenerateColumns="false" EmptyDataText="No se han registrado Puntos de Carga"
                CssClass="table table-hover table-striped table-info table-responsive" OnRowEditing="grid_puntos_RowEditing" OnRowCancelingEdit="grid_puntos_RowCancelingEdit"
                OnRowUpdating="grid_puntos_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <%# Eval("idPunto") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="id_punto" CssClass="form-control" runat="server" ReadOnly="true" Text=<%# Eval("idPunto") %>></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Capacidad Máxima">
                        <ItemTemplate>
                            <%# Eval("capacidadMax") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="capacidad_punto" CssClass="form-control" runat="server" type="number" min="0" Text=<%# Eval("capacidadMax") %>></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debes ingresar la capacidad máxima"
                                ControlToValidate="capacidad_punto"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de Vencimiento">
                        <ItemTemplate>
                            <%# Eval("vencimiento") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="fecha_vencimiento" CssClass="form-control" runat="server" type="date"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debes ingresar la fecha"
                                ControlToValidate="fecha_vencimiento"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tipo">
                        <ItemTemplate>
                            <%# Eval("tipo") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="tipo_punto" runat="server" CssClass="form-select">
                                <asp:ListItem Value="nada" Selected="True" Text="Selecciona una opción"></asp:ListItem>
                                <asp:ListItem Value="Eléctrico" Text="Eléctrico"></asp:ListItem>
                                <asp:ListItem Value="Dual" Text="Dual"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Selecciona una opción por favor"
                                ControlToValidate="tipo_punto"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Actualizar">
                        <ItemTemplate>
                            <asp:Button ID="btn_edit" runat="server" Text="Editar" CssClass="btn btn-danger" CommandName="Edit"
                                CommandArgument='<%# Eval("idPunto") %>' />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btn_update" runat="server" Text="Actualizar" CssClass="btn btn-danger" CommandName="Update" CommandArgument='<%# Eval("idPunto") %>'/>
                            <asp:Button ID="btn_cancel" runat="server" Text="Cancelar" CssClass="btn btn-danger" CommandName="Cancel" CausesValidation="false"/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
