<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PInformacionAvance.aspx.cs" Inherits="WebForm_InformacionAvance_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="../../Estilos/Cs.css"  rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
  <div class="contenedor">
    <div class="ContenedorPorcentaje">
        <div>
            <label> Porcentaje de total del avance general</label>
        </div>
              
        <div class="Contenedor1">
            <div class="barra-progreso">
                <div class="barra" id="barra-progreso"></div>
            </div>
            <div id="porcentaje">0%</div>
            <button onclick="decrementoProgreso()">-</button>
            <button onclick="incrementoProgreso()">+</button>

        </div>
    </div>

    <div class="Contenedor1">
         <div class="Contenedor-Botones">
            <button class="Botones"  id="Tema" onclick="MostrarDiv1()">  ·PUBLICA </button>
            <button class="Botones"  id="PERFIL" onclick="MostrarDiv2()">  PERFIL </button>
            <button class="Botones"  id="PRIVADA" onclick="MostrarDiv3()">  PRIVADA </button>
            <button class="Botones"  id="PUBLICA" onclick="MostrarDiv4()">  PUBLICA </button>
          
        </div>
        <div class="div-detras" id="BarraAnimacion"> </div>
        <div class="Contenedor-SubEtapas OcultarDiv " runat="server" id="Div1" >
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
        </div>
        <div class="Contenedor-SubEtapas OcultarDiv" runat="server" id="Div2" >
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
        </div>
        <div class="Contenedor-SubEtapas OcultarDiv" runat="server" id="Div3" >
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
        </div>
        <div class="Contenedor-SubEtapas OcultarDiv" runat="server" id="Div4" >
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
            <asp:Label class="Estilo-SubEtapas" runat="server"> ·Sub Etapa</asp:Label>
        </div>
    </div>
  </div>
      
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
    <script src="../../Guiones/JsInformacionAvance.js"></script>
</asp:Content>
