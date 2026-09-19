Después de tu exitosa aplicación del patrón Método Factoría, te han pedido ayuda para implementar un nuevo tipo de motor:
El motor de salto, que funciona sin combustible y mediante teleportación. 

Tiene la desventaja de que solo puede haber uno en el universo, pero como existe en 17 dimensiones, se puede compartir entre vehículos sin problema.


Programa este nuevo tipo de motor (JumpEngine), que implementa la interfaz IEngine y el patrón Singleton.

Este es el código de los métodos moveVehicle y refuel del motor de salto.

    public bool moveVehicle(int distance)
    {
        Console.Write($"Teleporting vehicle {distance} kms");
        Console.WriteLine();
        return true;
   
    }
    public void refuel()
    {
        Console.Write("No need for fuel");
    }

## Tests

El proyecto incluye tests de aprobación que verifican la salida del programa. Ejecútalos con:

```bash
dotnet test
```

**No está permitido modificar los tests.** Su función es garantizar que el comportamiento observable del programa se mantiene tras tus cambios.
