En esta práctica vemos, en 2 proywctos separados, como el clinete llama al WEPAPI del servidor

En el cliente, en el middleware se añade e servicio services.AddHttpClient();



En el controlador del servisorse decora la clase principal

 [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase


    Y las acciones:
     [HttpGet("{id}")]
        public ActionResult<GroceryStore> GetById(int id)
        {

        [HttpPost]
        public ActionResult<GroceryStore> Create(GroceryStore groceryStore)

Y en el controlador del cliente:
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:61086");
            HttpResponseMessage response = httpClient.GetAsync("http://localhost:61106/api/store/1").Result;



            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:61086");
            GroceryStore newGrocery = new GroceryStore { Name = "Martin General Stores", Address = "4160  Oakwood Avenue" };
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("http://localhost:61106/api/store", newGrocery);