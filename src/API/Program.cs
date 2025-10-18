using Scalar.AspNetCore;
using API.Extensions;
using Application;

// create the slim builder
var builder = WebApplication.CreateSlimBuilder(args);

// configure kestrel bindings
builder.WebHost.AddBindings();

// add all of the necessary services
builder.Services.AddApiServices();

// build the app
var app = builder.Build();
    
// add all of the API endpoints
app.MapApiEndpoints();

// use open api and scalar for development environments
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
}

// run the app
await app.RunAsync();