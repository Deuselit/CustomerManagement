using CustomerManagement.Components;
using Radzen;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CustomerManagement.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<CustomerManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerManagementContext") ?? throw new InvalidOperationException("Connection string 'CustomerManagementContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRadzenComponents();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
