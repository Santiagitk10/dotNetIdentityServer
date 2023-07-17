# dotNetIdentityServer



https://www.youtube.com/watch?v=SXJ377G5bOg


API
https://localhost:5445

http://localhost:5002

Server

https://localhost:5443

http://localhost:5000


Client

https://localhost:5444

http://localhost:5001



- Esto se elimina para no tener warning de nulos

    <Nullable>enable</Nullable>


- Paquetes para la API y para el DataAccess

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools


- Para crear la migración en el Package Manager Console

(El startup project debe ser el de la API, que es donde se configura el contexto)

Add-Migration InitialMigration

Update-Database


- El StartUp Project debe ser seteado a múltiple. Todos en start menos el DataAccess

Paquete para Identity Server

IdentityServer4

IdentityServer4.EntityFramework

Microsoft.EntityFrameworkCore.Tools

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.AspNetCore.Identity.UI

IdentityServer4.AspNetIdentity

Microsoft.AspNetCore.Identity.EntityFrameworkCore


- Para la migración del Identity Server

//c significa context

Add-Migration InitialIdentityServerMigration -c PersistedGrantDbContext

Add-Migration InitialIdentityServerMigration -c ConfigurationDbContext

Update-Database -Context PersistedGrantDbContext

Update-Database -Context ConfigurationDbContext


- Para agregar las migraciones de ASP.NET Identity

Add-Migration InitialAspNetIdentityMigration -c AspNetIdentityDbContext

Update-Database -Context AspNetIdentityDbContext


- Para hacer el seed de identity server desde el Package Manager Console

Asegurarse de estar en la carpeta root con: dir

dotnet run Server/bin/Debug/net6.0/Server /seed --project Server

Revisar https://localhost:5443/.well-known/openid-configuration

Se tendra una respuesta con el seed y ya las tablas tendrán el seed data

Part 2

https://www.youtube.com/watch?v=rNqgxAqGZJ8



Repo del tutorial

https://github.com/codewithiulian/CoffeeShopper-IS4
