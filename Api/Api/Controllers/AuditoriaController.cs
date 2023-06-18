using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("Auditoria")]
    public class AuditoriaController : Controller
    {
        readonly Context contextoBD;
        public AuditoriaController(Context contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        //Consultar todos los registros
        [HttpGet]
        [Route("listAuditoria")]
        public List<Auditoria> listAuditoria()
        {
            return this.contextoBD.auditoria.ToList();
        }

        //Almacenar registros de auditoria
        [HttpPut]
        [Route("AddAuditoria")]
        public void AddAuditoria(Auditoria aud)
        {
            this.contextoBD.auditoria.Add(aud);
            this.contextoBD.SaveChanges();
        }

        //Eliminar un registro individual por id
        [HttpDelete]
        [Route("deleteAuditoria/{id}")]
        public void deleteAuditoria(int id)
        {
            var temp = this.contextoBD.auditoria.FirstOrDefault(u => u.IdAuditoria == id);
            this.contextoBD.Remove(temp);
            this.contextoBD.SaveChanges();
        }

        //Consultar un registro en especifico por  id
        [HttpGet("getAuditoria/{id}")]
        public ActionResult<Auditoria> getAuditoria(int id)
        {
            var aud = this.contextoBD.auditoria.Find(id);
            if (aud != null)
            {
                return Ok(aud);
            }
            else
            {
                return NotFound();
            }
        }


        //Actualizar datos
        [HttpPut]
        [Route("editAuditoria")]
        public void editAuditoria(Auditoria aud)
        {
            this.contextoBD.Entry(aud).State=EntityState.Modified;
            this.contextoBD.SaveChanges();
        }

    }
}
