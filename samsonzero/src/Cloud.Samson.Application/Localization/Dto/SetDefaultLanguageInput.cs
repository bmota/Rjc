﻿using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Localization;

namespace Cloud.Samson.Localization.Dto
{
    public class SetDefaultLanguageInput
    {
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public virtual string Name { get; set; }
    }
}