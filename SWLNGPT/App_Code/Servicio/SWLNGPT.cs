using SWADNETGPT;
using System;
using System.Collections.Generic;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWLNGPT : ISWLNGPT
{
    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(int CodigoUsuarioRol, string CodigoRol, string CodigoUsuario)
    {
        CGPT cGPT = new CGPT();
        cGPT.Insertar_GUsuarioRol_I(CodigoUsuarioRol, CodigoRol, CodigoUsuario);
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        CGPT cGPT = new CGPT();
        List<EGUsuarioRol> lstEgUsuarioRol = new List<EGUsuarioRol>();
        lstEgUsuarioRol = cGPT.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol);
        return lstEgUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        CGPT cGPT = new CGPT();
        List<EGUsuarioRol> lstEgUsuarioRol = new List<EGUsuarioRol>();
        lstEgUsuarioRol = cGPT.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario);
        return lstEgUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario, CodigoRol);
    }
    public void Actualizar_GUsuarioRol_A(string CodigoUsuario, string CodigoRol, int CodigoUsuarioRol)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_GUsuarioRol_A(CodigoUsuario, CodigoRol, CodigoUsuarioRol);
    }
    #endregion

    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    {
        CGPT cGPT = new CGPT();
        cGPT.Insertar_GUsuarioProyecto_I(CodigoUsuarioProyecto, CodigoProyecto, CodigoUsuario, CodigoRol, EstadoUsuarioProyecto);
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        CGPT cGPT = new CGPT();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto> ();
        lstEGUsuarioProyecto = cGPT.Obtener_GUsuarioProyecto_O_CodigoProyecto (CodigoProyecto);
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        CGPT cGPT = new CGPT();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        lstEGUsuarioProyecto = cGPT.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);
        return lstEGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_GUsuarioProyecto_A(CodigoUsuarioProyecto, CodigoProyecto, CodigoUsuario, CodigoRol,EstadoUsuarioProyecto);
    }
    #endregion

    #region GProyecto
    public void Insertar_GProyecto_I(string CodigoProyecto, char ModalidadProyecto, string TituloProyecto, string ObjetivoGeneralProyecto, string EnlaceDocumentoProyecto, char EstadoProyecto)
    {
        CGPT cGPT = new CGPT();
        cGPT.Insertar_GProyecto_I(CodigoProyecto,  ModalidadProyecto,  TituloProyecto,  ObjetivoGeneralProyecto,  EnlaceDocumentoProyecto,  EstadoProyecto);
    }
    public List<EGProyecto> Obtener_GProyecto_O_Todo()
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GProyecto_O_Todo();
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        CGPT cGPT = new CGPT();
        EGProyecto eGProyecto = new EGProyecto();
        eGProyecto = cGPT.Obtener_GProyecto_O_CodigoProyecto(CodigoProyecto);
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(string CodigoProyecto, char ModalidadProyecto, string TituloProyecto, string ObjetivoGeneralProyecto, string EnlaceDocumentoProyecto)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_GProyecto_A(CodigoProyecto, ModalidadProyecto, TituloProyecto, ObjetivoGeneralProyecto, EnlaceDocumentoProyecto);
    }
    #endregion

    #region GEtapa
    public void Insertar_GEtapa_I(int CodigoEtapa, byte NumeroEtapa, DateTime FechaInicioEtapa, DateTime FechaDefinidaEtapa, DateTime FechaFinEtapa, string CodigoProyecto, char EstadoEtapa)
    {
        CGPT cGPT = new CGPT();
        cGPT.Insertar_GEtapa_I(CodigoEtapa,  NumeroEtapa,  FechaInicioEtapa,  FechaDefinidaEtapa,  FechaFinEtapa,  CodigoProyecto,  EstadoEtapa);
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GEtapa_O_SiguienteCodigoEtapa();
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        CGPT cGPT = new CGPT();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGPT.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto);
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa)
    {
        CGPT cGPT = new CGPT();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGPT.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto, NumeroSubEtapa);
        return eGEtapa;
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);
    }
    #endregion

    #region GSubEtapa
    public void Insertar_GSubEtapa_I(int CodigoSubEtapa, byte NumeroSubEtapa, DateTime FechaInicioSubEtapa, DateTime FechaDefinidaSubEtapa, DateTime FechaFinSubEtapa, string CodigoUsuarioFirma, int CodigoEtapa, char EstadoSubEtapa)
    {
        CGPT cGPT = new CGPT();
        cGPT.Insertar_GSubEtapa_I(CodigoSubEtapa,  NumeroSubEtapa,  FechaInicioSubEtapa,  FechaDefinidaSubEtapa,  FechaFinSubEtapa,  CodigoUsuarioFirma,  CodigoEtapa,  EstadoSubEtapa);
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        CGPT cGPT = new CGPT();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGPT.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(CodigoEtapa); 
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        CGPT cGPT = new CGPT();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGPT.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
    }
    #endregion

    #region GObservacion
    public void Insertar_GObservacion_I(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        CGPT cGPT = new CGPT();
        cGPT.Insertar_GObservacion_I(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);

    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        CGPT cGPT = new CGPT();
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        lstObservacion = cGPT.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto);
        return lstObservacion;

    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
    }
    public void Actualizar_GObservacion_A(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_GObservacion_A(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_GObservacion_A_EstadoObservacion(CodigoObservacion, EstadoObservacion);
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    }
    #endregion

    #region GUsuario
    public void Insertar_GUsuario_I(string CodigoUsuario, string sede)
    {
        CGPT cGPT = new CGPT();
        cGPT.Insertar_GUsuario_I(CodigoUsuario, sede);
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
    }
    public void Actualizar_GUsuario_A(string codigoUsuario, string sede)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_GUsuario_A(codigoUsuario, sede);
    }
    #endregion

    #region GRol
    public List<EGRol> Obtener_GRol_O_Todo()
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GRol_O_Todo();
    }
    public EGRol Obtener_GRol_O_CodigoRol(string CodigoRol)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_GRol_O_CodigoRol(CodigoRol);
    }
    #endregion

    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
    }
    #endregion

    #region GProyectoCompleja
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string CodigoUsuario)
    {
        CGPT cGPT = new CGPT();
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        lstEGProyectos = cGPT.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(CodigoUsuario);
        return lstEGProyectos;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string CodigoUsuario)
    {
        CGPT cGPT = new CGPT();
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        lstEGProyectos = cGPT.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(CodigoUsuario);
        return lstEGProyectos;
    }
    #region Opciones
    public bool Verificar_GProyecto_CorrespondeRevision(string CodigoRol, byte NumeroEtapa, byte NumeroSubEtapa)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Verificar_GProyecto_CorrespondeRevision(CodigoRol, NumeroEtapa, NumeroSubEtapa);
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string CodigoProyecto)
    {
        CGPT cGPT = new CGPT();
        cGPT.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(CodigoProyecto);
    }
    public void Insertar_ProyectoCompleto(string CodigoProyecto, string CodigoUsuario, string CodigoDirector, int DiasEtapa, int DiasSubEtapa)
    {
        CGPT cGPT = new CGPT();
        cGPT.Insertar_ProyectoCompleto(CodigoProyecto, CodigoUsuario, CodigoDirector, DiasEtapa, DiasSubEtapa);
    }
    #endregion
    #endregion

    #region EProgresoEtapaSubEtapa
    public List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string CodigoProyecto)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_EProgresoEtapaSubEtapa_O(CodigoProyecto);
    }
    #endregion

    #region EUsuarioCompleto
    public EUsuarioCompleto Obtener_EUsuarioCompleto_O(string CodigoUsuario, string CodigoProyecto)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_EUsuarioCompleto_O_CodigoUsuario(CodigoUsuario, CodigoProyecto);
    }
    #endregion

    #region EProyectoTiempoEntrega
    public List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string CodigoUsuario)
    {
        CGPT cGPT = new CGPT();
        return cGPT.Obtener_EProyectoTiempoEntrega_O(CodigoUsuario);
    }
    #endregion
}
