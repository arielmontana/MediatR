using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ApplicationLayer.Students.Queries
{
    public class GetStudentQueryHandler : IRequestHandler<GetStudentQuery, StudentModel>
    {
        public GetStudentQueryHandler()
        {
            //No se olviden de injectar acá la fuente de donde obtienen los datos (IRepo..)
        }
        public async Task<StudentModel> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            //El handler de Student debería devolverles un StudentModel, para
            //ello lo debería buscar en base de datos, usando el Id que viene en el 
            // request  -->GetStudentQuery (mensaje)
            return new StudentModel() { Id = request.Id, Nombre = "NombreDemo", Apellido = "ApellidoDemo", Documento = 123456789 };
        }
    }
}