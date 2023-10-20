# HttpGet, HttpPost

http://localhost:5102/RouteCargo

http://localhost:5102/RouteCliente

http://localhost:5102/RouteColor

http://localhost:5102/RouteDepartamento

http://localhost:5102/RouteDetalleOrden

http://localhost:5102/RouteDetalleVenta

http://localhost:5102/RouteEmpleado

http://localhost:5102/RouteInsumo



# HttpGet{id}, HttpPut{id}, HttpDelete{id}

http://localhost:5102/RouteCargo/{id}

http://localhost:5102/RouteCliente/{id}

http://localhost:5102/RouteColor/{id}

http://localhost:5102/RouteDepartamento/{id}

http://localhost:5102/RouteDetalleOrden/{id}

http://localhost:5102/RouteDetalleVenta/{id}

http://localhost:5102/RouteEmpleado/{id}

http://localhost:5102/RouteInsumo/{id}





# Examples

# HttpPost

Model - Empleado

```csharp
{
  "idEmp": 1,
  "nombre": "Jose",
  "idCargo": 1,
  "fechaIngreso": "2023-10-20",
  "idMunicipio": 3
}
```

# HttpPut{id}

```csharp
{
  "id": 10,
  "idEmp": 2,
  "nombre": "Pedro",
  "idCargo": 1,
  "fechaIngreso": "2023-10-20",
  "idMunicipio": 4
}
```

# HttpGet{id}

```csharp
{
  "id": 0,
  "idEmp": 0,
  "nombre": "string",
  "idCargo": 0,
  "fechaIngreso": "2023-10-20",
  "idMunicipio": 0
}
```

# HttpDelete{id}

```csharp
Response : NoContent
```
