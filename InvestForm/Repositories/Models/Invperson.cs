using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvestForm.Repositories.Models;

[PrimaryKey("Serial", "Serpers")]
[Table("invpersons")]
public partial class Invperson
{
    [Key]
    [Column("SERIAL")]
    public int Serial { get; set; }

    [Key]
    [Column("SERPERS")]
    public int Serpers { get; set; }

    [Column("FNAME")]
    [StringLength(50)]
    public string? Fname { get; set; }

    [Column("LNAME")]
    [StringLength(50)]
    public string? Lname { get; set; }

    [Column("FATHER")]
    [StringLength(50)]
    public string? Father { get; set; }

    [Column("MOTHER")]
    [StringLength(50)]
    public string? Mother { get; set; }

    [Column("NATION")]
    public int? Nation { get; set; }

    [Column("REG")]
    [StringLength(60)]
    public string? Reg { get; set; }

    [Column("PBIRTH")]
    [StringLength(50)]
    public string? Pbirth { get; set; }

    [Column("DBIRTH")]
    public int? Dbirth { get; set; }

    [Column("RESID")]
    [StringLength(60)]
    public string? Resid { get; set; }

    [Column("ADRS")]
    [StringLength(50)]
    public string? Adrs { get; set; }

    [Column("ATTR")]
    public int? Attr { get; set; }

    [Column("EXST")]
    public int? Exst { get; set; }

    [Column("ARCH")]
    public int? Arch { get; set; }

    [StringLength(50)]
    public string? Nickname { get; set; }

    [StringLength(50)]
    public string? Occupation { get; set; }

    [StringLength(50)]
    public string? Idnum { get; set; }

    [StringLength(50)]
    public string? Mobileno { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? Gender { get; set; }
}
