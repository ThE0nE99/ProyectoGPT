using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGObservacion
/// </summary>
public class ADGObservacion
{
    #region Metodos publicos
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GObservacion_I");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoObservacion", DbType.Int32, eGObservacion.CodigoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGObservacion.CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, eGObservacion.CodigoSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuarioObservacion", DbType.StringFixedLength, eGObservacion.CodigoUsuarioObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "ComentarioObservacion", DbType.String, eGObservacion.ComentarioObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "TipoObservacion", DbType.String, eGObservacion.TipoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoObservacion", DbType.StringFixedLength, eGObservacion.EstadoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOGObservacion Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGObservacion dtoGObservacion = new DTOGObservacion();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GObservacion_O_CodigoProyecto");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.String, CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dtoGObservacion, "GObservacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGObservacion;
    }
    public DTOGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        DTOGObservacion dtoGObservacion = new DTOGObservacion();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GObservacion_O_CodigoObservacion");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoObservacion", DbType.String, CodigoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dtoGObservacion, "GObservacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGObservacion;
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GObservacion_A");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoObservacion", DbType.Int32, eGObservacion.CodigoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGObservacion.CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, eGObservacion.CodigoSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuarioObservacion", DbType.StringFixedLength, eGObservacion.CodigoUsuarioObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "ComentarioObservacion", DbType.String, eGObservacion.ComentarioObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "TipoObservacion", DbType.String, eGObservacion.TipoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoObservacion", DbType.StringFixedLength, eGObservacion.EstadoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.ExecuteNonQuery(dbCommand);
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
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GObservacion_A_EstadoObservacion");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoObservacion", DbType.Int32, CodigoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoObservacion", DbType.StringFixedLength, EstadoObservacion);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public Object Obtener_GObsevacion_O_UltimoCodigoObservacion()
    {
        Object res = null;
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GObservacion_O_UltimoCodigoObservacion");
            res = BDSWADNETGPT.ExecuteScalar(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return res;
    }
    #endregion    
}