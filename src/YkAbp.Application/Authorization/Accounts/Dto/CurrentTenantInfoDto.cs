﻿using Abp.Application.Services.Dto;

namespace YkAbp.Application.Authorization.Accounts.Dto
{
    //### This class is mapped in CustomDtoMapper ###
    public class CurrentTenantInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}