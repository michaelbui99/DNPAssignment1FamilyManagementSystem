﻿using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FamilyManagementRestApi.Repositories.Impl
{
    public class SqliteUsersRepository: IUsersRepository
    {
        private readonly UserDbContext _ctx;

        public SqliteUsersRepository(UserDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _ctx.Users.AddAsync(user);
            return user; 
        }

        public Task RemoveUserAsync(User user)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> GetUserAsync(string username)
        {
            return await _ctx.Users.FirstAsync(u => u.Username == username);
        }

        public Task<User> ValidateUserAsync(string username, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}