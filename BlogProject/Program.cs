using BlogProject.Models.Repositories.Abstract;
using BlogProject.Models.Repositories.Concrete;
using MVC_BlogProject.Models.Context;
using MVC_BlogProject.Models.Repositories.Abstract;
using MVC_BlogProject.Models.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// veri tabaný kaydý
builder.Services.AddDbContext<BlogDbContext>();


// Repository'yi DI konteynerine ekliyoruz
builder.Services.AddScoped<IArticleRepo, ArticleRepository>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepository>();
builder.Services.AddScoped<ITagRepo, TagRepository>();
builder.Services.AddScoped<IAboutRepo, AboutRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
