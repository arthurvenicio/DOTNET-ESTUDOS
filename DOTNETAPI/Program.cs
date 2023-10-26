using DOTNETAPI.SERVICES;
using DOTNETAPI.MODELS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigureService(builder);

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


void ConfigureService(WebApplicationBuilder builder){
    builder.Services.AddControllers();
    builder.Services.AddLogging();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddTransient<ISumService, SumService>();
    builder.Services.AddTransient<ICepService, CepService>();
    builder.Services.AddHttpClient<ICepService, CepService>();
}
