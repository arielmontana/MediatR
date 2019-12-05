using ApplicationLayer.Students.Commands;
using ApplicationLayer.Students.Queries;
using Microsoft.AspNetCore.Mvc;
using PresentationMediatR.Controllers.Base;
using System.Threading.Tasks;

namespace PresentationMediatR.Controllers
{
    [ApiController]
    public class StudentController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Register(RegisterStudentModel student)
        {
            await Mediator.Send(new RegisterStudentCommand(student.Nombre, student.Apellido, student.Documento));
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetStudentQuery(id)));
        }
    }
}