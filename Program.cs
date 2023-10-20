using AdmissionProcess.Repository;
using AdmissionProcess.Repository.Interface;
using AdmissionProcess.Services;
using AdmissionProcess.Services.Interface;
using Microsoft.EntityFrameworkCore;
using AdmissionProcess.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:DefaultConnections").Value));
builder.Services.AddCors(options => options.AddDefaultPolicy(
				builder => builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()
			));

builder.Services.AddScoped<IAdmissionFormRepository, AdmissionFormRepository>();
builder.Services.AddScoped<IAdmissionFormServices, AdmissionFormServices>();
builder.Services.AddScoped<IFeeStructureRepository, FeeStructureRepository>();
builder.Services.AddScoped<IFeeStructureServices, FeeStructureServices>();
builder.Services.AddScoped<IRegistrationRepository, RegistrationRepository>();
builder.Services.AddScoped<IRegistrationServices, RegistrationServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors();
app.UseAuthorization();

app.MapControllers();


app.Run();