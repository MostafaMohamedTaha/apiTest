#region default builder


var builder = WebApplication.CreateBuilder(args);
#endregion

// Add services to the container.
#region default services

builder.Services.AddControllers();

#endregion

#region new service

#endregion

#region default app swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endregion

#region default middle ware

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); //routing all
#endregion

#region new middle ware

#endregion

app.Run();
