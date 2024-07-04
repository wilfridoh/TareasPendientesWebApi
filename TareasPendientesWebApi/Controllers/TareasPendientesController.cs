using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using TareasPendientesWebApi.Models;

namespace TareasPendientesWebApi.Controllers
{

    public class TareasPendientesController : ApiController
    {

        private readonly AppDbContext _context;

        public TareasPendientesController()
        {
            _context = new AppDbContext();
        }

        // GET: TareasPendientes
        public IQueryable<TareasPendientes> GetTareasPendientes()
        {
            return _context.tareasPendientes;
        }

        // GET: TareasPendientes/Details/5
        public IHttpActionResult GetTareasPendiente(int id)
        {
            var tareas = _context.tareasPendientes.Find(id);
            if (tareas == null)
            {
                return NotFound();
            }
            return Ok(tareas);
        }

        // POST: TareasPendientes/Create
        public IHttpActionResult CreateTareasPendientes(TareasPendientes tareasPendientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            tareasPendientes.fechaCreacion = System.DateTime.Now;
            _context.tareasPendientes.Add(tareasPendientes);
            _context.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = tareasPendientes.id }, tareasPendientes);
        }

        // PUT: api/TareasPendientes/5
        public IHttpActionResult PutTareasPendientes(int id, TareasPendientes tareasPendientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != tareasPendientes.id)
            {
                return BadRequest();
            }
            _context.Entry(tareasPendientes).State = EntityState.Modified;
            _context.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: TareasPendientes/Delete/5
        public IHttpActionResult DeleteTareasPendientes(int id)
        {
            var tareasPendientes = _context.tareasPendientes.Find(id);
            if (tareasPendientes == null)
            {
                return NotFound();
            }

            _context.tareasPendientes.Remove(tareasPendientes);
            _context.SaveChanges();

            return Ok(tareasPendientes);
        }
    }
}
