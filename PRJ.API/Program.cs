


using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.Services.InstallServiceAssembly(builder.Configuration);
builder.Services.AddControllers(options =>
{
    //options.Filters.Add(typeof(ExceptionHandling));
});
//builder.Services.AddHostedService<AppointmentStatusService>();
//builder.Services.Configure<StripeOptions>(option =>
//{
//    option.SecretKey = Environment.GetEnvironmentVariable("sk_test_51MEvEGJx6a3z1tBaZqW3Tr5UxYdKr8Vj9mut3oyp3vAxguWBnTxiHve1MQOngJCUvBbUe1fbpuHJ5tgAAE78OaoU00xGU879gQ");
//    option.PublishableKey = Environment.GetEnvironmentVariable("pk_test_51MEvEGJx6a3z1tBaUh9lHMCfKE9aQa1hl8ylxwzj6RF8pXQh3bBCG1wkd3eATw8CSP8SHgGJTkeQOiNmt6XYLMO300yiYYb1QG");
//  //  option.WebhookSecret = Environment.GetEnvironmentVariable("WebhookSecret");
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "IntellyHealth.API V1");
       
    });
   
}


app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseMiddleware(typeof(ExceptionHandling));

app.MapControllers();
 
app.UseCors(x => x
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .SetIsOriginAllowed(origin => true) // allow any origin
                            .AllowCredentials());

app.UseStatusCodePages(async context =>
{
    if (
            context.HttpContext.Response.StatusCode == StatusCodes.Status401Unauthorized ||
            context.HttpContext.Response.StatusCode == StatusCodes.Status403Forbidden
        )
    {
        context.HttpContext.Response.StatusCode = Convert.ToInt32(HttpStatusCode.Unauthorized);
        context.HttpContext.Response.ContentType = "application/json";
        await context.HttpContext.Response.WriteAsync(JsonConvert.SerializeObject(new OutputDTO<dynamic>()
        {
            Succeeded = false,
            HttpStatusCode = Convert.ToInt32(HttpStatusCode.Unauthorized),
            Message = Convert.ToString(HttpStatusCode.Unauthorized),
            Data = null
        }));
    }
});

app.Run();
