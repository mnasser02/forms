using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvestForm.Repositories.Models;

[Table("nations")]
public partial class Nation
{
    [Key]
    [Column("CODE")]
    public int Code { get; set; }

    [Column("ALABEL")]
    [StringLength(100)]
    public string Alabel { get; set; } = null!;

    [Column("LLABEL")]
    [StringLength(50)]
    public string? Llabel { get; set; }

    [Column("FNAME")]
    [StringLength(100)]
    public string Fname { get; set; } = null!;

    [Column("TYPE")]
    public int Type { get; set; }

    [Column("GRP")]
    public int Grp { get; set; }

    [Column("LNG")]
    public int Lng { get; set; }
}
