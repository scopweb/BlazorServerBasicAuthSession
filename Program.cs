using Microsoft.AspNetCore.Components.Server.Circuits;
using Scp04.Services; 
using Scp04.Components;

var builder = WebApplication.CreateBuilder(args);

// Servicios básicos
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options => { options.DetailedErrors = true; });

// Cache y Session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Servicios de la aplicación - El orden es importante
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ISessionService, SessionService>();        // Primero SessionService
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>(); // Luego AuthenticationService

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Middleware en orden específico
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();