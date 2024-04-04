using RealEstateApp.Extensions;
using RealEstateApp.Assembly;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
.AddApplicationPart(typeof(AssemblyReference).Assembly);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.ConfigureRepositoryRegistration();

builder.Services.ConfigureServiceRegistration();
builder.Services.ConfigurRouting();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();



app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint =>
{
    endpoint.MapControllerRoute(
        name: "default"
        , pattern: "{controller=Home}/{action=Index}/{id?}"
        );
    endpoint.MapRazorPages();
    
    endpoint.MapControllers();
});


//Bu sayede migtaionlar otomatik güncellenicek
app.ConfigureAndCheckMigration();
app.ConfigureLocalization();

app.Run();


