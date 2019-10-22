using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NEXARC.MultiTenancy.Dto;

namespace NEXARC.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

