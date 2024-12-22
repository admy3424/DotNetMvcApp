// Application Builder
var builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddControllersWithViews();

// Build App
var app = builder.Build();

// Serve Static Files
app.UseStaticFiles();

// Enable Routing
app.UseRouting();

// Define Route Mapping
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Run App
app.Run();