using DxBlazorApplication1.Services;
using DxBlazorApplication1.Components;
using DxBlazorApplication1.Services.Interfaces;
using ServiceLayer.Implementations.InMemory;
using DxBlazorApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDevExpressBlazor(options => {
    options.SizeMode = DevExpress.Blazor.SizeMode.Medium;
});

builder.Services.AddSingleton<IAppointmentService<UniversityClass>, InMemoryAppointmentService>();
builder.Services.AddSingleton<IResourceService<Lecturer>, InMemoryResourceService>();
builder.Services.AddSingleton<ILabelService<LectureType>, InMemoryLabelService>();
builder.Services.AddSingleton<IStatusService<LectureStatus>, InMemoryStatusService>();

builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AllowAnonymous();

app.Run();