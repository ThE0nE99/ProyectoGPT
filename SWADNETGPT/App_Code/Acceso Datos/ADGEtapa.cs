using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADGEtapa
/// </summary>
public class ADGEtapa
{
    #region Metodos públicos
    public void Insertar_GEtapa_I(EGEtapa etapa)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GEtapa_I");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, etapa.CodigoEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "NumeroEtapa", DbType.Byte, etapa.NumeroEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaInicioEtapa", DbType.DateTime, etapa.FechaInicioEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaDefinidaEtapa", DbType.DateTime, etapa.FechaDefinidaEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaFinEtapa", DbType.DateTime, etapa.FechaFinEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, etapa.CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoEtapa", DbType.StringFixedLength, etapa.EstadoEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public Object Obtener_GEtapa_O_UltimoCodigoEtapa()
    {
        Object res = null;
        try
        {
            Database database = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = database.GetStoredProcCommand("GEtapa_O_UltimoCodigoEtapa");
            res = database.ExecuteScalar(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return res;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GEtapa_O_CodigoProyecto");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.String, CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GEtapa_O_CodigoProyecto_EstadoEtapaActivo");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoEtapa", DbType.StringFixedLength, SDatosPA.Activo);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GEtapa_O_CodigoProyecto_NumeroEtapa");
            BDSWADNETGPT.AddInParameter(dbCommand, "NumeroEtapa", DbType.Byte, NumeroEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GEtapa_A_EstadoEtapa");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoEtapa", DbType.StringFixedLength, EstadoEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }    
    #endregion
}