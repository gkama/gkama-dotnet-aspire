namespace FinancialHelper.ServiceDefaults
{
    public static class Constants
    {
        public static class Database
        {
            public static string DatabaseName = "financial_helper";
            public static string CreateDatabaseScript = $$"""
            -- Create the database
            CREATE DATABASE {{DatabaseName}};
            """;
        }
    }
}
