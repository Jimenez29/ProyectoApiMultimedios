using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("Auditoria")]
    public class ErrorController : Controller
    {
        readonly Context contextoBD;
        public ErrorController(Context contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        //Consultar todos los registros
        [HttpGet]
        [Route("listError")]
        public List<Error> listError()
        {
            return this.contextoBD.error.ToList();
        }

        //Almacenar registros de error
        [HttpPut]
        [Route("AddError")]
        public void AddError(Error error)
        {
            this.contextoBD.error.Add(error);
            this.contextoBD.SaveChanges();
        }

        //Eliminar un registro individual por id
        [HttpDelete]
        [Route("deleteError/{id}")]
        public void deleteError(int id)
        {
            var temp = this.contextoBD.error.FirstOrDefault(u => u.IdErrores == id);
            this.contextoBD.Remove(temp);
            this.contextoBD.SaveChanges();
        }

        //Consultar un registro en especifico por  id
        [HttpGet("getError/{id}")]
        public ActionResult<Error> getError(int id)
        {
            var error = this.contextoBD.error.Find(id);
            if (error != null)
            {
                return Ok(error);
            }
            else
            {
                return NotFound();
            }
        }


        //Actualizar datos
        [HttpPut]
        [Route("editError")]
        public void editError(Error error)
        {
            this.contextoBD.Entry(error).State = EntityState.Modified;
            this.contextoBD.SaveChanges();
        }

    }
}
