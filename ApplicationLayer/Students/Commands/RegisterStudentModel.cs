using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Students.Commands
{
    public class RegisterStudentModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Documento { get; set; }
    }
}
