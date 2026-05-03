//using Application.Faq;
using Infrastructure;
using Infrastructure.Data;
using Infrastructure.Extensions;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddInfrastructure(builder.Configuration, builder.Environment);

builder.Services.AddSession();
builder.Services.AddRouting(x => x.LowercaseUrls = true);

builder.Services.AddDbContext<PersistenceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));


//builder.Services.AddScoped<IFaqService, FaqService>();

var app = builder.Build();

app.UseHsts();
app.UseHttpsRedirection();
app.UseRouting();

app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.UseStatusCodePagesWithReExecute("/error/{0}");

app.MapStaticAssets();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

await InfrastructureInitializer.InitializeAsync(app.Services);

app.Run();