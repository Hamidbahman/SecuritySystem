using System;

namespace controlpannel.application.Dtos;

    public class AplicationSortingRequestDto
    {
        public string? SortField { get; set; }
        public bool Descending { get; set; }
    }