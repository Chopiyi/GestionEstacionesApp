<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarEstacion.aspx.cs" Inherits="GestionEstacionesWeb.RegistrarEstacion" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row my-5 justify-content-center">
        <div class="col-10 col-md-6 col-lg-4">
            <div class="card">
                <div class="card-header text-center bg-dark text-white">
                <h4>Registro de Estación</h4>
            </div>
            <div class="card-body">
                <div class="mb-3">
                    <label for="capacidad_estacion" class="form-label">Capcaidad Máxima</label>
                    <asp:TextBox ID="capacidad_estacion" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Debes Ingresar la capacidad máxima" ControlToValidate="capacidad_estacion" CssClass="text-danger">
                    </asp:RequiredFieldValidator>
                </div>
                <div class="mb-3">
                    <label for="hora_comienzo" class="form-label">Horar de comienzo</label>
                    <asp:TextBox ID="hora_comienzo" CssClass="form-control" runat="server" type="time"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="hora_termino" class="form-label">Horar de Termino</label>
                    <asp:TextBox ID="hora_termino" CssClass="form-control" runat="server" type="time"></asp:TextBox>
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
