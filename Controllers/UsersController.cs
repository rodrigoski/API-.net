using Microsoft.AspNetCore.Mvc;
using MiApiDevOps.Models;

namespace MiApiDevOps.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
[HttpGet("GetUsuario/{id}/{nombre}/{edad}/{correo}")]
public IActionResult Get(int id, string nombre, int edad, string correo)
{
    var usuario = new User { Id = id, Nombre = nombre, Edad = edad, Correo = correo };
    return Ok(usuario);
}
}