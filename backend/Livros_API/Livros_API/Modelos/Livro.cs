using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Livros_API.Modelos
{
    public class Livro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Nome")]
        public string LivroNome { get; set; }

        public decimal Preco { get; set; }

        public string Categoria { get; set; }

        public string Autor { get; set; }
    }
}
