<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AvanceEstudiante.aspx.cs" Inherits="WebForm_Estudiantes_AvanceEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="estilos/CssAvanceEstudiante.css"/>
</head>
<body>
   
    <div class="contenedor">
        <div class="div1">
            <div class="barra-progreso">
                <div class="barra" id="barra-progreso"></div>
                
                 <div id="porcentaje">0%</div>
            </div>
            <div class="controles">
                <button onclick="decrementoProgreso()">-</button>
                <button onclick="incrementoProgreso()">+</button>
            </div>
           
        </div>
        


    </div>
    <div class="contenedor">
        <div class="div2">
             
                 <ul class="etapa">
                     <li>
                          Etapa 1
                     </li>
                 </ul>
             
            <button class="boton">VER DETALLE</button>
             <div class="botones">
                <button>Botón 1</button>
                <button>Botón 2</button>
                <button>Botón 3</button>
                <button>Botón 4</button>
            </div>
        </div>
    </div>
   
    
 
  
    <script src="scripts/JsAvanceEstudiante.js"></script>
</body>
</html>
