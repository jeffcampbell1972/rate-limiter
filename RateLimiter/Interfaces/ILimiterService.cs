﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiter.Interfaces
{
    public interface ILimiterService
    {
        public Task<bool> LimitAccess(int ResourceId, int UserId);
    }
}
