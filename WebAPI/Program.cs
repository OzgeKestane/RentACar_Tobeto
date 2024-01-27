using Business.DependencyResolvers;
using Core.CrossCuttingConcerns.Exceptions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//ADDSINGLETON KISIMLARINI BUSÝNESSDA DEPENDECYRESOLVERS ÝÇERÝSÝNDE CLASS AÇARAK EKLEDÝK. 
// Add services to the container.
//ibrandservice istendiðinde, brandmanager ver
//builder.Services.AddSingleton<IBrandService, BrandManager>();
//Singleton: tek bir nesne oluþturur ve herkese onu verir.
//ek ödev diðer yöntemleri araþtýrýnýz.

//builder.Services.AddSingleton<IBrandDal, InMemoryBrandDal>();//Ibranddal isteyen heryerde, inmemorybranddal referansýný verecek. 1 kere newliyor aldýðý referansý uygulama hayatý boyunca kullanacak. 
//public static readonly IBrandDal BrandDal = new InMemoryBrandDal(); singleton karþýlýðý olarak bu. 
//builder.Services.AddSingleton<BrandBusinessRules>();
//addscoped
//builder.Services.AddScoped<Random>();new Random();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


//reflection yöntemiyle profile class'ýný kalýtým alan tüm classlarý bulur ve Automappera ekler
//ManageNuget Automapper microsoft dependencyinjection indirdik//Serviceregistration sildiðim için bu mapperlerý businesse (klasör) ekledik. 
//addTransient

builder.Services.AddBusinessServices(builder.Configuration);



//builder.Services.AddSingleton<IFuelService, FuelManager>();
//builder.Services.AddSingleton<IFuelDal, InMemoryFuelDal>();
//builder.Services.AddSingleton<BrandBusinessRules>();

//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
if (app.Environment.IsProduction())
    app.UseGlobalExceptionHandling();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.UseMiddleware<ExceptionMiddleware>();

app.Run();
