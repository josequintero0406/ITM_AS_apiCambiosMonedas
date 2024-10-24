using apiCambiosMoneda.Core.Interfaces.Repositorios;
using apiCambiosMoneda.Dominio.Entidades;
using apiCambiosPais.Core.Interfaces.Servicios;

namespace apiCambiosMoneda.Aplicacion.Servicios
{
    public class PaisServicio : IPaisServicio
    {
        private readonly IPaisRepositorio repositorio;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositorio"></param>
        public PaisServicio(IPaisRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        /// <summary>
        /// Obtener pais
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Pais> Obtener(int Id)
        {
            return await repositorio.Obtener(Id);
        }
        /// <summary>
        /// Listar todos los paises
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Pais>> ObtenerTodos()
        {
            return await repositorio.ObtenerTodos();
        }
        /// <summary>
        /// Buscar Pais
        /// </summary>
        /// <param name="Tipo"></param>
        /// <param name="Dato"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Pais>> Buscar(int Tipo, string Dato)
        {
            return await repositorio.Buscar(Tipo, Dato);
        }
        /// <summary>
        /// Agregar pais
        /// </summary>
        /// <param name="Pais"></param>
        /// <returns></returns>
        public async Task<Pais> Agregar(Pais Pais)
        {
            return await repositorio.Agregar(Pais);
        }
        /// <summary>
        /// Modificar pais
        /// </summary>
        /// <param name="Pais"></param>
        /// <returns></returns>
        public async Task<Pais> Modificar(Pais Pais)
        {
            return await repositorio.Modificar(Pais);
        }
        /// <summary>
        /// Eliminar pais
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<bool> Eliminar(int Id)
        {
            return await repositorio.Eliminar(Id);
        }
    }
}
