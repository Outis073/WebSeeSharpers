﻿namespace WebSeeSharpers.Models;

public class Order
{

    public int Id { get; set; }

    public string? Email { get; set; }

    public int Code { get; set; }

    public DateTime CreatedDate { get; set; }

    public Boolean Secret { get; set; }

    public List<Ticket> Tickets { get; set; }

    public Boolean IsPrinted { get; set; }
}