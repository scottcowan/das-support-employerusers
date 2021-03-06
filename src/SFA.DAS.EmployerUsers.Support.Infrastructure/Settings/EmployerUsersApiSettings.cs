﻿using Sfa.Das.Console.Core.Services;
using SFA.DAS.EmployerUsers.Api.Client;

namespace SFA.DAS.EmployerUsers.Support.Infrastructure.Settings
{
    public class EmployerUsersApiSettings : IEmployerUsersApiConfiguration
    {
        private readonly IProvideSettings _settings;

        public EmployerUsersApiSettings(IProvideSettings settings)
        {
            _settings = settings;
        }

        public string ApiBaseUrl => _settings.GetSetting("EmpUserApiBaseUrl");
        public string ClientId => _settings.GetSetting("EmpUserApiClientId");
        public string ClientSecret => _settings.GetSetting("EmpUserApiClientSecret");
        public string IdentifierUri => _settings.GetSetting("EmpUserApiIdentifierUri");
        public string Tenant => _settings.GetSetting("EmpUserApiTenant");
        public string ClientCertificateThumbprint => _settings.GetNullableSetting("EmpUserApiCertificateThumbprint");
    }
}
