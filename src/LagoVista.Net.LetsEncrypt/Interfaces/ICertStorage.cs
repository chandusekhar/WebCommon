﻿using LagoVista.IoT.Logging.Loggers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LagoVista.Net.LetsEncrypt.Interfaces
{
    public interface ICertStorage
    {
        void Init(IAcmeSettings settings, IInstanceLogger instanceLogger);

        Task SetChallengeAndResponseAsync(string challenge, string response);
        Task<String> GetResponseAsync(string challenge);

        Task StoreCertAsync(string domainName, byte[] bytes);
        Task<byte[]> GetCertAsync(string domainName);
    }
}
