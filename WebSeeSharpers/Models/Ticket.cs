﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebSeeSharpers.Models;

public class Ticket
{
    public int Id { get; set; }

    public int Seat { get; set; }

    public int Code { get; set; }

    public int DiscountType { get; set; }

    public Boolean PopcornArrangement { get; set; }

    public decimal TotalPrice { get; set; }

    [ForeignKey("Order")]
    public int OrderId { get; set; }

    public virtual ICollection<Special> Specials { get; set; }
}