using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvestForm.Repositories.Models;

[Table("vehicles")]
public partial class Vehicle
{
    [Key]
    [Column("vid")]
    public int Vid { get; set; }

    [Column("serialNB")]
    public int? SerialNb { get; set; }

    [Column("ActualNB")]
    [StringLength(255)]
    public string? ActualNb { get; set; }

    [Column("CodeDESC")]
    [StringLength(255)]
    public string? CodeDesc { get; set; }

    [Column("PRODDATE")]
    [StringLength(255)]
    public string? Proddate { get; set; }

    [StringLength(255)]
    public string? Chassis { get; set; }

    [StringLength(255)]
    public string? Motor { get; set; }

    [Column("dateaquisition")]
    [StringLength(255)]
    public string? Dateaquisition { get; set; }

    [StringLength(255)]
    public string? PreMiseCirc { get; set; }

    [StringLength(255)]
    public string? ColorDesc { get; set; }

    [StringLength(255)]
    public string? Brand { get; set; }

    [StringLength(255)]
    public string? Model { get; set; }

    [StringLength(255)]
    public string? UtilisDesc { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string? Name { get; set; }

    [Column("lastname")]
    [StringLength(255)]
    public string? Lastname { get; set; }

    [StringLength(255)]
    public string? NoRegProp { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    [Column("CityID")]
    [StringLength(255)]
    public string? CityId { get; set; }

    [Column("DistrictID")]
    [StringLength(255)]
    public string? DistrictId { get; set; }

    [Column("GovernateID")]
    [StringLength(255)]
    public string? GovernateId { get; set; }

    [StringLength(255)]
    public string? MotherName { get; set; }

    [StringLength(255)]
    public string? TelProp { get; set; }

    [StringLength(255)]
    public string? AgeProp { get; set; }

    [StringLength(255)]
    public string? BirthPlace { get; set; }

    [Column("HORSSERVICE")]
    public int? Horsservice { get; set; }
}
