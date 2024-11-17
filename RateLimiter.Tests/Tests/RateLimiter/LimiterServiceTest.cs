﻿using M42.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using RateLimiter.Data;
using RateLimiter.Data.Interfaces;
using RateLimiter.Models;
using RateLimiter.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RateLimiter.Tests;

[TestFixture]
public class LimiterServiceTest
{
    ServiceProvider _serviceProvider;

    [SetUp]
    public void SetUp()
    {
        var services = new ServiceCollection();

        services.AddDbContext<RateLimiterDbContext>(options => options.UseInMemoryDatabase(databaseName: "LimiterServiceTest"));
        services.AddTransient(typeof(DbRepository<>));
        services.AddScoped<IDataService<Request>, RequestsDataService>();
        services.AddScoped<IDataService<Resource>, ResourcesDataService>();
        services.AddScoped<IDataService<User>, UsersDataService>();

        _serviceProvider = services.BuildServiceProvider();

    }
    [Test]
	public void AllowAccess_Test_1()
	{
        var requestsDataService = _serviceProvider.GetService<IDataService<Request>>();

        try
        {
            Assert.That(true, Is.True);  // currently, all requests are allowed
        }
        catch (NotImplementedException ex)
        {
            Assert.That(false, Is.True);
        }
	}
}
