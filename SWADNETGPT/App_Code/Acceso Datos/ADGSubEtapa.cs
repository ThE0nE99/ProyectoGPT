using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGSubEtapa
/// </summary>
public class ADGSubEtapa
{
    #region Metodos públicos
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GSubEtapa_I");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, eGSubEtapa.CodigoSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, eGSubEtapa.CodigoEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoUsuarioFirma", DbType.StringFixedLength, SDatosPA.FirmaPorDefecto);
            BDSWADNETGPT.AddInParameter(dbCommand, "NumeroSubEtapa", DbType.Byte, eGSubEtapa.NumeroSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaInicioSubEtapa", DbType.DateTime, eGSubEtapa.FechaInicioSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaDefinidaSubEtapa", DbType.DateTime, eGSubEtapa.FechaDefinidaSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaFinSubEtapa", DbType.DateTime, eGSubEtapa.FechaFinSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoSubEtapa", DbType.StringFixedLength, eGSubEtapa.EstadoSubEtapa);
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
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGSubEtapa;
    }
    public Object Obtener_GSubEtapa_O_UltimoCodigoSubEtapa()
    {
        Object res = null;
        try
        {
            Database database = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = database.GetStoredProcCommand("GSubEtapa_O_UltimoCodigoSubEtapa");
            res =database.ExecuteScalar(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return res;
    }
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoSubEtapa", DbType.StringFixedLength, SDatosPA.Activo);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGSubEtapa;
    }
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa_NumeroSubEtapa");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "NumeroSubEtapa", DbType.Byte, NumeroSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGSubEtapa;
    }
    public DTOGSubEtapa Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database BDSWADNETGPT = SBaseDatos.BDSWADNETGPT;
            DbCommand dbCommand = BDSWADNETGPT.GetStoredProcCommand("GSubEtapa_A_EstadoSubEtapa");
            BDSWADNETGPT.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, CodigoSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "EstadoSubEtapa", DbType.StringFixedLength, EstadoSubEtapa);
            BDSWADNETGPT.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGPT.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGSubEtapa;
    }
    #endregion
}