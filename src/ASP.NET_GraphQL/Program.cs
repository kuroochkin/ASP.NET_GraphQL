using ASP.NET_GraphQL.Schema;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.MapGet("/", () => "Hello World!");

app.Run();