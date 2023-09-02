using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGUsuarioRol
/// </summary>
public class ADGUsuarioRol
{
    #region Metodos publicos
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioRol_I");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuarioRol", DbType.Int32, eGUsuarioRol.CodigoUsuarioRol);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioRol.CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioRol.CodigoRol);
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
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioRol_O_CodigoRol");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, CodigoRol);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGUsuarioRol;
    }
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioRol_O_CodigoUsuario");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioRol;
    }
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioRol_O_CodigoUsuario_CodigoRol");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, CodigoRol);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioRol;
    }
    public Object Obtener_GUsuarioRol_O_UltimoCodigoUsuarioRol()
    {
        Object res = null;
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioRol_O_UltimoCodigoUsuarioRol");
            res = BDSWADNETGPT.ExecuteScalar(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return res;
    }
    public DTOGUsuarioRol Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        DTOGUsuarioRol dtoGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuarioRol_A");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuarioRol", DbType.Int32, eGUsuarioRol.CodigoUsuarioRol);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioRol.CodigoRol);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioRol.CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.LoadDataSet(dbCommand, dtoGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGUsuarioRol;
    }
    #endregion
}