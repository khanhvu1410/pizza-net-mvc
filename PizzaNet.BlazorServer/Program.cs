using Microsoft.EntityFrameworkCore;
using PizzaNet.Application.Interfaces;
using PizzaNet.Application.Services;
using PizzaNet.BlazorServer.Components;
using PizzaNet.Domain.Interfaces;
using PizzaNet.Persistence;
using PizzaNet.Persistence.Repositories;

namespace PizzaNet.BlazorServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddDbContext<PizzaNetDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("PizzaNetDbConnection")));

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<ICategoryService, CategoryService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
