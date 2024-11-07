using modeltest.Profiles;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using modeltest.Interfaces;
using modeltest.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddAutoMapper(typeof(mapProfiles));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 
builder.Services.AddDbContext<DatabaseContext>(option => option.UseSqlServer("server=IN0SMANTRI1;database=testing; Integrated security=true; TrustServerCertificate=True"));

builder.Services.AddScoped<Idbcontext,DatabaseContext>();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader(); 
                      });
});
var app = builder.Build();


app.UseCors(MyAllowSpecificOrigins);
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
