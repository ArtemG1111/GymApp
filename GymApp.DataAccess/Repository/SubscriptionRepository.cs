﻿

using GymApp.DataAccess.Data;
using GymApp.DataAccess.Interfaces;

namespace GymApp.DataAccess.Repository
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly GymAppContext _dbContext;
        public SubscriptionRepository(GymAppContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
