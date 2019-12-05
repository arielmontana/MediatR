using FluentValidation;

namespace ApplicationLayer.Students.Commands
{
    public class RegisterStudentCommandValidator : AbstractValidator<RegisterStudentCommand>
    {
        public RegisterStudentCommandValidator()
        {
            RuleFor(x => x.Nombre).NotNull().WithMessage("Nombre no puede ser nulo");
            RuleFor(x => x.Apellido).NotNull();
            RuleFor(x => x.Documento).NotEqual(0);
        }
    }
}