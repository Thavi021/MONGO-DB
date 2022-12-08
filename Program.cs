using System;
using MongoDB.Driver;
using MongoDBapplication;

string connectionString = "mongodb://localhost:27017";
string databaseName = "simple_db";
string collectionName = "people";
var client = new MongoClient(connectionString);
var db = client.GetDatabase(databaseName);
var collection = db.GetCollection<PersonModel>(collectionName);

var person = new PersonModel { FirstName = "Thaveshan", LastName ="Naidoo"};

await collection.InsertOneAsync(person);

var results = await collection.FindAsync( _=> true);

foreach(var result in results.ToList())
{
    Console.WriteLine(value: $"{result.Id}:{result.FirstName}{result.LastName}");
}
//https://www.youtube.com/watch?v=exXavNOqaVo
//stopped at 15 minutes
