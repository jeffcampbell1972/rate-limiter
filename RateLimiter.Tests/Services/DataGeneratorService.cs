﻿using RateLimiter.Data.Models.Data;
using RateLimiter.Models;
using RateLimiter.Tests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiter.Tests.Services
{
    internal class DataGeneratorService : IDataGeneratorService
    {
        public Request GenerateRequest(int id, Resource resource, User user, string identifier, bool wasHandled)
        {
            var request = new Request
            {
                Id = id,
                Identifier = identifier,
                RequestDate = DateTime.Now,
                Resource = resource,
                User = user,
                WasHandled = wasHandled,
                CreatedBy = "DataGenerator",
                CreatedDate = DateTime.Now
            };

            return request;
        }
        public Resource GenerateResource(int id, string name, Status status)
        {
            var resource = new Resource
            {
                Id = id,
                Identifier = name,
                Name = name,
                Description = name,
                Status = status,
                CreatedBy = "DataGenerator",
                CreatedDate = DateTime.Now
            };

            return resource;
        }
        public User GenerateUser(int id, string username, Guid token, string tokenSource)
        {
            var user = new User
            {
                Id = id,
                Identifier = username,
                Name = username,  
                Token = token.ToString(),
                TokenSource = tokenSource,
                Email = string.Format("{0}@phonyEmail.com", username),
                CreatedBy = "DataGenerator",
                CreatedDate = DateTime.Now
            };

            return user;
        }
        public LimiterRule GenerateLimiterRule(int id, string name, string? tokenSource, int? resourceStatusId, int numPerTimespan, int numSeconds)
        {
            var limiterRule = new LimiterRule
            {
                Id = id ,
                Identifier = name ,
                Name = name ,
                TokenSource = tokenSource ,
                ResourceStatusId = resourceStatusId ,
                NumPerTimespan = numPerTimespan ,
                NumSeconds = numSeconds,
                CreatedBy = "DataGenerator",
                CreatedDate = DateTime.Now
            };

            return limiterRule;
        }
    }
}
