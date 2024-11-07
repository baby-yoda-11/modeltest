using Newtonsoft.Json.Linq;
using NJsonSchema.Validation;
using NJsonSchema;

namespace modeltest.Validators
{
    public class CustomJsonSchemaValidator : JsonSchemaValidator
    {
        protected override ICollection<ValidationError> Validate(JToken token, JsonSchema schema, SchemaType schemaType, string propertyName, string propertyPath)
        {
            if (schema.Type.HasFlag(JsonObjectType.String) && !((JsonSchemaProperty)schema).IsRequired)
            {
                schema.IsNullableRaw = true;
            }

            return base.Validate(token, schema, schemaType, propertyName, propertyPath);
        }
    }
}
