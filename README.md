# Excepciones

Practica para entender excepciones.

Crea exepciones personalizadas y compara las siguientes casuisticas:

##### Crear una nueva excepción

```csharp
try
{
}
catch(Exception ex)
{
    throw new Excepcion("...");
}
``` 

##### Crear una nueva excepción guardando la pila

Propagar una nueva excepción.
```csharp
try
{
}
catch(Exception ex)
{
    throw new Excepcion("...", ex);
}
``` 

##### Lanzar la misma excepción, perdiendo la pila

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

##### Lanzar la misma excepción, manteniendo la pila

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



