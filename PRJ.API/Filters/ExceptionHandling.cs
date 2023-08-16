namespace PRJ.API.Filters;
public class ExceptionHandling
{
    private readonly RequestDelegate _next;
    public ExceptionHandling(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            context.Response.ContentType = "application/json";
            var result = JsonConvert.SerializeObject(new OutputDTO<dynamic>()
            {
                Succeeded = false,
                HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest),
                Message = ex.Message,
                Data = null
            });
            await context.Response.WriteAsync(result);
        }
    }
}
