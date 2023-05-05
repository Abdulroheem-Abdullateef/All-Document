using System.Configuration;
using KpiNew.Context;
using KpiNew.Implementation.Repository;
using KpiNew.Implementation.Service;
using KpiNew.Interface;
using KpiNew.Interface.Repository;
using KpiNew.Interface.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

 var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationContext>(option =>
 option.UseMySQL(builder.Configuration.GetConnectionString("ApplicationContext")));


builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<EmployeeService, EmployeeService>();

 builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
 builder.Services.AddScoped<IDepartmentService, DepartmentService>();


 builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
 builder.Services.AddScoped<IDepartmentService, DepartmentService>();

 builder.Services.AddScoped<IKpiRepository, KpiRepository>();
 builder.Services.AddScoped<IKpiService, KpiService>();

 builder.Services.AddScoped<IRoleRepository, RoleRepository>();
 builder.Services.AddScoped<IRoleService, RoleService>();

 builder.Services.AddScoped<IUserRepository, UserRepository>();
 builder.Services.AddScoped<IUserService, UserService>();



builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(config =>
            {
                config.LoginPath = "/User/Login";
                config.Cookie.Name = "KpiApp";
                config.LogoutPath = "/User/Logout";
            });

builder.Services.AddAuthorization(); 


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
