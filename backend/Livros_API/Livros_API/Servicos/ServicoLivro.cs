using Livros_API.Modelos;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Livros_API.Servicos
{
    public class ServicoLivro
    {
        private readonly IMongoCollection<Livro> _livros;

        public ServicoLivro(ILivrosDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _livros = database.GetCollection<Livro>(settings.LivrosCollectionName);
        }

        public List<Livro> Get() =>
            _livros.Find(livro => true).ToList();

        public Livro Get(string id) =>
            _livros.Find<Livro>(livro => livro.Id == id).FirstOrDefault();

        public Livro Create(Livro livro)
        {
            _livros.InsertOne(livro);
            return livro;
        }

        public void Update(string id, Livro livroEm) =>
            _livros.ReplaceOne(livro => livro.Id == id, livroEm);

        public void Remove(Livro livroEm) =>
            _livros.DeleteOne(livro => livro.Id == livroEm.Id);

        public void Remove(string id) =>
            _livros.DeleteOne(livro => livro.Id == id);
    }
}