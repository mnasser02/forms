using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvestForm.Repositories.Models;

[Table("INVEST")]
public partial class Invest
{
    [Key]
    [Column("SERIAL")]
    public int Serial { get; set; }

    [Column("DFILE")]
    public DateOnly Dfile { get; set; }

    [Column("DMAHDAR")]
    public DateOnly Dmahdar { get; set; }

    [Column("CRIME")]
    [StringLength(50)]
    public string? Crime { get; set; }

    [Column("MADBOUT")]
    [StringLength(1)]
    public string? Madbout { get; set; }

    [Column("RESUME")]
    [StringLength(1)]
    public string? Resume { get; set; }

    [Column("REM", TypeName = "text")]
    public string? Rem { get; set; }
}
