using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;

namespace E_Commerce.Application.Commen
{
    public sealed record Error(string Code, string Description, ErrorType ErrorType=ErrorType.Failure)
    {
        public static Error Failure(string code = "General.Failure", string description = "General Failure has Occurred")
        => new(code, description, ErrorType.Failure);

        public static Error Validation(string code = "General.Validation", string description = "General Validation Error has Occurred")
            => new(code, description, ErrorType.Validation);

        public static Error NotFound(string code = "General.NotFound", string description = "Resource NotFound")
            => new(code, description, ErrorType.NotFound);

        public static Error Conflict(string code = "General.Conflict", string description = "General Conflict has Occurred")
            => new(code, description, ErrorType.Conflict);

        public static Error Unauthorized(string code = "General.Unauthorized", string description = "Access Is denied Due To Bad Authorization")
            => new(code, description, ErrorType.Validation);

        public static Error Forbidden(string code = "General.Forbidden", string description = "The Operation Is Forbidden")
            => new(code, description, ErrorType.Forbidden);
        public static Error InvalidCerdentials(string code = "General.Invalid", string description = "Provided Cerdentials Are Invalid ")
            => new(code, description, ErrorType.Invalid);
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public  enum ErrorType
    {
        Failure = 0,
        Validation=1,
        NotFound=2,
        Conflict=3,
        Unauthorized=4,
        Forbidden=5,
        Invalid=6,

    }
}