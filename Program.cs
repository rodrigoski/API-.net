var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

// Habilitar archivos estáticos (wwwroot)
app.UseStaticFiles(); 

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

// Redirección a la interfaz
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run("http://localhost:5220"); 