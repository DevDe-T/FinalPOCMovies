using finalPOCService.functionality;
using finalPOCService.service;
using finalPOCService.database;
using finalPOCService.Functionality;

var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddTransient<IFunctionality, UserOperations>();
builder.Services.AddTransient<IEmployeeFunctionality, EmployeeOperations>();
builder.Services.AddTransient<IMovieFunctionality, MovieOperations>();
builder.Services.AddCors();
 
var app = builder.Build();
 
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 
app.UseHttpsRedirection();
 
app.MapControllers();
app.UseCors(x => x
.AllowAnyHeader()
.AllowAnyMethod()
.AllowAnyOrigin()
);
app.Run();