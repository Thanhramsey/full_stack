using Newtonsoft.Json;

namespace LOP_FULLSTACK.Middlewares
{
public class LogCenterMiddleware
{
    private readonly ILogger<LogCenterMiddleware> _logger;

    private readonly RequestDelegate _next;

    public LogCenterMiddleware(
        ILogger<LogCenterMiddleware> logger,
        RequestDelegate next)
    {
        _logger = logger;
        _next = next;
    }

    public async Task Invoke (HttpContext context)
        {
            var path = context.Request.Path;
            var query = context.Request.Query;

            _logger.LogInformation("Request:{0} -{1}", path, query);

            if(path== "/Photo/DisplayRecent")
            {
                var json = new
                {
                    state= false,
                    message="Forbiden"
                };
                var jsonStr = JsonConvert.SerializeObject(json);
                context.Response.ContentType="application/json";
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync(jsonStr);
            }
            else
            {
                await _next(context);
            }
        }
}
}
