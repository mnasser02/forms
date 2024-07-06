using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvestForm.Repositories.Models;

[PrimaryKey("Serial", "Serpers")]
[Table("ImageAndFP")]
public partial class ImageAndFp
{
    [Key]
    [Column("serial")]
    public int Serial { get; set; }

    [Key]
    [Column("serpers")]
    public int Serpers { get; set; }

    [Column("faceright", TypeName = "image")]
    public byte[]? Faceright { get; set; }

    [Column("facefront", TypeName = "image")]
    public byte[]? Facefront { get; set; }

    [Column("faceleft", TypeName = "image")]
    public byte[]? Faceleft { get; set; }

    [Column("fpright", TypeName = "image")]
    public byte[]? Fpright { get; set; }

    [Column("fpleft", TypeName = "image")]
    public byte[]? Fpleft { get; set; }
}
