var builder = WebApplication.CreateBuilder(args); // initialize an instance of webapp builder class,
//sets up configuration,servcies of the webserver.
// Add services to the container.

builder.Services.AddControllers(); // mvc dependancy injection container with support for controllers.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // adding swagger

var app = builder.Build(); // creates a webapp instance 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())//This checks if the application is running in the Development environment.

{
    
    app.UseSwagger(); //This sets up the Swagger middleware to generate API documentation.
    app.UseSwaggerUI();//This enables the Swagger user interface (UI) where you can test API endpoints.
}

app.UseHttpsRedirection(); //redirects http to https

app.UseAuthorization(); // enables authorization middleware, [Authorize] is used
//authorized users are allowed to access that controller action.

app.MapControllers(); // enables routing API controllers, those using [ApiController]
//without this, controller endpoints won't work.

app.Run();// starts the program application
