using Newtonsoft.Json.Linq;
using NJsonSchema;
using NJsonSchema.Validation;
using System;

namespace modeltest.Validators
{
    public static class SftpValidator
    {
        public static ICollection<ValidationError> Validate(JToken token, JsonSchema schema)
        {
            var errors = new List<ValidationError>();

            var settings = token.Value<JToken?>("connection").Value<JToken?>("settings");
            var type = settings.Value<string?>("sftpAuthenticationTypeId");

            if (settings.Value<JToken?>(type) == null)
            {
                errors.Add(new ValidationError(ValidationErrorKind.PropertyRequired, type,token.Path, token, schema));
                return errors;
            }
            return null;
        }
    }
}
