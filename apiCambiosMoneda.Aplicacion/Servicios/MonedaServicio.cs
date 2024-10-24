﻿using apiCambiosMoneda.Core.Interfaces.Repositorios;
using apiCambiosMoneda.Core.Interfaces.Servicios;
using apiCambiosMoneda.Dominio.Entidades;

namespace apiCambiosMoneda.Aplicacion.Servicios
{
    public class MonedaServicio : IMonedaServicio
    {
        private readonly IMonedaRepositorio repositorio;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositorio"></param>
        public MonedaServicio(IMonedaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        /// <summary>
        /// Listar todas las monedas
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Moneda>> ObtenerTodos()
        {
            return await repositorio.ObtenerTodos();
        }
        /// <summary>
        /// Obtener datos de moneda especifica
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Moneda> Obtener(int Id)
        {
           return await repositorio.Obtener(Id);
        }
        /// <summary>
        /// Buscar una moneda
        /// </summary>
        /// <param name="Tipo"></param>
        /// <param name="Dato"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Moneda>> Buscar(int Tipo, string Dato)
        {
            return await repositorio.Buscar(Tipo, Dato);
        }
        /// <summary>
        /// Agregar una nueva moneda
        /// </summary>
        /// <param name="Moneda"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Moneda> Agregar(Moneda Moneda)
        {
            return await repositorio.Agregar(Moneda);
        }
        /// <summary>
        /// Modificar datos de una moneda
        /// </summary>
        /// <param name="Moneda"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Moneda> Modificar(Moneda Moneda)
        {
            return await repositorio.Modificar(Moneda);
        }
        /// <summary>
        /// Eliminar una moneda
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> Eliminar(int Id)
        {
            return await repositorio.Eliminar(Id);
        }

        /********** CAMBIOS **********/

        public Task<IEnumerable<CambioMoneda>> ObtenerCambios(int IdMoneda)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CambioMoneda>> BuscarCambio(int Tipo, string Dato)
        {
            throw new NotImplementedException();
        }

        public Task<Moneda> AgregarCambio(CambioMoneda Cambio)
        {
            throw new NotImplementedException();
        }

        public Task<Moneda> ModificarCambio(CambioMoneda Cambio)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarCambio(int IdMoneda, DateTime Fecha)
        {
            throw new NotImplementedException();
        }

        /********** CONSULTAS **********/

        public Task<CambioMoneda> ObtenerCambioActual(int idMoneda)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CambioMoneda>> ObtenerHistorialCambios(int idMoneda, DateTime desde, DateTime hasta)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pais>> ObtenerPaisesPorMoneda(int idMoneda)
        {
            throw new NotImplementedException();
        }

    }
}
