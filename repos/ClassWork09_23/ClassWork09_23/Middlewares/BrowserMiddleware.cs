namespace ClassWork09_23.Middlewares
{
    public class BrowserMiddleware
    {
        private readonly RequestDelegate _next;
        public BrowserMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Headers.UserAgent != "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/105.0.0.0 Safari/537.36 Edg/105.0.1343.42")
            {
                Console.WriteLine(context.Request.QueryString);
                
                await _next.Invoke(context); 
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
            }

        }

    }
}
