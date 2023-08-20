﻿using Domain.Model;

namespace Application.InterfaceQuery
{
    public interface IUserApplication
    {
        List<User> GetAllUser();
        User GetUserById(Guid id);

        bool CreateUser(User user);
    }
}