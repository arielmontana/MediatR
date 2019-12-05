using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ApplicationLayer.Students.Commands
{
    public class RegisterStudentCommandHandler : IRequestHandler<RegisterStudentCommand>
    {
        public async Task<Unit> Handle(RegisterStudentCommand request, CancellationToken cancellationToken)
        {
            //Execute use case here
            Debug.WriteLine("---------- Comienza CU: RegisterStudent -------------- ");
            Debug.WriteLine($"           Nombre: {request.Nombre} ");
            Debug.WriteLine($"           Apellido: {request.Apellido} ");
            Debug.WriteLine($"           Documento: {request.Documento} ");
            Debug.WriteLine("---------- Finaliza CU: RegisterStudent -------------- ");
            //
            return Unit.Value;
        }
    }
}