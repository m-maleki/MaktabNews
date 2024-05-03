namespace MaktabNews.RazorPages.Infrastructure;

public class DetectVpnMiddleware
{
    private readonly RequestDelegate _next;

    public DetectVpnMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // read ip range form redis 
        var ipAddress = new List<string> { "192.168.1.1", "192.168.1.2", "192.168.1.3" }; // local ip address in development is :  

        if (ipAddress.Contains(context.Connection.RemoteIpAddress.ToString())
            && context.Request.Path.Value != "/AccessDenied")
            context.Response.Redirect("/AccessDenied");
        else
            await _next(context);
    }
}