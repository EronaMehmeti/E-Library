using ELibrary.Models;
using Microsoft.EntityFrameworkCore;
using ELibrary.Interface;
using ELibrary.Services;
using ELibrary.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<LibraryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddCors(opt => {
    opt.AddPolicy("CorsPolicy", policy => {
        policy.AllowAnyMethod().AllowCredentials().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});


//builder.Services.AddTransient<StudentService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// lidhja e interfaces me services
builder.Services.AddScoped<IBorrowServices, BorrowSevices>();
builder.Services.AddScoped<IReservationServices, ReservationServices>();
builder.Services.AddScoped<IBookServices, BookServices>();
builder.Services.AddScoped<IMemberServices, MemberServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
