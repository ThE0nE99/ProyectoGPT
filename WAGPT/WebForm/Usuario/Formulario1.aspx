<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Formulario1.aspx.cs" Inherits="WebForm_Usuario_Formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario</title>
    <link rel="stylesheet" type="text/css" href="../../Estilos/Formulario1.css"/>
    
</head>
<body>
    <div class="contenedor">
        <h1>Formulario 1</h1>
        <form action="#" method="post">
            <div class="busquedaEst">
                <label class="lblEst" for="nombre">Estudiante:</label>
                <input class="txtBusqueda" type="text" id="Buscar" name="Buscar"/>
            </div >
            <div class="ListaTexto">
                <span> 1. MODALIDAD DE TITULACIÓN POR:</span>
            </div>
            <div class="radio">
               <label>
                    <input class="radioBoton" type="radio" name="opcion" value="TESIS" checked="checked"/> TESIS
               </label>
               <label>
                   <input class="radioBoton" type="radio" name="opcion" value="PROYECTO DE GRADO"/> PROYECTO DE GRADO
               </label>
               <label>
                    <input class="radioBoton" type="radio" name="opcion" value="TRABAJO DIRIGIDO"/> TRABAJO DIRIGIDO
                </label>
            </div>
            <div class="ListaTexto">
                <span> 2. DATOS DEL TRABAJO:</span>
            </div>
            <div class="Datos">
                <input class="txtDatos" type="text" id="" name=""  placeholder="POSIBLE TITULO"/>
            </div>
            <div class="Datos">
                <input class="txtDatos" type="text" id="" name=""  placeholder="OBJETIVO GENERAL"/>
            </div>
            <div class="Datos">
                <input class="txtDatos" type="text" id="" name=""  placeholder="OBJETIVOS ESPECIFICOS"/>
            </div>
            <div class="Datos">
                <input class="txtDatos" type="text" id="" name=""  placeholder="ALCANCE"/>
            </div>
            <div class="ListaTexto">
                <span> 3. DATOS DE ASESORAMIENTO:</span>
            </div>
            <div class="busquedaTutor">
                <label class="lblTutor" for="nombre">Tutor:</label>
                <input class="txtBusquedaTutor" type="text" id="Buscr" name="Buscar"  />
            </div >
             <div class="SeccionWord">
                  <div class="TextoCargar">
                        <span> 4. Cargue documento WORD de ser necesario o solicitado:</span>
                  </div>
                  <div class="CargarWord" >
                    <input  type="file" id="archivo-input" accept=".docx"/>
                    
                  </div>
            </div>
            <div class="SeccionSiguiente">
               <button class="btnSiguiente">Siguiente</button>
            </div>
        </form>
    </div>
</body>
    <script src="../../js/Formulario.js" type="text/javascript"></script>
</html>
