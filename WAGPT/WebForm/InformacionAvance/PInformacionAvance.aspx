<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PInformacionAvance.aspx.cs" Inherits="WebForm_InformacionAvance_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="../../Estilos/C.css"  rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

            <div class="ContenedorPorcentaje">

                  
                    <div class="Contenedor">
                                    <div>
                    <label> Porcentaje de total del avance general</label>
                </div>
                      <div class="barra-progreso">
                            <div class="barra" id="barra-progreso"></div>
                      </div>
                      <div id="porcentaje">0%</div>

                    </div>


            </div>

            <br/>
        <div class="Contenedor">
             <div class="ContenedorBotones">
                <asp:Button id="Tema" OnClick="Tema_Click" Text="·TEMA" runat="server" class="Botones"/> <br />
                <asp:Button id="Perfil" OnClick="Perfil_Click" Text="·PERFIL" runat="server" class="Botones"/> <br />
                <asp:Button id="Privada" OnClick="Privada_Click" Text="·PRIVADA" runat="server" class="Botones"/> <br />
                <asp:Button id="Publica" OnClick="Publica_Click" Text="·PUBLICA" runat="server" class="Botones"/> <br />
            </div>
            <div class="ContenedorBotones" runat="server" id="Div1" >
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            </div>
            <div class="ContenedorBotones" runat="server" id="Div2" >
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            </div>
            <div class="ContenedorBotones" runat="server" id="Div3" >
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            </div>
            <div class="ContenedorBotones" runat="server" id="Div4" >
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
                <asp:Label class="ContenedorSubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            </div>
        </div>
      
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
        <script  src="../../Guiones/JsInformacionAvance.js"></script>
</asp:Content>
