using MediatR;

namespace ApplicationLayer.Students.Queries
{
    public class GetStudentQuery : IRequest<StudentModel>
    {
        public int Id { get; }
        public GetStudentQuery(int id)
        {
            Id = id;
        }
    }
}