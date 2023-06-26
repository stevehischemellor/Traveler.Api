using Traveler.Api.Filters;
using Traveler.Api.Middleware;
using Traveler.Services.Journal;
using Traveler.Services.Photo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<MvcRequestLoggingFilter>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add project business services
builder.Services.AddPhotoService();
builder.Services.AddJournalService();

var app = builder.Build();

app.UseHttpLogging();

// Add middleware
app.UseMiddleware<RequestLoggingMiddleware>();


//
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
