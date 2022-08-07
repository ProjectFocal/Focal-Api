namespace Focal.Database
{

    public class DatabaseSettings: IDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string Databasename { get; set; }

    }
}