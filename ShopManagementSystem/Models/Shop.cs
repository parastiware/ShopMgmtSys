
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopManagementSystem.Models
{
    public class Shop
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Display(Name = "Registration Number")]
        public int RegistrationNumber { get; set; }
        public string Address { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        public List<Administrator> Administrators = new List<Administrator> { };
        public List<Employee> Employees = new List<Employee> { };
    }



}