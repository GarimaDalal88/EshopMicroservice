using BuildingBlocks.Behaviors;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddCarter();
var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
});
builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!);    
}).UseLightweightSessions();

builder.Services.AddValidatorsFromAssembly(assembly);

var app = builder.Build();

//configure the HTTP request pipeline.
app.MapCarter();

app.Run();
