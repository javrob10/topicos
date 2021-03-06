﻿using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWInd.BL.Interfaces;
using Topicos.NorthWind.BaseDatos.Models;

namespace Topicos.NorthWInd.BL.Services
{
    public class Products : IProducts
    {
        public NorthWind.BaseDatos.Models.Products ObtenerProductosPorId(int id)
        {
            NorthWind.BaseDatos.Models.Products elResultado;
            var laAccion = new Acciones.Products();
            elResultado = laAccion.ObtenerProductosPorId(id);
            return elResultado;
        }

        public ICollection<NorthWind.BaseDatos.Models.Products> ObtenerProductosPorNombreAproximado(string nombreProducto)
        {
            throw new NotImplementedException();
        }

        public ICollection<NorthWind.BaseDatos.Models.Products> ObtenerProductosPorRangoDePrecio(decimal? precioMinimo, decimal? precioMaximo)
        {
            throw new NotImplementedException();
        }
    }
}
