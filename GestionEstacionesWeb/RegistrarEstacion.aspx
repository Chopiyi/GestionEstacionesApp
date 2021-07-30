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
                    <asp:TextBox ID="capacidad_estacion" CssClass="form-control" runat="server" type="number" min="0"></asp:TextBox>
                    <asp:CustomValidator ID="capacidad_cv" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                        CssClass="text-danger" ControlToValidate="capacidad_estacion" OnServerValidate="capacidad_cv_ServerValidate"></asp:CustomValidator>
                </div>
                <div class="mb-3">
                    <label for="hora_comienzo" class="form-label">Horario de comienzo</label>
                    <asp:TextBox ID="hora_comienzo" CssClass="form-control" runat="server" type="time"></asp:TextBox>
                    <asp:CustomValidator ID="cv_comienzo" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                        CssClass="text-danger" ControlToValidate="hora_comienzo" OnServerValidate="cv_comienzo_ServerValidate"></asp:CustomValidator>
                </div>
                <div class="mb-3">
                    <label for="hora_termino" class="form-label">Horario de Termino</label>
                    <asp:TextBox ID="hora_termino" CssClass="form-control" runat="server" type="time"></asp:TextBox>
                    <asp:CustomValidator ID="cv_termino" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                        CssClass="text-danger" ControlToValidate="hora_termino" OnServerValidate="cv_termino_ServerValidate"></asp:CustomValidator>
                </div>
                <div class="mb-3 text-center">
                    <h4>Dirección</h4>
                </div>
                <div class="mb-3">
                    <label for="direccion_calle" class="form-label">Calle</label>
                    <asp:TextBox ID="direccion_calle" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:CustomValidator ID="cv_calle" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                        CssClass="text-danger" ControlToValidate="direccion_calle" OnServerValidate="cv_calle_ServerValidate"></asp:CustomValidator>
                </div>
                <div class="mb-3">
                    <label for="direccion_numero" class="form-label">Número</label>
                    <asp:TextBox ID="direccion_numero" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                    <asp:CustomValidator ID="cv_numero" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                        CssClass="text-danger" ControlToValidate="direccion_numero" OnServerValidate="cv_numero_ServerValidate"></asp:CustomValidator>
                </div>
                <div class="mb-3">
                    <label for="direccion_sector" class="form-label">Sector</label>
                    <asp:TextBox ID="direccion_sector" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:CustomValidator ID="cv_sector" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                        CssClass="text-danger" ControlToValidate="direccion_sector" OnServerValidate="cv_sector_ServerValidate"></asp:CustomValidator>
                </div>
                <div class="mb-3">
                    <label for="ddl_region" class="form-label">Región</label>
                    <asp:DropDownList ID="ddl_region" runat="server" CssClass="form-select">
                    </asp:DropDownList>
                    <asp:CustomValidator ID="cv_region" runat="server" ErrorMessage="CustomValidator"
                        CssClass="text-danger" ControlToValidate="ddl_region" OnServerValidate="cv_region_ServerValidate"></asp:CustomValidator>
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
