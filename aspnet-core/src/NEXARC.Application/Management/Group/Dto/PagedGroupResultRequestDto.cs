using NEXARC.Domain.Enumerations;
using Abp.Application.Services.Dto;

namespace NEXARC.NexGroup.Dto
{
	public class PagedGroupResultRequestDto : PagedResultRequestDto
	{

		public string Keyword { get; set; }
		public RecordStatus? Status { get; set; }

	}
}
