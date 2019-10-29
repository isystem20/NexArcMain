using NEXARC.Domain.Entities.HumanResource;
using NEXARC.Domain.Enumerations;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
using System;

namespace NEXARC.NexGroup.Dto
{
	[AutoMapTo(typeof(Group))]
	public class CreateGroupDto
	{

		[Required]
        public string Code { get; set; }
		[Required]
        public int ParentGroupId { get; set; }
		[Required]
        public int CompanyId { get; set; }
		[Required]
        public string GroupManager { get; set; }
		[Required]
        public string Name { get; set; }
		[Required]
        public string Description { get; set; }
		[Required]
        public RecordStatus Status { get; set; }
		[Required]
        public Employee Employee { get; set; }

	}
}
