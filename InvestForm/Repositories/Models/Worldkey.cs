using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvestForm.Repositories.Models;

[Table("worldkey")]
public partial class Worldkey
{
    [Key]
    [Column("CODE")]
    public int Code { get; set; }

    [Column("LABEL")]
    [StringLength(100)]
    public string Label { get; set; } = null!;

    [Column("LINKCODE")]
    public int? Linkcode { get; set; }

    [Column("OFFICE")]
    public int? Office { get; set; }
}
