namespace Livros_API.Modelos
{
    public class LivrosDatabaseSettings : ILivrosDatabaseSettings
    {
        public string LivrosCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ILivrosDatabaseSettings
    {
        string LivrosCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}