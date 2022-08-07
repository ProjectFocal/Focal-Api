using MongoDB.Driver;


string connectionString = @"mongodb://projectfocaldb:o0CPmrmS67YVltFXv3wQ3Xd9XJPgXZvvWULXx3erfBdZk0mMtAI2VCshoxpAQ1I7VTcZY6GhGTeeLYlOJud1ZA==@projectfocaldb.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@projectfocaldb@";
MongoClientSettings settings = MongoClientSettings.FromUrl(
  new MongoUrl(connectionString)
);
var mongoClient = new MongoClient(settings);

builder.services.AddSingleton<IDatabaseSettings>(db => db.GetRequiredService<IOptions<DatabaseSettings>>().Value);

services.AddScoped<UserService>().

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}





app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
