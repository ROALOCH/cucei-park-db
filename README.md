> **⚠️ ADVERTENCIA ⚠️**  
> Este proyecto no se encuentra terminado, el release no corresponde a la versión final del software. La documentación y algunas funcionalidades descritas en el README pueden variar o no estar contenidas. **Moraleja**: Siempre suban su último commit al repositorio 😢
> <br>

<hr>
<br>

# Proyecto Final: parkDB

Ochoa Herrera Rodrigo Alejandro  
CUCEI | Universidad de Guadalajara  
I5891 - Seminario de Bases de Datos

### Descripción

Este repositorio contiene el proyecto final para la materia de Seminario de Bases de Datos. parkDB es un administrador de estacionamientos, con funcionalidades básicas como:

- Autenticación y Autorización de Usuarios
- Generación de Tickets
- Administración de Empleados y Estacionamientos

### Configuración

Para ejecutar el programa es necesario realizar configuraciones importantes dentro del archivo **App.config**.

#### Configuración: Base de Datos

Por defecto el proveedor de servicio de base de datos esta configurado para ser PostgreSQL, pero puede ser cambiado por un proveedor compatible para .NET. El proveedor puede ser configurado en el archivo **App.conf** en las etiquetas _DbProviderFactories_ y _appSettings/proveedorSQL_.

El script SQL para la creación de las tablas se encuentra en el archivo **scriptSQL**.

#### Configuración: ImgBB API

Las imágenes de perfil de los usuarios creados son almacenadas en el servicio ImgBB. La configuración de este servicio sirve para almacenar correctamente las imágenes, aunque es opcional. Si no se habilita este servicio, los usuarios apareceran con avatares por defecto.

Para configurar el API, se necesita generar una llave en [ImgBB](https://api.imgbb.com/) y colocarla dentro del archivo **App.config** en la etiqueta _appSettings/ImgbbAPIKey_.

#### Configuración: SendGrid API

Para la recuperacion de cuentas por medio de correo electrónico, se hace uso del servicio SendGrid. Es una característica importante en caso de que se olvide de la contraseña de usuario, pero igualmente es un módulo opcional.

Para configurar el API, se necesita generar una llave en [SendGrid](https://sendgrid.com/docs/ui/account-and-settings/api-keys/#creating-an-api-key) y colocarla dentro del archivo **App.config** en la etiqueta _appSettings/SendGridAPIKey_.

### Licencia

[MIT](https://github.com/ROALOCH/parkDB/blob/master/LICENSE)
