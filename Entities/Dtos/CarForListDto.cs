﻿using Core.Entities;

namespace Entities.Dtos
{
    public class CarForListDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
    }
}