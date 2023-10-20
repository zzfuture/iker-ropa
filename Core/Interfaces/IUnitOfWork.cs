using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        public ICargo Cargos { get;}
        public ICliente Clientes { get;}
        public IColor Colores { get;}
        public IDepartamento Departamentos { get;}
        public IDetalleOrden DetalleOrdenes { get;}
        public IDetalleVenta DetalleVentas { get;}
        public IEmpleado Empleados { get;}
        public IEmpresa Empresas { get;}
        public IEstado Estados { get;}
        public IFormaPago FormaPagos { get;}
        public IGenero Generos { get;}
        public IInsumo Insumos { get;}
        public IInventario Inventarios { get;}
        public IMunicipio Municipios { get;}
        public IOrden Ordenes { get;}
        public IPais Paises { get;}
        public IPrenda Prendas { get;}
        public IProveedor Proveedores { get;}
        public ITalla Tallas { get;}
        public ITipoEstado TipoEstados { get;}
        public ITipoPersona TipoPersonas { get;}
        public ITipoProteccion TipoProtecciones { get;}
        public IVenta Ventas { get;}
        Task<int> SaveAsync();
    }
}

