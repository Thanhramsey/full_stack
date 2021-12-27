using LOP_FULLSTACK.Services;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IPhotoService, PhotoService>();

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
app.Map("/use-middleware", (map) =>
 {
     map.Run(async (context) =>
     {
         var json = new
         {
             id = 1,
             name = "thanh",
             date = 10
         };
         var jsonStr = JsonConvert.SerializeObject(json);
         await context.Response.WriteAsync(jsonStr);
     });
 });
app.UseMiddleware<LOP_FULLSTACK.Middlewares.LogCenterMiddleware>();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
