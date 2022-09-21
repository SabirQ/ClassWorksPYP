namespace WebAppMVC14_09.Infrastructure
{
    public class ShortCircuitMiddleware
    {
        private RequestDelegate _requestDelegate;
        public ShortCircuitMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Items["IE"] as bool? ==true)
            {
                httpContext.Response.StatusCode = 403;
            }
            else
            {
                await _requestDelegate.Invoke(httpContext);
            }
        }
    }
}
