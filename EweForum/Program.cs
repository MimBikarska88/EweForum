using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EweForum.Data;
using EweForum.Infrastructure.Data.Models;
using System.Data.Services.Providers;
using System.Reflection;
using EweForum.Core.Services.Topic;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly(),true);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'EweForumContextConnection' not found.");


builder.Services.AddDbContext<EweForumContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddTransient<ITopicService, TopicService>();

builder.Services.AddDefaultIdentity<ForumUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.User.RequireUniqueEmail = true;



}).AddRoles<IdentityRole>()
  .AddEntityFrameworkStores<EweForumContext>();

// Add services to the container.
await builder.Services.BuildServiceProvider()
    .CreateScope()
    .ServiceProvider
    .CreateRoles(builder.Configuration);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    
});

await app.RunAsync();
