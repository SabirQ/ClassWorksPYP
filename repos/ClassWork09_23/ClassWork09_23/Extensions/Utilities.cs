using ClassWork09_23.Middlewares;

namespace ClassWork09_23.Extensions
{
    public static class Utilities
    {
        public static async Task UseAsyncCustom(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<BrowserMiddleware>();
        }
    }
}
