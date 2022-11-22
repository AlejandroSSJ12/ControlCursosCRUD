using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMongoDB.Models
{
   public class CursoModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }
        [BsonElement]
        public String NombreCurso { get; set; }
        [BsonElement]
        public String NombreImparte { get; set; }
        [BsonElement]
        public String NumLecciones { get; set; }
        [BsonElement]
        public String Descripcion { get; set; }
    }
}
