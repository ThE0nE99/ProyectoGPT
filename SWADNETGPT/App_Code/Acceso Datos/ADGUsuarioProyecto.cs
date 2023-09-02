using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGUsuarioProyecto
/// </summary>
public class ADGUsuarioProyecto
{
    #region Métodos públicos
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioProyecto_I");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuarioProyecto", DbType.Int32, eGUsuarioProyecto.CodigoUsuarioProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioProyecto.CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGUsuarioProyecto.CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioProyecto.CodigoRol);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoUsuarioProyecto", DbType.StringFixedLength, eGUsuarioProyecto.EstadoUsuarioProyecto);
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
    public Object Obtener_GUsuarioProyecto_O_UltimoCodigoUsuarioProyecto()
    {
        Object res = null;
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioProyecto_O_UltimoCodigoUsuarioProyecto");
            res = BDSWADNETGPT.ExecuteScalar(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return res;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGUsuarioProyecto DTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioProyecto_O_CodigoProyecto");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, DTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return DTOGUsuarioProyecto;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        DTOGUsuarioProyecto DTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioProyecto_O_CodigoUsuario");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, DTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return DTOGUsuarioProyecto;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto)
    {
        DTOGUsuarioProyecto dTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.String, CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.String, CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGUsuarioProyecto)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioProyecto_A");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuarioProyecto", DbType.Int32, eGUsuarioProyecto.CodigoUsuarioProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioProyecto.CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGUsuarioProyecto.CodigoProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioProyecto.CodigoRol);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoUsuarioProyecto", DbType.StringFixedLength, eGUsuarioProyecto.EstadoUsuarioProyecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
}