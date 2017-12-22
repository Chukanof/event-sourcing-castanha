﻿namespace MyAccountAPI.Domain.Model.Accounts
{
    using System;
    using System.Threading.Tasks;

    public interface IAccountReadOnlyRepository
    {
        Task<Account> GetAccount(Guid accountId);
    }
}