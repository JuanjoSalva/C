## Laboratorio Módulo 11

Fichero de Instrucciones: Instructions\20486D_MOD011_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** Juan José Salvador Román
2. **Fecha:** 07/12/2020
3. **Resumen del Ejercicio:** 

	Se crea una libreria.
	
	Se le ha pedido que cree una aplicación de biblioteca basada en la web para los clientes de su organización. La aplicación debe tener una página que muestre los libros más recomendados, las páginas de inicio de sesión y registro, y la capacidad de agregar libros a la biblioteca solo para usuarios autorizados. La aplicación debe tener una configuración de identidad, una variedad de configuraciones para la autorización y una demostración de un ataque de falsificación de solicitud entre sitios.
	
	- Use Identity.

	- Add Authorization.

	- Avoid the Cross-Site Request Forgery attack.


**Index**
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Index_Logado.PNG)
	
**Ejercicio 1:** Utilice la identidad

En este ejercicio, primero agregará un contexto entidad-marco-base de datos a la clase LibraryContext. Luego habilitará el uso de identidad en la clase de inicio. Después de eso, agregará el inicio de sesión y registrará la lógica del usuario. Finalmente, recuperará datos de la propiedad de identidad en la vista LendingBook.cshtml.

Las principales tareas de este ejercicio son las siguientes:

1. Agregar el contexto de la base de datos de Entity Framework

2. Habilitar el uso de identidad

3. Agregar lógica de inicio de sesión

4. Agregar Registrar una lógica de usuario

5. Recuperar datos de la propiedad Identity

6. Ejecutar la aplicación	
	

**login**
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Login.PNG)

**Register**
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Register.PNG)
	
	
	
	
**Ejercicio 2:** Agregar autorización

En este ejercicio, primero agregará AuthorizeAttribute a la clase LibraryController. Luego, configurará la autenticación de políticas basada en roles y basada en reclamos. Y agregará el atributo relevante en la clase AccountController y en la clase LibrarianController.

Las principales tareas de este ejercicio son las siguientes:

1. Agregar AuthorizeAttribute a una acción

2. Agregar autenticación de políticas basada en roles

3. Agregar autenticación de políticas basada en reclamos

4. Ejecutar la aplicación



**Autorizacion**

Vemos que el menú es diferente si estas logado como administrador o si no, ya que al administardor deja insertar libros

**Si no**
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Index.PNG)

**Si intentamos entrar en Libarry sin estar logados**
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Library.PNG)

**Administrador**
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Index_Logado.PNG)

**Añadir libros**
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/añadir.PNG)

**Nuestro libros**
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Our.PNG)


Una vez logados como miembros, (no Administrator),  en la plicación intentamos cambiar la url a una de añadir librosy nos da el error de permiso denegado

![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Nopermiso.PNG)



**Ejercicio 3:** Evite el ataque de falsificación de solicitudes entre sitios

En este ejercicio, primero escribirá el ataque de falsificación de solicitud entre sitios en un proyecto separado. Luego ejecutará la aplicación y verá el posible ataque. Finalmente, evitará el ataque Cross-Site Request Forgery agregando el atributo ValidateAntiForgeryToken en la clase AccountController, ejecute la aplicación y verá que el ataque no es posible.

Las principales tareas de este ejercicio son las siguientes:

1. Escriba el ataque de falsificación de solicitudes entre sitios

2. Ejecute la aplicación: ahora el ataque es posible

3. Evite el ataque de falsificación de solicitudes entre sitios

4. Ejecute la aplicación: ahora el ataque no es posible



Se ha creado un nuevo proyecto para probar el ataque, con un controlador donde la acción index no tiene control y simulando una URL en la que se navega hasta una página de registro y se crea un usuario, con lo que entra.

<form action="http://localhost:61845/Account/Register?FirstName=Forgery1_Attacker&LastName=Cross_Site&PhoneNumber=123&Email=attack@@.com&UserName=Forgery_Attacker&Password=123qwe!!!QWE123&RoleName=Administrator" method="post">
        <input type="submit" value="Attack">
    </form>
    
![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Attack1.PNG)

![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/Attack2.PNG)


Para evitarlo en el registro por POST de los comtroladores se añade la decoracion
[ValidateAntiForgeryToken] y así te lleva al index.

![index](https://github.com/JuanjoSalva/Managing-Security/blob/master/CrossSiteRequestForgeryAttack/img/IndexPNG) 


	
4. **Dificultad o problemas presentados y como se resolvieron:** 
