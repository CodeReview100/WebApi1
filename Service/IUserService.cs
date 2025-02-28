﻿using Entities;

namespace Service
{
    public interface IUserService
    {
        int checkPassword(string password);
        User createNewUser(User user);
        Task<string> getUserById(int id);
        Task<User> getUserByUserNameAndPassword(string UserName, string Password);
        Task update(int id, User userToUpdate);
    }
}