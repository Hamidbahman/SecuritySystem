using System;

namespace controlpannel.application.Dtos;

    public class SortingRequestDto
    {
        public string? SortField { get; set; }
        public bool Descending { get; set; }
    }