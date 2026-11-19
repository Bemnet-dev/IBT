using Day55.Services.MenuItemServices;
using Day55.Services.RestaurantServices;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();

//builder.Services.AddCors(options =>
//    options.AddPolicy("frontend", policy=>
//            policy.WithOrigins("http://localhost:3000")
//                  .AllowAnyMethod()
//                  .AllowAnyHeader()));


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
