using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvestForm.Repositories.Models;

[PrimaryKey("Serial", "Serpers")]
[Table("ImageFP")]
public partial class ImageFp
{
    [Key]
    [Column("SERIAL")]
    public int Serial { get; set; }

    [Key]
    [Column("SERPERS")]
    public int Serpers { get; set; }

    [Column("fpright", TypeName = "image")]
    public byte[]? Fpright { get; set; }

    [Column("fpleft", TypeName = "image")]
    public byte[]? Fpleft { get; set; }
}
