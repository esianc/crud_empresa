using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web_api_db.Models;

namespace web_api_db.Controllers{
    [Route("api/[controller]")]
    public class PuestosController : Controller{
        private Conexion dbConexion;
        public PuestosController(){
            dbConexion = Conectar.Create();
        }
        [HttpGet]
        public ActionResult Get(){
            return Ok(dbConexion.Puestos.ToArray()) ;
        }
    }
}