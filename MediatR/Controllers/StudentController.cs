using ApplicationLayer.Students.Commands;
using DemoMediatR.Controllers.Base;
using DemoMediatR.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoMediatR.Controllers
{
    public class StudentController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Register([FromBody]StudentDto student)
        {
            await Mediator.Send(new RegisterStudentCommand(student.Nombre, student.Apellido, student.Documento));
            return NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> RegisterTwo([FromBody]RegisterStudentCommand student)
        {
            await Mediator.Send(student);
            return NoContent();
        }
    }
}