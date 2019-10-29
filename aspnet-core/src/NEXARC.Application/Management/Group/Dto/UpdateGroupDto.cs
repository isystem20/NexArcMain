using NEXARC.Domain.Entities.HumanResource;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using System;
using Abp.AutoMapper;

namespace NEXARC.NexGroup.Dto
{
	[AutoMapTo(typeof(Group))]
	public class UpdateGroupDto : CreateGroupDto, IEntityDto
	{

		public int Id { get; set; }

	}
}
