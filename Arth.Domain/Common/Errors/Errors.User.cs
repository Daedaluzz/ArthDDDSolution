using ErrorOr;

namespace Arth.Domain.Common.Errors;

public static partial class Errors
{
    public static class Users
    {
        public static Error DuplicateEmail => Error.Conflict(
            code: "User.DuplicateEmail",
            description: "Email is alredy in use.");
    }
}
