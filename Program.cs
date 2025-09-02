var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// si usas http simple en 5252, puedes comentar UseHttpsRedirection si te molesta el redir
app.UseHttpsRedirection();

app.MapControllers();
app.Run();