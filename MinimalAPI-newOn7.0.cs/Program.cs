using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ===== ===== ===== ===== =====
// 配列へのバインディング
// ===== ===== ===== ===== =====

// Bind query string values to a primitive type array.
// GET  /tags?q=1&q=2&q=3
app.MapGet("/tags", (int[] q) => $"tag1: {q[0]} , tag2: {q[1]}, tag3: {q[2]}");

// Bind to a string array.
// GET /tags2?names=john&names=jack&names=jane
app.MapGet("/tags2", (string[] names) => $"tag1: {names[0]} , tag2: {names[1]}, tag3: {names[2]}");

// Bind to StringValues.
// GET /tags3?names=john&names=jack&names=jane
app.MapGet("/tags3", (StringValues names) => $"tag1: {names[0]} , tag2: {names[1]}, tag3: {names[2]}");

// ===== ===== ===== ===== =====
// マッピンググループ
// ===== ===== ===== ===== =====

var todo = app.MapGroup("/todo");
todo.MapGet("/A", () => new[] { "A1", "A2", "A3" });
todo.MapGet("/B", () => new[] { "B1", "B2", "B3" });
todo.MapGet("/C", () => new[] { "C1", "C2", "C3" });

app.Run();
