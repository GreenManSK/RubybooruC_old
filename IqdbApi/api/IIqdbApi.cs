﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace IqdbApi.api
{
    public interface IIqdbApi
    {
        Task<List<Match>> SearchFile(string path, Options options);
        Task<List<Match>> SearchUrl(string url, Options options);
    }
}