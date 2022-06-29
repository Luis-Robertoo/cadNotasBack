using CadNotas;
using CadNotas.Data;
using CadNotas.Models;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                          policy =>
                          {
                              policy.WithOrigins("http://localhost",
                                                  "http://localhost:8080")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});

var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);

app.MapGet("v1/produtos", (AppDbContext context) => {

    var produtos = context.Produtos.ToList(); 

    return Results.Ok(produtos);
});

app.MapPost("v1/enviando", (AppDbContext context, NotasPadrao nota) => {

    string prodComprados = "";
    foreach (var item in nota.produtos)
    {
        prodComprados += $"{item.id},";
    }

    Nota notaSave = new Nota();
    notaSave.canalCompra = nota.canalCompra;
    notaSave.produtosComprados = prodComprados;
    notaSave.valorNotaProdutos = nota.valorTotalNota;
    notaSave.CNPJ = nota.cnpj;
    notaSave.dataCompra = nota.dataCompra;
    notaSave.numCupom = nota.numNota;

    context.Notas.Add(notaSave);
    context.SaveChanges();

    return Results.Ok(notaSave);
});




app.Run();
