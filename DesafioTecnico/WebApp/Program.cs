using Services;
using Services.Implementations;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Servicios que se agregan al contenedor
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ICountriesService, CountriesService>();
builder.Services.AddTransient<IBoroughsService, BoroughsService>();
builder.Services.AddTransient<ICondominiumsService, CondominiumsService>();
builder.Services.AddTransient<ICurrenciesService, CurrenciesService>();
builder.Services.AddTransient<IPropertyService, PropertyService>();
builder.Services.AddTransient<IRegionsService, RegionsService>();
builder.Services.AddTransient<ISectorsService, SectorsService>();
builder.Services.AddTransient<IAllPropertiesService, AllPropertiesService>();
builder.Services.AddSingleton<ApiService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
