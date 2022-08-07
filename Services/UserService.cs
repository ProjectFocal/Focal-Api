using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using Focal.Models;
using Focal.Services;

namespace Focal.Services {
    public class UserService {
        private readonly IMongoCollection<User> users;

        public UserService(IConfiguration config) {
            var client = new MongoClient(config.GetConnectionString("FocalDb"));
            var database = client.GetDatabase("FocalDb");
            users = database.GetCollection<User>("Users");
        }
        public List<User> GetUsers() => users.Find(user => true).ToList();
        public User GetUser(string id) => users.Find<User>(user => user.Id == id).FirstOrDefault();
        public User CreateUser(User user) {
            users.InsertOne(user);
            return user;
        }
    }
}