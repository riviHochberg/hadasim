using Corona.BL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ExtensionsDI();
builder.Services.ExtensionDbContext(builder.Configuration["ConnectionString:myConnection"]);

builder.Services.AddControllers();

//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAll", p =>
//    {
//        p.AllowAnyOrigin()
//        .AllowAnyHeader()
//        .AllowAnyMethod();
//    });
//});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
