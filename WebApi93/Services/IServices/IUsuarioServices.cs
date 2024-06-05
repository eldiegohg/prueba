using Domain.Entities;

namespace WebApi93.Services.IServices
{
    public interface IUsuarioServices
    {
        public Task<Response<List<Usuario>>> GetUsuarios();

        public Task<Response<Usuario>> Crear(UsuarioResponse request);
        public Task<Response<Usuario>> ById(int id);
        Task<Response<bool>> Eliminar(int id);
        Task<Response<Usuario>> Actualizar(int id, UsuarioResponse request);
    }
}
