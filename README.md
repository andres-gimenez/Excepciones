# Excepciones

Practica para entender excepciones.

Crea exepciones personalizadas y compara las siguientes casuisticas:

##### Crear una nueva excepci�n

```csharp
try
{
}
catch(Exception ex)
{
    throw new Excepcion("...");
}
``` 

##### Crear una nueva excepci�n guardando la pila

Propagar una nueva excepci�n.
```csharp
try
{
}
catch(Exception ex)
{
    throw new Excepcion("...", ex);
}
``` 

##### Lanzar la misma excepci�n, perdiendo la pila

```csharp
try
{
     ...
}
catch(Exception ex)
{
    throw ex;
}
``` 

##### Lanzar la misma excepci�n, manteniendo la pila

```csharp
try
{
     ...
}
catch(Exception ex)
{
    throw;
}
``` 



