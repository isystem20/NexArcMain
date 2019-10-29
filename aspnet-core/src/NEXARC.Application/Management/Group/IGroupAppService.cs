using Abp.Application.Services;
using NEXARC.NexGroup.Dto;

namespace NEXARC.NexGroup
{
	public interface IGroupAppService : IAsyncCrudAppService<GroupDto, int, PagedGroupResultRequestDto, CreateGroupDto, UpdateGroupDto>
	{

		//Put something if applicable

	}
}
