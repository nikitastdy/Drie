using System;
using System.Collections.Generic;

namespace Drie.Models;

public partial class Driver
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Middlename { get; set; } = null!;

    public string Passportserial { get; set; } = null!;

    public string Passportnumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Addresslife { get; set; } = null!;

    public string? Company { get; set; }

    public string? Jobname { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Photo { get; set; } = null!;

    public string? Description { get; set; }

    public sbyte Archive { get; set; }
}
