using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NEXARC.Roles.Dto;
using NEXARC.Users.Dto;

namespace NEXARC.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
