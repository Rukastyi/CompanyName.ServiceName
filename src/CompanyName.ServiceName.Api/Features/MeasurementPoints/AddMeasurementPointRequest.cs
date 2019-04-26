﻿using CompanyName.ServiceName.Contracts.DataAccess;
using System.ComponentModel.DataAnnotations;

namespace CompanyName.ServiceName.Api.Features.MeasurementPoints
{
    public sealed class AddMeasurementPointRequest
    {
        [Required]
        public int ConsumptionObjectId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ElectricityMeter ElectricityMeter { get; set; }

        [Required]
        public CurrentTransformer CurrentTransformer { get; set; }

        [Required]
        public VoltageTransformer VoltageTransformer { get; set; }
    }
}
