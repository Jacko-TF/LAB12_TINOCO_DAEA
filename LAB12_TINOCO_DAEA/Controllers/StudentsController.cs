using LAB12_TINOCO_DAEA.Models.Request;
using LAB12_TINOCO_DAEA.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace LAB12_TINOCO_DAEA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpPost(Name = "ListTesoreria")]
        public List<StudentResponse2> ListTesoreria(StudentRequest1 student)
        {
            List<StudentResponse2> students = new();
            Random rand = new();

            for (int i = 1; i <= 100; i++)
            {
                students.Add(new StudentResponse2{ Codigo = i,  Nombre = $"Jacko{i}", Mensualidad = rand.Next(1300,1750)});
            }

            return students.Where(x => x.Codigo == student.Codigo).ToList();
        }

        [HttpPost(Name = "ListAcademia")]
        public List<StudentResponse1> ListAcademia(StudentRequest1 student)
        {
            List<StudentResponse1> students = new();
            Random rand = new();

            for (int i = 1; i <= 100; i++)
            {
                students.Add(new StudentResponse1 { Codigo = i, Nombre = $"Jacko{i}", Nota = rand.Next(0, 21) });
            }

            return students.Where(x => x.Codigo == student.Codigo).ToList();
        }
    }
}