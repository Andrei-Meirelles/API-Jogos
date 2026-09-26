namespace projeto1.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            await _next(context);


            Console.WriteLine(context.Request.Method);
            Console.WriteLine(context.Request.Path);
            Console.WriteLine(context.Response.StatusCode);
        }

    }
}
