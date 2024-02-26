namespace GymApp.WEB.Infrastructure.Middleware.ErrorHandling
{
    public static class ErrorHandlingExtensions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
