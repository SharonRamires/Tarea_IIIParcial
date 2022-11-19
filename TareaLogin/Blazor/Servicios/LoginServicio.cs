using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorio;
using Modelos;
using Org.BouncyCastle.Security;

namespace Blazor.Servicios
{
    public class LoginServicio : ILoginServicio
    {
        private readonly Config _configuracion;
        private ILoginRepositorio loginRepositorio;

        public LoginServicio(Config config)
        {
            _configuracion = config;
            loginRepositorio = new LoginRepositorio(config.CadenaConexion);
        }

        public async Task<bool> ValidarUsuario(Login login)
        {
            return await loginRepositorio.ValidarUsuario(login);
        }
    }
}
