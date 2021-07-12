Vamos a poder convertir json a xmal y éste dice a Autorest como debe generar el código c#

y así poder llamar a las Web Api



Comprobamos que funciona nuestro web api

![web_api_funciona](https://github.com/JuanjoSalva/Generating-C-HTTP-Clients-by-Using-AutoRest/blob/main/img/web_api_funciona.PNG)



Creamos el json:

![creamos el json](https://github.com/JuanjoSalva/Generating-C-HTTP-Clients-by-Using-AutoRest/blob/main/img/creamos el json.PNG)



A partir de ese webapi.json creamos el xmal

![creamos el xmal](https://github.com/JuanjoSalva/Generating-C-HTTP-Clients-by-Using-AutoRest/blob/main/img/creamos el xmal.PNG)

Copiamos en el xmal generado en el directorio Autorest.Sdk

![copiamoselxmal](https://github.com/JuanjoSalva/Generating-C-HTTP-Clients-by-Using-AutoRest/blob/main/img/copiamoselxmal.PNG)



Comando para geneal el CSharp a partir del xmal

![generandocsharp](https://github.com/JuanjoSalva/Generating-C-HTTP-Clients-by-Using-AutoRest/blob/main/img/generandocsharp.PNG)



Se ha generado el Csharp:

![generado_csharp](https://github.com/JuanjoSalva/Generating-C-HTTP-Clients-by-Using-AutoRest/blob/main/img/generado_csharp.PNG)



Se llama al recurso Get:

![recursoGet](https://github.com/JuanjoSalva/Generating-C-HTTP-Clients-by-Using-AutoRest/blob/main/img/recursoGet.PNG)



Que es lo mismo que por web:

![GetWeb](https://github.com/JuanjoSalva/Generating-C-HTTP-Clients-by-Using-AutoRest/blob/main/img/GetWeb.PNG)


El proyecto resultante se encuentra en la carpeta AutoRest.Sdk
