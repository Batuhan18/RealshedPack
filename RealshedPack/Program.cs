using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using RealshedPack.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RealshedPackContext>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IAgentsService, AgentsManager>();
builder.Services.AddScoped<IAgentsDal, EfAgentsDal>();

builder.Services.AddScoped<IAmenitiesService, AmenitiesManager>();
builder.Services.AddScoped<IAmenitiesDal, EfAmenitiesDal>();

builder.Services.AddScoped<IContact_MessagesService, Contact_MessagesManager>();
builder.Services.AddScoped<IContact_MessagesDal, EfContact_MessagesDal>();

builder.Services.AddScoped<IPropertiesService, PropertiesManager>();
builder.Services.AddScoped<IPropertiesDal, EfPropertiesDal>();

builder.Services.AddScoped<ISettingsService, SettingsManager>();
builder.Services.AddScoped<ISettingsDal, EfSettingsDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialsManager>();
builder.Services.AddScoped<ITestimonialsDal, EfTestimonialsDal>();

builder.Services.AddAutoMapper(typeof(AboutMapping));
builder.Services.AddAutoMapper(typeof(AgentsMapping));
builder.Services.AddAutoMapper(typeof(AmenitiesMapping));
builder.Services.AddAutoMapper(typeof(Contact_MessagesMapping));
builder.Services.AddAutoMapper(typeof(PropertiesMapping));
builder.Services.AddAutoMapper(typeof(SettingsMapping));
builder.Services.AddAutoMapper(typeof(TestimonialMapping));



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
