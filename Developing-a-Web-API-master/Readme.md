Simulamos un WEBAPI creando las acciones en el propio Controlador y accediendo a ellas desde la url. En realidad serán llamadas desde fuera, pero como priomera práctica queda
así.  Además para la acción de listar todos aparece en formato xml


Clase principal:
 [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private List<Person> _people = new List<Person>();



        Acciones:
            [HttpGet]
        [Produces("application/xml")]
        public List<Person> GetAll()


         [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)