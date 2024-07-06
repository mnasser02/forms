using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvestForm.Repositories.Models;

[Table("Village")]
public partial class Village
{
    [Key]
    [Column("CODE")]
    public int Code { get; set; }

    [Column("LABEL")]
    [StringLength(200)]
    public string? Label { get; set; }

    [Column("STAT")]
    public int? Stat { get; set; }
}
