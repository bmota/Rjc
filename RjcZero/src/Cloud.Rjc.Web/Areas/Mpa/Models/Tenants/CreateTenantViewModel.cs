﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Cloud.Rjc.Web.Areas.Mpa.Models.Tenants
{
    public class CreateTenantViewModel
    {
        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public CreateTenantViewModel(IReadOnlyList<ComboboxItemDto> editionItems)
        {
            EditionItems = editionItems;
        }
    }
}