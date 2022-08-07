namespace Focal.Database
{

    public interface IDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string Databasename { get; set; }

    }
}