using Microsoft.Extensions.Configuration;
using PM.Core.Infrastructure;
using PM.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IPmStartup, ServicesConfiguration>();
// Add services to the container
//ServicesConfiguration.ConfigureServices(builder.Services, builder.Configuration);
//builder.Services.AddDbContext<DBTaskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Create a list of IServiceConfiguration implementations
var serviceConfigurations = new List<IPmStartup>
            {
                new ServicesConfiguration(),
                //new RazorPagesServiceConfiguration()
                // Add more configurations as needed
            };

// Call ConfigureServices for each service configuration class
foreach (var serviceConfig in serviceConfigurations)
{
    serviceConfig.ConfigureServices(builder.Services, builder.Configuration);
}


// Add services to the container.
builder.Services.AddControllersWithViews();

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
