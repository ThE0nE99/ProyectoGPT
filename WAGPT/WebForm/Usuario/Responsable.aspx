﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Responsable.aspx.cs" Inherits="WebForm_Usuario_Responsable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link rel="stylesheet" type="text/css" href="../../Estilos/Responsable.css"/>
</head>
<body>
    <div class="contenedor">
        <div class="Menu" >
            <div class="buscador">
                <input class="txtBusqueda" type="text" id="Buscr" name="Buscar"/>
             </div>
            <div class="">
                <input class="txtBusqueda" type="text" id="Bur" name="Buscar"/>
                
            </div>
            <div class="">
                <input class="txtBusqueda" type="text" id="Busr" name="Buscar"/>
                
            </div>
        </div>
        <div class="contenedorTabla">
            <table class="EstiloTable">
                <thead >
                  <tr>
                    <th>NOMBRE DEL RESPONSABLE</th>
                    <th>TIPO</th>
                    <th>ESTADO</th>
                    <th>FECHA</th>
                    <th></th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td>Cristian Bueno</td>
                    <td>tipo</td>
                    <td>estado</td>
                    <td>04/09/23</td>
                    <td class="btnLinea"><button class="Btntabla" >Editar</button><button class="Btntabla" >Eliminar</button></td>
                  </tr>
                  <tr>
                    <td>Cristian Encinas</td>
                    <td>tipo</td>
                    <td>estado</td>
                    <td>04/09/23</td>
                    <td class="btnLinea"><button class="Btntabla" >Editar</button><button class="Btntabla" >Eliminar</button></td>
                  </tr>
                </tbody>
              </table>

        </div>
    </div>
</body>
</html>