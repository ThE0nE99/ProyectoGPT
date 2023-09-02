﻿using SWLNGPT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CUsuarioCompleto
/// </summary>
public class CUsuarioCompleto
{
    #region Atributos

    private LNServicio lNServicio;

    #endregion

    #region Propiedades

    public string NombreClase
    {
        get { return GetType().Name; }
    }

    #endregion

    #region Constructor

    public CUsuarioCompleto()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region EUsuarioCompleto
    public EUsuarioCompleto Obtener_EUsuarioCompleto_O(string CodigoUsuario, string CodigoProyecto)
    {
        EUsuarioCompleto eEUsuarioCompleto = new EUsuarioCompleto();
        try
        {
            eEUsuarioCompleto = lNServicio.Obtener_EUsuarioCompleto_O(CodigoUsuario, CodigoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
        return eEUsuarioCompleto;
    }
    #endregion

    #endregion
}