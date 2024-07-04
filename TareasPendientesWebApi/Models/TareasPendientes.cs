using System;

namespace TareasPendientesWebApi.Models
{
    public class TareasPendientes
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public bool completada { get; set; }
    }
}