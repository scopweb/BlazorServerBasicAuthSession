using Microsoft.AspNetCore.Components;

namespace Scp04.Services
{

    // Services/ISessionService.cs
    // Services/ISessionService.cs
    public interface ISessionService
    {
        void SetSession(string email);
        string GetSession();
        void ClearSession();
        bool IsAuthenticated();
    }

    // Services/SessionService.cs
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string SessionKey = "UserEmail";

        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetSession(string email)
        {
            var context = _httpContextAccessor.HttpContext;
            if (context == null)
                throw new InvalidOperationException("HttpContext is not available");

            context.Session.SetString(SessionKey, email);
        }

        public string GetSession()
        {
            return _httpContextAccessor.HttpContext?.Session.GetString(SessionKey) ?? string.Empty;
        }

        public void ClearSession()
        {
            _httpContextAccessor.HttpContext?.Session.Clear();
        }

        public bool IsAuthenticated()
        {
            return !string.IsNullOrEmpty(GetSession());
        }
    }
}
