using ASP.NET_GraphQL.Schema;
using ASP.NET_GraphQL.Schema.Subscriptions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddInMemorySubscriptions();

var app = builder.Build();

app.UseRouting();
app.UseWebSockets();

app.MapGraphQL();

app.MapGet("/", () => "Hello World!");

app.Run();