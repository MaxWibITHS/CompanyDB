using Company.Common.DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CompanyContext>(
options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("CompanyConnection")));
builder.Services.AddSwaggerGen();

ConfigureAutoMapper(builder.Services);
ConfigureServices(builder.Services);

var app = builder.Build();

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


void ConfigureAutoMapper(IServiceCollection services)
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<CompanyClass, CompanyClassDTO>().ReverseMap();
        cfg.CreateMap<Department, DepartmentDTO>().ReverseMap();
        cfg.CreateMap<Employee, EmployeeDTO>().ReverseMap();
        cfg.CreateMap<EmployeePosition, EmployeePositionDTO>().ReverseMap();
        cfg.CreateMap<Position, PositionDTO>().ReverseMap();
    });

    var mapper = config.CreateMapper();
    services.AddSingleton(mapper);
}

void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IDbService, DbService>();
}