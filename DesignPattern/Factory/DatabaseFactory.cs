namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType type)
        {
            if (Equals(type , DatabaseType.SqlServer))
            {
                return new SqlServerDatabase();
            }
            else
            {
                return new OracleDatabase();
            }
        }
    }
}
