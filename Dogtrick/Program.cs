using Dogtrick.Areas.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Dogtrick.Hubs;
using Hundtricket.Context;
using Infrastructure.Repository;
using Infrastructure.Service;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Infrastructure.Overviews;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));
builder.Services.AddDbContextFactory<HundtricketContext>(options => options.UseSqlServer());
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<HundtricketContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();

builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});

builder.Services.AddSingleton<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();

builder.Services.AddScoped<IDogRepository, DogRepository>();
builder.Services.AddScoped<IDogFiltersRepository, DogFiltersRepository>();
builder.Services.AddScoped<IDogPicturesRepository, DogPicturesRepository>();
builder.Services.AddScoped<IUserHobbiesRepository, UserHobbiesRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserProfileRepository, UserProfileRepository>();
builder.Services.AddScoped<IUserPreferencesRepository, UserPreferencesRepository>();

builder.Services.AddScoped<IAddDogOverview, AddDogOverview>();
builder.Services.AddScoped<IDogParkOverview, DogParkOverview>();
builder.Services.AddScoped<IDogProfileOverview, DogProfileOverview>();
builder.Services.AddScoped<IEditProfileOverview, EditProfileOverview>();
builder.Services.AddScoped<IPrivateMessageOverview, PrivateMessageOverview>();
builder.Services.AddScoped<IViewUserProfileOverview, ViewUserProfileOverview>();

builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IMessageService, MessageService>();

builder.Services.AddDbContext<HundtricketContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseResponseCompression();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapHub<ChatHub>("chathub");
app.MapFallbackToPage("/_Host");

app.Run();
