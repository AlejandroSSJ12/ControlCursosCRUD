using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMongoDB.Models
{
    public class AlumnoModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }
        [BsonElement]
        public String NombreAlumno { get; set; }
        [BsonElement]
        public String Apellido { get; set;}

        [BsonElement]
        public String NombreCurso { get; set; }
        [BsonElement]
        public String ProgresoCurso { get; set; }
        [BsonElement]
        public String FechaIncio { get; set; }
        [BsonElement]
        public String FechaFinal { get; set; }

    }
}
