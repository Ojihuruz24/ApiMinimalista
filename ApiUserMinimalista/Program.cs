using ApiUserMinimalista.Controllers;
using ApiUserMinimalista.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//aca vamos hacer inyeccion de dependencias para la conexion de la base de datos
builder.Services.AddDbContext<METEOROLOGIAContext>();
//cuando quiero hacer inyeccion de dependenciar a una clase 
builder.Services.AddTransient<UsuarioController>();

//para agg swager
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    //agg el swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

#region USUARIOS

//https://localhost:7216/usuario
//app.MapGet("/Usuarios", () =>
//{
//    using (var context = new METEOROLOGIAContext())
//    {
//        return context.Usuarios.ToList();
//    }
//});


//se hace lo mismo pero se utiliza el context inyectado en el builder.Services
app.MapGet("/UsuariosInyection", (METEOROLOGIAContext context) =>
       context.Usuarios.ToList()
);

#endregion


app.MapGet("/Usuarios", (UsuarioController user) =>
        user.GetUsuarios()
) ;


app.MapGet("/Climas", (UsuarioController user) =>
        user.GetUsuarios()
);


app.Run();

