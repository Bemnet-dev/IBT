using Day59.Services.MenuItemServices;
using Day59.Services.RestaurantServices;
using Day59.Services.OrderServices;


using System.Reflection;
using System.IO;
using 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy =
    System.Text.Json.JsonNamingPolicy.CamelCase;

    options.JsonSerializerOptions.DefaultIgnoreCondition =
    System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1",new OpenApiInfo
    {
        Title="bkbv,hfvhf",
        Version="v1",
        Describtion="shdjhdfvhjdf"
    })
}
    );
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddCors(options =>
    options.AddPolicy("frontend", policy =>
            policy.WithOrigins("http://localhost:3000")
                  .AllowAnyMethod()
                  .AllowAnyHeader()));


//// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

//use is for middleware
app.UseHttpsRedirection();

//authenication and then 

app.UseAuthorization();

//app.UseCors("frontend");

app.MapControllers();

app.Run();
