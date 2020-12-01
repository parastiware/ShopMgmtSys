namespace ShopManagementSystem.Models
{
    public class ShopManagementSystemDatabaseSettings : IShopManagementSystemDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IShopManagementSystemDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}