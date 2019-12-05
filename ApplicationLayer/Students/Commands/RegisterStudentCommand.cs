using MediatR;
using Newtonsoft.Json;

namespace ApplicationLayer.Students.Commands
{
    public class RegisterStudentCommand : IRequest
    {
        public string Nombre { get; }
        public string Apellido { get; }
        public int Documento { get; }

        [JsonConstructor]
        public RegisterStudentCommand(string nombre, string apellido, int documento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
        }
    }
}