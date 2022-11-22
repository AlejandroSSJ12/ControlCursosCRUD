using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace EjercicioMongoDB.Models
{
    public static class Queries
    {
        public static List <AlumnoModel> ObtenerAlumnos()
        {
            var AlumnList = ConexionMongo.GetAlumnoCollection();
            List<AlumnoModel> result = AlumnList.Find(d => true).ToList();
            return result;
        }
        public static List<CursoModel> ObtenerCursos()
        {
            var CursoList = ConexionMongo.GetCursoCollection();
            List<CursoModel> result = CursoList.Find(d => true).ToList();
            return result;
        }
        public static void InsertarAlumno(AlumnoModel alumnoModel)
        {
            var alumModel = ConexionMongo.GetAlumnoCollection();
            alumModel.InsertOne(alumnoModel);
        }
        public static void InsertarCurso(CursoModel cursoModel)
        {
            var curModel = ConexionMongo.GetCursoCollection();
            curModel.InsertOne(cursoModel);
        }
        public static AlumnoModel BuscarAlumno (String NombreAlumno)
        {
            try
            {
                var ListaAlumnos = ConexionMongo.GetAlumnoCollection();
                AlumnoModel alumnoModel = ListaAlumnos.Find(d => d.NombreAlumno == NombreAlumno).First();
                return alumnoModel;
            } catch
            {
                return null;
            }
        }

        public static void Actualizar(AlumnoModel alumnoModel)
        {
            try
            {
                var alumno = ConexionMongo.GetAlumnoCollection();
                alumno.ReplaceOne(d => d.NombreAlumno == alumnoModel.NombreAlumno, alumnoModel);
            }
            catch (Exception ex) { }
            {
                return;
            }
            
        }

        public static bool VerificarCurso(String NombreCurso)
        {
            var curso = ConexionMongo.GetCursoCollection();
            var si = curso.Find(D => D.NombreCurso == NombreCurso).First();
            if (si != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
