using BLL.Finders;
using BLL.Repositories;
using BLL.Services;
using BLL.UnitOfWork;
using DAL;
using DAL.Finders;
using DAL.Repositories;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Web.API.AutoMapper;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").AddEnvironmentVariables();
// Add services to the container.
builder.Services.AddControllers();
// Получаю строку подключения
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Контекст
builder.Services.AddDbContext<WebContext>(options => options.UseSqlServer(connection));

builder.Services.AddTransient<IRepository<BLL.Entities.Photo>, Repository<BLL.Entities.Photo>>();
builder.Services.AddTransient<Finder<BLL.Entities.Photo>>();
builder.Services.AddTransient<IPhotoFinder, PhotoFinder>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IPhotoService, PhotoService>();

builder.Services.AddTransient<IRepository<BLL.Entities.Text>, Repository<BLL.Entities.Text>>();
builder.Services.AddTransient<Finder<BLL.Entities.Text>>();
builder.Services.AddTransient<ITextFinder, TextFinder>();
builder.Services.AddScoped<ITextService, TextService>();

builder.Services.AddTransient<IRepository<BLL.Entities.Author>, Repository<BLL.Entities.Author>>();
builder.Services.AddTransient<Finder<BLL.Entities.Author>>();
builder.Services.AddTransient<IAuthorService, AuthorService>();
builder.Services.AddTransient<IAuthorFinder, AuthorFinder>();


builder.Services.AddAutoMapper(typeof(AuthorProfile), typeof(PhotoProfile), typeof(TextProfile));

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
