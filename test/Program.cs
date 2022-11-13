using MongoDB.Driver;
using test_with_mongo.Models;

MongoUrl connectionString = new MongoUrl("mongodb+srv://erp-system:<YOUR_PASSWORD_GOES_HERE>@cluster0.fiotm.mongodb.net/?retryWrites=true&w=majority");
string databaseName = "YOUR_DATABASE_NAME_SHOULD_BE_CREATED_BEFORE";
string collectionName = "users";

MongoClient client = new MongoClient(connectionString);

IMongoDatabase db = client.GetDatabase(databaseName);
IMongoCollection<Usuario> collection = db.GetCollection<Usuario>(collectionName);

List<Usuario> users = new List<Usuario>() {
new Usuario(){ Name="Bill"},
new Usuario(){ Name="James"},
new Usuario(){ Name="Jonas"},
new Usuario(){ Name="Ryan"},
new Usuario(){ Name="Robb"},
new Usuario(){ Name="Joe"},
new Usuario(){ Name="Dennis"},
new Usuario(){ Name="Markus"},
new Usuario(){ Name="Iain"},
new Usuario(){ Name="Logan"},
};

await collection.InsertManyAsync(users);

var results = await collection.FindAsync(_ => true);

foreach (Usuario usuario in results.ToList())
{
    Console.WriteLine(value: $"{usuario.Id}: {usuario.Name}");
}