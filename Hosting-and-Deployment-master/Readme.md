## Laboratorio Módulo 14

Fichero de Instrucciones: Instructions\20486D_MOD014_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** Juan José Salvador Román
2. **Fecha:** 17/12/2020
3. **Resumen del Ejercicio:** 

**Laboratorio: Implementación de API web**

En este laboratorio, los estudiantes primero implementarán una aplicación web en Microsoft Azure. La aplicación gestionará un acuario. Almacenará y mostrará detalles de varios peces y una imagen para cada pez. El usuario puede agregar / editar / eliminar un pez. En la segunda parte del laboratorio, los estudiantes crearán un contenedor de almacenamiento de Azure. Luego, modificarán la aplicación para almacenar la imagen del pez en el contenedor de almacenamiento de Azure en lugar de almacenarla localmente.

**Objetivos**
Después de completar esta práctica de laboratorio, podrá:

- Cree un servicio de aplicaciones en Microsoft Azure.

- Implemente una aplicación en Azure.

- Trabaje con Azure SQL Database.

- Cree un contenedor de almacenamiento en Azure.

- Cargue imágenes en contenedores de almacenamiento desde una aplicación.



**Ejercicio 1:** implementación de una aplicación web en Microsoft Azure
Guión
En este ejercicio, primero creará y ejecutará una aplicación web simple de forma local. Para ello, ejecutará migraciones para su base de datos local. Luego, creará un servicio de aplicaciones de Azure y una base de datos SQL de Azure en Azure y configurará su aplicación para usar la base de datos SQL de Azure. Completará la base de datos utilizando Migrate. Finalmente, implementará su aplicación en Azure.

Las principales tareas de este ejercicio son las siguientes:

- Explore y ejecute la aplicación localmente.

- Cree una nueva aplicación web en Azure.

- Prepare la aplicación para su implementación.

- Implemente la aplicación.

- Actualice la aplicación e impleméntela en Azure.

Esta es la página:
![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/index.PNG)

Insertamos nuevo pez

![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/insertar.PNG)

Lo mostramos
![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/insertado.PNG)

Actualizamos el nombre de un pez y vemos que se cambia

![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/azure_editado.PNG)


Borramos un pez y vemos que ya no sale

![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/azure_delete.PNG)


 Creamos en el Portal Azure un recurso: Web app + Sql
![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/WebAppBBDD.PNG)


Publicamos en Azure desde Visual Studio
![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/visualstudio_publish.PNG)

![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/visual_publishPNG.PNG)


Añadimos nuevo campo en la base de datos y restauramos la bbdd
![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/nuevo_campo.PNG)

Vemos el resultado en el portal de Azure

![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/azure_recursos.PNG)


Damos permisos a nuestra ip:

![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/security.PNG)



**Ejercicio 2:** cargar una imagen en Azure Blob Storage
Guión
En este ejercicio, creará una cuenta de almacenamiento de Azure en Azure y un contenedor en la cuenta de almacenamiento. Luego, modificará la aplicación web que creó para comenzar a almacenar las imágenes en Azure Blob Storage. Las imágenes también se mostrarán desde el almacenamiento utilizando la URL generada para cada imagen. Además, cambiará el código para cargar imágenes al contenedor. Finalmente, implementará su aplicación en Azure.

Las principales tareas de este ejercicio son las siguientes:

- Crear una cuenta de almacenamiento de blobs

- Prepare la aplicación para trabajar con Azure Storage.

- Escribe el código para subir una imagen.

- Implementar y ejecutar la aplicación en Azure


CReamos un recurso nuevo: blob storage

![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/azure_a%C3%B1adido_storage.PNG)


añadimos una foto al storage
![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/a%C3%B1adido_blob_azure.PNG)

![subir_estos](https://github.com/JuanjoSalva/Hosting-and-Deployment/blob/master/Underwater/img/a%C3%B1adido_blob_web.PNG)



Ahora las fotos als coge del local si están y si no del Blob Storage








