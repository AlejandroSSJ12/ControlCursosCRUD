using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace EjercicioMongoDB.Models
{
    public static class ConexionMongo
    {
        public static IMongoCollection<CursoModel> GetCursoCollection()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            var Database = client.GetDatabase("Cursos");
            return Database.GetCollection<CursoModel>("DatosCurso");
        }
        public static IMongoCollection<AlumnoModel> GetAlumnoCollection()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            var Database = client.GetDatabase("Cursos");
            return Database.GetCollection<AlumnoModel>("DatosAlumno");
        }

    }
}
