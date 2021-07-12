## Managing State


Configuramos nuestro programa, startup, para añadir los servicios para poder crear y usar la sesión:

services.AddSession();
app.UseSession();


En el controlador de la página de Inicio colocamos código que recuperalas veces qye entramos en Home durante la sesión , la incrementa y nos mostrará información de las visitas durante la sesiónando.

En el otro controlador hace lo mismo, pero con las visitas de otra página


1. Arrancamos la apliicación

![basket_con_cache_1](https://github.com/JuanjoSalva/Managing-State/blob/master/StateExample/img/inicio.PNG)

2. Pulsamos varias veces a Home

![basket_con_cache_1](https://github.com/JuanjoSalva/Managing-State/blob/master/StateExample/img/variosHome.PNG)

3. Pulsamos varias veces a Other

![basket_con_cache_1](https://github.com/JuanjoSalva/Managing-State/blob/master/StateExample/img/variosOtros1.PNG)

4. Pulsamos a Home

![basket_con_cache_1](https://github.com/JuanjoSalva/Managing-State/blob/master/StateExample/img/variosOtros2.PNG)

5. Abrimos una página en modo privado con la misma Url y puerto, pero al ser otra sesión se reinicia.

![basket_con_cache_1](https://github.com/JuanjoSalva/Managing-State/blob/master/StateExample/img/private.PNG)

