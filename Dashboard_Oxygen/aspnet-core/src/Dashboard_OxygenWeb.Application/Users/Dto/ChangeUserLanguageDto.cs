using System.ComponentModel.DataAnnotations;

namespace Dashboard_OxygenWeb.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}