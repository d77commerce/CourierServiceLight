using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Infrastructure.Data.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourierService.Infrastructure.Data.Configuration
{
    internal class OrderConfiguration :IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order()
            {
                Id = 1,
                SenderFirstName = "Pepo",
                SenderLastName = "Ivanov",
                SenderPhone = "+4478976746",
                SenderMail = "kakapepa@abv.bg",
                ReceiverFirstName = "Radka",
                ReceiverLastName = "Piratka",
                ReceiverPhone = "+359896121478",
                ParcelKg = 2.456,
                Parts = 2,
                IsFragile = true,
                SenderCountry = "Bulgaria",
                SenderCity = "Sofia",
                SenderStreet ="Vitosha 23",
                SenderPostcode = "1000",
                ReceiverCountry = "Bulgaria",
                ReceiverCity = "Pleven",
                ReceiverStreet = "Nezabravka 4",
                ReceiverPostcode = "5400",
                CustomerMessage = "Delivery all day before 12:00 !"
            });
        }
    }
}
/*

public string SenderPostcode { get; set; } = null!;
[Required]
public string ReceiverCountry { get; set; } = null!;
[Required]
public string ReceiverCity { get; set; } = null!;
[Required]
public string ReceiverStreet { get; set; } = null!;
public string? ReceiverAddressLine1 { get; set; }
public string? ReceiverAddressLine2 { get; set; }
[Required]
public string ReceiverPostcode { get; set; } = null!;
public string? CustomerMessage { get; set; }*/