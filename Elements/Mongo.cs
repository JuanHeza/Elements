using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System.Drawing;

namespace Elements
{
    class Mongo
    {
        static IMongoDatabase DataBase;
        /* static public void TestA()
        {
            Console.WriteLine("testing mongo");
            try
            {
                MongoClient dbClient = new MongoClient("mongodb://127.0.0.1:27017");

                //Database List  
                var dbList = dbClient.ListDatabases().ToList();

                Console.WriteLine("The list of databases are :");
                foreach (var item in dbList)
                {
                    Console.WriteLine(item);
                    Form1.Instance.metroHome.Text = item.ToString();
                }

                Console.WriteLine("\n\n");

                //Get Database and Collection  
                IMongoDatabase db = dbClient.GetDatabase("test");
                var collList = db.ListCollections().ToList();
                Console.WriteLine("The list of collections are :");
                foreach (var item in collList)
                {
                    Console.WriteLine(item);
                }

                var things = db.GetCollection<BsonDocument>("things");

                //CREATE  
                BsonElement personFirstNameElement = new BsonElement("PersonFirstName", "Sankhojjal");

                BsonDocument personDoc = new BsonDocument();
                personDoc.Add(personFirstNameElement);
                personDoc.Add(new BsonElement("PersonAge", 23));

                things.InsertOne(personDoc);

                //UPDATE  
                BsonElement updatePersonFirstNameElement = new BsonElement("PersonFirstName", "Souvik");

                BsonDocument updatePersonDoc = new BsonDocument();
                updatePersonDoc.Add(updatePersonFirstNameElement);
                updatePersonDoc.Add(new BsonElement("PersonAge", 24));

                BsonDocument findPersonDoc = new BsonDocument(new BsonElement("PersonFirstName", "Sankhojjal"));

                var updateDoc = things.FindOneAndReplace(findPersonDoc, updatePersonDoc);

                Console.WriteLine(updateDoc);

                //DELETE  
                BsonDocument findAnotherPersonDoc = new BsonDocument(new BsonElement("PersonFirstName", "Sourav"));

                things.FindOneAndDelete(findAnotherPersonDoc);

                //READ  
                var resultDoc = things.Find(new BsonDocument()).ToList();
                foreach (var item in resultDoc)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Console.ReadKey();
        }
        */
        /* static public void Test() {
            Console.WriteLine("MONGO");
          //Insert();
            //MainAsync().Wait();
            Console.WriteLine("ByeBye");

        }
        */
        /* static async Task MainAsync()
        {
            var connectionstring = "mongodb://localhost:27017";
            //puede ir sin string pero ira por default a la ruta de arriba
            var client = new MongoClient(connectionstring);
            Console.WriteLine("MongoCreado");
            IMongoDatabase DB = client.GetDatabase("Contenido");
            var collection = DB.GetCollection<BsonDocument>("Elementos");
            //var documento = CreateManyElementos();
            var documento = new BsonDocument
            {
                {"Padre", BsonValue.Create("Juan")},
                {"Nombre", new BsonString("Emma") },
                {"Hijos", new BsonArray(new [] {"Becky","Lexi"}) }
            };
            Console.WriteLine(documento);
            collection.InsertOne(documento);
            //await collection.InsertOneAsync(documento);
        }
*/
        public static void Conect()
        {
            var connectionstring = "mongodb://localhost:27017";
            //puede ir sin string pero ira por default a la ruta de arriba
            MongoClient Client = new MongoClient(connectionstring);
            Mongo.DataBase = Client.GetDatabase("Elements");
            Mongo.InitializePath();
        }

        #region Directories
        public static void AddPath(string Id, string path) {
            bool exist = false;
            var collection = Mongo.DataBase.GetCollection<BsonDocument>("Local");
            var Dirs = collection.Find(new BsonDocument("Type", "Directories"));
            foreach (var dir in Dirs.ToList())
            {
                var X = dir[Id].AsBsonArray.ToList();
                foreach(var PT in X)
                {
                    if (path == PT)
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    X.Add(BsonValue.Create(path));
                    var documento = dir;
                    documento[Id] = new BsonArray(X);
                    var old = Builders<BsonDocument>.Filter.Eq("_id", dir["_id"]);
                    var update = Builders<BsonDocument>.Update.Set("Created", DateTime.UtcNow);
                    foreach (BsonElement item in documento)
                    {
                        update = update.Set(item.Name, item.Value);
                    }
                    Console.WriteLine(old);
                    collection.UpdateOne(old, update);
                    Contenido.DirMap[Id].Add(path);
                }
                else
                {
                    Console.WriteLine("La direccion ya existe");
                    break;
                }
            }
        }
       
        public static bool Exist(string Nombre)
        {
            var collection = Mongo.DataBase.GetCollection<BsonDocument>("Contenido");
            var Dirs = collection.Find(new BsonDocument("Nombre", Nombre));
            return Dirs.ToList().Count > 0;
        }

        public static void InitializePath()
        {
            Contenido.InitDir();
            var collection = Mongo.DataBase.GetCollection<BsonDocument>("Local");
            var Data = collection.Find(new BsonDocument("Type", "Directories"));
            if (Data.ToList().Count < 1)
            {
                var documento = new BsonDocument
                {
                    {"Type", BsonValue.Create("Directories")},
                    {"Comic", new BsonArray(new List<string>())},
                    {"Music", new BsonArray(new List<string>())},
                    {"Video", new BsonArray(new List<string>())},
                    {"Ebook", new BsonArray(new List<string>())}
                };
                collection.InsertOne(documento);
            }
            else
            {
                foreach (var dir in Data.ToList())
                {
                    foreach (var val in dir["Comic"].AsBsonArray.ToList())
                        Contenido.DirMap["Comic"].Add(val.AsString);

                    foreach (var val in dir["Ebook"].AsBsonArray.ToList())
                        Contenido.DirMap["Ebook"].Add(val.AsString);

                    foreach (var val in dir["Video"].AsBsonArray.ToList())
                        Contenido.DirMap["Video"].Add(val.AsString);

                    foreach (var val in dir["Music"].AsBsonArray.ToList())
                        Contenido.DirMap["Music"].Add(val.AsString);
                }
            }
        }

        public static void AddNew(BsonDocument Input, string Table)
        {
            var collection = Mongo.DataBase.GetCollection<BsonDocument>(Table);
            collection.InsertOne(Input);
        }

        public static void Update(BsonDocument Input, string Table)
        {
            var collection = Mongo.DataBase.GetCollection<BsonDocument>(Table);
            var old = Builders<BsonDocument>.Filter.Eq("Nombre", Input["Nombre"]);
            var update = Builders<BsonDocument>.Update.Set("Created", DateTime.UtcNow);
            foreach (var Item in Input)
                update = update.Set(Item.Name, Item.Value);
            collection.UpdateOne(old, update);
        }

#endregion

        #region Comic

        public static void InsertComic(List<Comic> input)
        {
            var collection = Mongo.DataBase.GetCollection<BsonDocument>("Comic");
            var newdocs = new List<BsonDocument>();
            foreach( Comic data in input)
            {
                newdocs.Add(data.ToBsonDocument());
            }
        }
        
        public static Comic GetComicData()
        {
            Comic data = null;
            return data;
        }

        public static void UpdateComic(Comic Update)
        {

        }

        public static void UpdateCover(string comic, Image cover)
        {
            var collection = Mongo.DataBase.GetCollection<BsonDocument>("Comic");
            var Dirs = collection.Find(new BsonDocument("Name", comic));
            foreach (var dir in Dirs.ToList())
            {
                var documento = dir;
                documento["Cover"] = BsonValue.Create(cover);
                Console.WriteLine("old {0} \n new {1}", dir, documento);
                var old = Builders<BsonDocument>.Filter.Eq("_id", dir["_id"]);
                var update = Builders<BsonDocument>.Update.Set("Created", DateTime.UtcNow);
                foreach (BsonElement item in documento)
                {
                    update = update.Set(item.Name, item.Value);
                }
                Console.WriteLine(old);
                collection.UpdateOne(old, update);
            }
        }

        #endregion
        /* static void Insert()
        {
            var connectionstring = "mongodb://localhost:27017";
            //puede ir sin string pero ira por default a la ruta de arriba
            var client = new MongoClient(connectionstring);
            Console.WriteLine("MongoCreado");
            IMongoDatabase DB = client.GetDatabase("Contennido");
            var collection = DB.GetCollection<BsonDocument>("Elementos");
            //var documento = CreateManyElementos();
            var documento = new BsonDocument
            {
                {"Padre", BsonValue.Create("Juan")},
                {"Nombre", new BsonString("Emma") },
                {"Hijos", new BsonArray(new [] {"Becky","Lexi"}) }
            };
            Console.WriteLine(documento);
            collection.InsertOne(documento);
            //collection.InsertMany();
            //await collection.InsertOneAsync(documento);
        }
        */
        /* Private static IEnumerable<BsonDocument> CreateManyElementos(){
            var D1 = new BsonDocument
            {
                {"Padre", BsonValue.Create("Juan")},
                {"Nombre", new BsonString("Emma") },
                {"Hijos", new BsonArray(new [] {"Becky","Lexi"}) }
            };
            var D2 = new BsonDocument
            {
                {"Padre", BsonValue.Create("Juan")},
                {"Nombre", new BsonString("Emma") },
                {"Hijos", new BsonArray(new [] {"Becky","Lexi"}) }
            };
            var D3 = new BsonDocument
            {
                {"Padre", BsonValue.Create("Juan")},
                {"Nombre", new BsonString("Emma") },
                {"Hijos", new BsonArray(new [] {"Becky","Lexi"}) }
            };
            var newdocs = new List<BsonDocument>();
            newdocs.Add(D1);
            newdocs.Add(D2);
            newdocs.Add(D3);

            return newdocs;
         }
         */
    }
}
