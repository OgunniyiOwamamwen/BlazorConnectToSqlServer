﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SavaData<T>(string sql, T parameters);
    }
}