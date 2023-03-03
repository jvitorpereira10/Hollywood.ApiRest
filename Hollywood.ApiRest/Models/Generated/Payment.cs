﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hollywood.RestApi.Models;

[Table("payment")]
[Index("RentalId", Name = "fk_payment_rental")]
[Index("CustomerId", Name = "idx_fk_customer_id")]
[Index("StaffId", Name = "idx_fk_staff_id")]
public partial class Payment
{
    [Key]
    [Column("payment_id")]
    public ushort PaymentId { get; set; }

    [Column("customer_id")]
    public ushort CustomerId { get; set; }

    [Column("staff_id")]
    public byte StaffId { get; set; }

    [Column("rental_id")]
    public int? RentalId { get; set; }

    [Column("amount")]
    [Precision(5, 2)]
    public decimal Amount { get; set; }

    [Column("payment_date", TypeName = "datetime")]
    public DateTime PaymentDate { get; set; }

    [Column("last_update", TypeName = "timestamp")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Payments")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("RentalId")]
    [InverseProperty("Payments")]
    public virtual Rental? Rental { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("Payments")]
    public virtual Staff Staff { get; set; } = null!;
}
