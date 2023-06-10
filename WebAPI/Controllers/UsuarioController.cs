using Microsoft.AspNetCore.Mvc;
using WebAPI.DATA;
using WebAPI.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
  
    public class UsuarioController : ControllerBase
    {
        [HttpGet("Get")]
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }

        [HttpGet("GetById/{ID}")]
        public Usuario GetById(int ID)
        {
            return UsuarioData.Obtener(ID);
        }

        [HttpPost()]
        public bool Post([FromBody] Usuario oUsuario)
        {
            return UsuarioData.Registrar(oUsuario);
        }

        [HttpPut("Put")]
        public bool Put([FromBody] Usuario oUsuario)
        {
            return UsuarioData.Modificar(oUsuario);
        }

        [HttpDelete("DELETE/{ID:int}")]
        public bool Delete(int ID)
        {
            return UsuarioData.Eliminar(ID);
        }
    }
}



