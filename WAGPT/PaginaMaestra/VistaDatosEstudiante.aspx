<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="VistaDatosEstudiante.aspx.cs" Inherits="WebForm_Estudiante_VistaDatosEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
  <link rel="stylesheet" href="../Estilos/Estudiante/SVistaDatosEstudiante.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="divInformacion">
        <table>
          <tr>

            <td rowspan="7" >
              <img src="../../Imagenes/Iconos/CambiarUsuario.png" class="iconoCambiarUsuario">
              <button>Cambiar foto</button>
            </td>        
            
            <td class="nombre">PERICO PEREZ PEREIRA</td>
        
          </tr> 
        
          <tr>

            <td class="carrera">ING. DE SISTEMAS INFORMATICOS</td>
        
          </tr>
        
          <tr>
        
            <td colspan="3">SEDE COCHABAMBA</td>     

          </tr>
        
          <tr>
        
            <td colspan="2">FACULTAD DE INFORMATICA Y ELECTRONICA</td>
        
          </tr>
          
          <tr>

            <td colspan="2">Departamento de Informatica</td>
        
          </tr>
        
          <tr>
        
            <td colspan="2">PPP2019880@est.univalle.edu</td>     

          </tr>
        
          <tr>
        
            <td colspan="2">(+591) 76589230</td>
        
          </tr>

          <tr>
        
            <td>ESTUDIANTE</td>
            <td class="centro">Gestión: 1-2023</td>
            <td> <button>Editar datos</button> </td> 
        
          </tr>
        </table>
        
      </div>
</asp:Content>

