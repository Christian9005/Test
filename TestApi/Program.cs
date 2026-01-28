var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();
app.MapOpenApi();

// Health endpoint
app.MapGet("/health", () => new 
{
    status = "healthy",
    timestamp = DateTime.UtcNow,
    app = "TestApi"
});

// Simple hello endpoint
app.MapGet("/hello", () => new 
{
    message = "Hello from TestApi!",
    timestamp = DateTime.UtcNow
});

app.Run();
