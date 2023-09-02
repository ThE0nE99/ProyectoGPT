using SWADNETGPT;
using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Descripción breve de ASNETGPT
/// </summary>
public class ASNETGPT
{
    #region Atributos
    private SWADNETGPTClient swADNETGPT;
    #endregion

    #region Constructor
    public ASNETGPT()
    {
        swADNETGPT = new SWADNETGPTClient();
    }
    #endregion

    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            swADNETGPT.Insertar_GUsuarioRol_I(eGUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        int res = 0;
        try
        {
            res = swADNETGPT.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = swADNETGPT.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol).ToList();
            return lstEGUsuarioRol;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = swADNETGPT.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario).ToList();
            return lstEGUsuarioRol;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            eGUsuarioRol = swADNETGPT.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario,CodigoRol);
            return eGUsuarioRol;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            swADNETGPT.Actualizar_GUsuarioRol_A(eGUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        try
        {
            swADNETGPT.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        int res = 0;
        try
        {
            res = swADNETGPT.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = swADNETGPT.Obtener_GUsuarioProyecto_O_CodigoProyecto(CodigoProyecto).ToList();
            return lstEGUsuarioProyecto;
        }
        catch (Exception)
        {

            throw;
        }
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = swADNETGPT.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario).ToList();
            return lstEGUsuarioProyecto;
        }
        catch (Exception)
        {

            throw;
        }
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto)
    {
        try
        {
            return swADNETGPT.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(CodigoUsuario, CodigoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGProyectoUsuario)
    {
        try
        {
            swADNETGPT.Actualizar_GUsuarioProyecto_A(eGProyectoUsuario);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion

    #region GProyecto
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        try
        {
            swADNETGPT.Insertar_GProyecto_I(eGProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O_Todo()
    {
        List <EGProyecto> lstEGProyecto = new List<EGProyecto>();
        try
        {
            lstEGProyecto = swADNETGPT.Obtener_GProyecto_O_Todo().ToList();
            return lstEGProyecto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto = swADNETGPT.Obtener_GProyecto_O_CodigoProyecto(CodigoProyecto);
            return eGProyecto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        try
        {
            swADNETGPT.Actualizar_GProyecto_A(eGProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GEtapa
    public void Insertar_GEtapa_I(EGEtapa eGEtapa)
    {
        try
        {
            swADNETGPT.Insertar_GEtapa_I(eGEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto)
    {
        try
        {
            return swADNETGPT.Obtener_GEtapa_O_CodigoProyecto(CodigoProyecto).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        int res = 0;
        try
        {
            res = swADNETGPT.Obtener_GEtapa_O_SiguienteCodigoEtapa();
            return res;
        }
        catch (Exception)
        {
            throw;
        }

    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = swADNETGPT.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto);
            return eGEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = swADNETGPT.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto, NumeroSubEtapa);
            return eGEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        try
        {
            swADNETGPT.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GSubEtapa
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        try
        {
            swADNETGPT.Insertar_GSubEtapa_I(eGSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa)
    {
        try
        {
            return swADNETGPT.Obtener_GSubEtapa_O_CodigoEtapa(CodigoEtapa).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        int res = 0;
        try
        {
            res = swADNETGPT.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = swADNETGPT.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(CodigoEtapa);
            return eGSubEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = swADNETGPT.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
            return eGSubEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        try
        {
            swADNETGPT.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GObservacion
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        try
        {
            swADNETGPT.Insertar_GObservacion_I(eGObservacion);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            lstObservacion = swADNETGPT.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto).ToList();
            return lstObservacion;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            eGObservacion = swADNETGPT.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
            return eGObservacion;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        try
        {
            swADNETGPT.Actualizar_GObservacion_A(eGObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion)
    {
        try
        {
            swADNETGPT.Actualizar_GObservacion_A_EstadoObservacion(CodigoObservacion, EstadoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        int res = 0;
        try
        {
            res = swADNETGPT.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GUsuario
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        try
        {
            swADNETGPT.Insertar_GUsuario_I(eGUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        try
        {
            return swADNETGPT.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        try
        {
            swADNETGPT.Actualizar_GUsuario_A(eGUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GRol
    public List<EGRol> Obtener_GRol_O_Todo()
    {
        try
        {
            return swADNETGPT.Obtener_GRol_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    
    public EGRol Obtener_GRol_O_CodigoRol(string CodigoRol) 
    { 
        try
        {
            return swADNETGPT.Obtener_GRol_O_CodigoRol(CodigoRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario)
    {
        try
        {
            return swADNETGPT.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}