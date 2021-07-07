<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarPuntoCarga.aspx.cs" Inherits="GestionEstacionesWeb.RegistrarPuntoCarga" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row my-5 justify-content-center">
        <div class="col-10 col-md-6 col-lg-4">
            <div class="card">
                <div class="card-header text-center bg-dark text-white">
                <h4>Registrar Punto de Carga</h4>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label for="capacidad_punto" class="form-label">Capcaidad Máxima</label>
                        <asp:TextBox ID="capacidad_punto" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Debes Ingresar la capacidad máxima" ControlToValidate="capacidad_punto" CssClass="text-danger">
                        </asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label for="fecha_vencimiento" class="form-label">Fecha de vencimiento</label>
                        <asp:TextBox ID="fecha_vencimiento" CssClass="form-control" runat="server" type="date"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="tipo_punto" class="form-label">Tipo</label>
                        <asp:DropDownList ID="tipo_punto" runat="server" CssClass="form-select">
                            <asp:ListItem Value="0" Selected="True" Text="Selecciona una opción"></asp:ListItem>
                            <asp:ListItem Value="1" Text="Eléctrico"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Dual"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="card-footer bg-dark">
                    <div class="my-1 text-center">
                        <asp:Button ID="button_registrar" runat="server" Text="Registrar" CssClass="btn btn-light btn-lg" OnClick="button_registrar_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
