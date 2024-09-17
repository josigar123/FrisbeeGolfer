using MongoDB.Driver;
using MongoDB.Bson;

var builder = WebApplication.CreateBuilder(args);

InitializeMongoDbClient(builder);

// Add services to the container.
builder.Services.AddControllers();
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
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
return;

void InitializeMongoDbClient(WebApplicationBuilder builder)
{
    var connectionUri = builder.Configuration.GetSection("MongoDb")["ConnectionUri"];
    var databaseName = builder.Configuration.GetSection("MongoDb")["DatabaseName"];
    var settings = MongoClientSettings.FromConnectionString(connectionUri);

    var mongoClient = new MongoClient(settings);
    
    try {
        var result = mongoClient.GetDatabase(databaseName).RunCommand<BsonDocument>(new BsonDocument("ping", 1));
        Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
        builder.Services.AddSingleton(mongoClient);

    } catch (Exception ex) {
        Console.WriteLine(ex);
    }
}