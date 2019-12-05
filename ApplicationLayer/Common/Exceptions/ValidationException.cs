using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationLayer.Common.Exceptions
{
    public class ValidationException : Exception
    {
        //Nombre de la propiedad que fallo y validaciones fallidas de esa propiedad
        public IDictionary<string, string[]> Failures { get; }

        public ValidationException() :
            base("Uno o mas fallos de validación han ocurrido.")
        {
            Failures = new Dictionary<string, string[]>();
        }

        public ValidationException(List<ValidationFailure> failures) : this()
        {
            var propertyNames = failures
                .Select(e => e.PropertyName)
                .Distinct();

            foreach (var propertyName in propertyNames)
            {
                var propertyFailures = failures
                    .Where(e => e.PropertyName == propertyName)
                    .Select(e => e.ErrorMessage)
                    .ToArray();

                Failures.Add(propertyName, propertyFailures);
            }
        }
    }
}