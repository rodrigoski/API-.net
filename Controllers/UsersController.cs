using Microsoft.AspNetCore.Mvc;
using MiApiDevOps.Models;

namespace MiApiDevOps.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
[HttpGet("GetUsuario/{id}/{nombre}/{edad}")]
public IActionResult Get(int id, string nombre, int edad)
{
    var usuario = new User { Id = id, Nombre = nombre, Edad = edad };
    return Ok(usuario);
}
}