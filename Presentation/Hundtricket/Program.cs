using Hundtricket.Context;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContextFactory<HundtricketContext>(options => options.UseSqlServer());
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<HundtricketContext>();

builder.Services.AddScoped<IDogRepository, DogRepository>();
builder.Services.AddScoped<IDogPicturesRepository, DogPicturesRepository>();

builder.Services.AddDbContext<HundtricketContext>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
