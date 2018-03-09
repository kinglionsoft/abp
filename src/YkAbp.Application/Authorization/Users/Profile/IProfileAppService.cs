﻿using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Authorization.Users.Dto;
using YkAbp.Application.Authorization.Users.Profile.Dto;
using YkAbp.Application.Users.Dto;

namespace YkAbp.Application.Authorization.Users.Profile
{
    public interface IProfileAppService : IApplicationService
    {
        Task<CurrentUserProfileEditDto> GetCurrentUserProfileForEdit();

        Task UpdateCurrentUserProfile(CurrentUserProfileEditDto input);
        
        Task ChangePassword(ChangePasswordInput input);

        Task UpdateProfilePicture(UpdateProfilePictureInput input);

        Task<GetPasswordComplexitySettingOutput> GetPasswordComplexitySetting();

        Task<GetProfilePictureOutput> GetProfilePicture();

        Task<GetProfilePictureOutput> GetProfilePictureById(Guid profilePictureId);

        Task<GetProfilePictureOutput> GetFriendProfilePictureById(GetFriendProfilePictureByIdInput input);

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task SendVerificationSms();

        Task VerifySmsCode(VerifySmsCodeInputDto input);
    }
}
