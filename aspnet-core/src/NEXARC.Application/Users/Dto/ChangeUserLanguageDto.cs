using System.ComponentModel.DataAnnotations;

namespace NEXARC.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}