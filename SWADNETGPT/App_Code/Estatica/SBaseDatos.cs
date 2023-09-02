using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de SBaseDatos
/// </summary>
public static class SBaseDatos
{

    public static Database BDSWADNETGPT = DatabaseFactory.CreateDatabase("BDGestionProyectosTitulacionCadenaConexion");

    public static Database DBSWADNETUSR = DatabaseFactory.CreateDatabase("BDNetvalleCadenaConexion");

}