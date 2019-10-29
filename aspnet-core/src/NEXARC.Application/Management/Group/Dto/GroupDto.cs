using NEXARC.Domain.Entities.HumanResource;
using NEXARC.Domain.Enumerations;
using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;
using System;

namespace NEXARC.NexGroup.Dto
{
	[AutoMapFrom(typeof(Group))]
	public class GroupDto : EntityDto<int>
	{

        public string Code { get; set; }
        public int ParentGroupId { get; set; }
        public int CompanyId { get; set; }
        public string GroupManager { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RecordStatus Status { get; set; }
        public Employee Employee { get; set; }

	}
}
