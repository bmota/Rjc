﻿using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Cloud.Samson.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}