Creamos un WepApi, en el propio controlador del proyecto,


Calse Prinicpal
 [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase

    Acciones:
         [HttpGet("{id}")]
        public ActionResult<Pizza> GetById(int id)

        
        [HttpPost]
        public ActionResult<Pizza> Post(Pizza pizza)


        Y en la página, simulando el cliente, ponemos 2 botones que con jqery llama a las acciones del WEB API que están en el contolador
