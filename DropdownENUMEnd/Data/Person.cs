﻿using DropdownEnd.Data;
using DropdownENUMEnd.Data;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SkysFormsDemo.Data;

public class Person
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string Name { get; set; }
    [StringLength(100)]
    public string StreetAddress { get; set; }

    [StringLength(10)]
    public string PostalCode { get; set; }

    public Country Country { get; set; }
    
    //[StringLength(2)]
    //public string CountryCode { get; set; }
    public DateTime Registered { get; set; }
    public DateTime LastModified { get; set; }

    public decimal Salary { get; set; }

    public int Age { get; set; } //Krysta fram ett int-usecase
    [StringLength(50)]
    public string City { get; set; }
    [StringLength(150)]
    public string Email { get; set; }

    public Gender GenderUser { get; set; }
}