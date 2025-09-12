using CinemaBackend.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Tell Kestrel to bind both ports
builder.WebHost.UseUrls("http://localhost:5298/", "https://localhost:7282");

// Register EF Core + MySQL
var conn = builder.Configuration.GetConnectionString("CinemaDb");
builder.Services.AddDbContext<CinemaDbContext>(opts =>
    opts.UseMySql(conn, ServerVersion.AutoDetect(conn))
);

// Add controllers & Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

// ✅ Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

// Only in Development: turn on Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cinema API V1");
        // RoutePrefix defaults to "swagger", so UI is at /swagger
    });
}

app.UseHttpsRedirection();

// Use CORS before authorization
app.UseCors("AllowAll");

app.UseAuthorization();
app.MapControllers();
app.Run();