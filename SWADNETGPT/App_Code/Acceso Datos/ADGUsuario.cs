using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción breve de ADGUsuario
/// </summary>
public class ADGUsuario
{
    #region Metodos publicos
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuario_I");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuario.CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "SedeUsuario", DbType.StringFixedLength, eGUsuario.SedeUsuario);
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
    public DTOGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        DTOGUsuario dtoGUsuario = new DTOGUsuario();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuario_O_CodigoUsuario");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dtoGUsuario, "GUsuario");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoGUsuario;
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GUsuario_A");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuario", DbType.String, eGUsuario.CodigoUsuario);
            BDSWADNETGPT.AddInParameter(dbCommand, "SedeUsuario", DbType.String, eGUsuario.SedeUsuario);
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