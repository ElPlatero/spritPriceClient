using Microsoft.Extensions.Options;
using SpritPriceClient.Abstraction.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.Configure<SpritPriceClientConfiguration>(builder.Configuration.GetSection("spritPriceClient"));

var app = builder.Build();

if (app.Services.GetService<IOptions<SpritPriceClientConfiguration>>()?.Value.IsConfigured != true) {
    app.Logger.LogError("Could not start example API. Did you configure the sprit price client?");
    return;
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();