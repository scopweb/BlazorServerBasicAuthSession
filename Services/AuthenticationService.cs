using Microsoft.AspNetCore.Components;

namespace Scp04.Services
{
    // Services/AuthenticationService.cs
    public interface IAuthenticationService
    {
        Task<bool> LoginAsync(string email, string password);
        Task LogoutAsync();
        bool IsAuthenticated();
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly ISessionService _sessionService;
        private readonly NavigationManager _navigationManager;

        public AuthenticationService(
            ISessionService sessionService,
            NavigationManager navigationManager)
        {
            _sessionService = sessionService;
            _navigationManager = navigationManager;
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            // Aquí implementarías tu lógica real de autenticación
            if (email == "admin@ejemplo.com" && password == "123456")
            {
                _sessionService.SetSession(email);
                return true;
            }
            return false;
        }

        public async Task LogoutAsync()
        {
            _sessionService.ClearSession();
            _navigationManager.NavigateTo("/login", true);
        }

        public bool IsAuthenticated()
        {
            return _sessionService.IsAuthenticated();
        }
    }

}