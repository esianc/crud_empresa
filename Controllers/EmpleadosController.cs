using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web_api_db.Models;

namespace web_api_db.Controllers{
    [Route("api/[controller]")]
    public class EmpleadosController : Controller{
        private Conexion dbConexion;
        public EmpleadosController(){
            dbConexion = Conectar.Create();
        }
        [HttpGet]
        public ActionResult Get(){
            return Ok(dbConexion.Empleados.ToArray()) ;
        }
    }
}