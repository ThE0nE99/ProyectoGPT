using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGProyecto
/// </summary>
public class ADGProyecto
{
    #region Métodos públicos
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GProyecto_I");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGProyecto.CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "ModalidadProyecto", DbType.StringFixedLength, eGProyecto.ModalidadProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "TituloProyecto", DbType.String, eGProyecto.TituloProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "ObjetivoGeneralProyecto", DbType.String, eGProyecto.ObjetivoGeneralProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "EnlaceDocumentoProyecto", DbType.String, eGProyecto.EnlaceDocumentoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoProyecto", DbType.StringFixedLength, SDatosPA.Activo);
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
    public DTOGProyecto Obtener_GProyecto_O_Todo()
    {
        DTOGProyecto dtoGProyecto = new DTOGProyecto();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GProyecto_O_Todo");
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dtoGProyecto, "GProyecto");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoGProyecto;
    }
    public DTOGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGProyecto dTOGProyecto = new DTOGProyecto();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GProyecto_O_CodigoProyecto");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGProyecto, "GProyecto");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GProyecto_A");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGProyecto.CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "ModalidadProyecto", DbType.StringFixedLength, eGProyecto.ModalidadProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "TituloProyecto", DbType.String, eGProyecto.TituloProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "ObjetivoGeneralProyecto", DbType.String, eGProyecto.ObjetivoGeneralProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "EnlaceDocumentoProyecto", DbType.String, eGProyecto.EnlaceDocumentoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoProyecto", DbType.StringFixedLength, eGProyecto.EstadoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion    
}