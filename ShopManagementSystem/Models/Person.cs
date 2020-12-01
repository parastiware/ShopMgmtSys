
using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopManagementSystem.Models
{
public class Person{
[BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
     public int Id { get; set; }
 [Required]
[Display(Name = "First Name")]   
        public String FirstName { get; set; }
        
    [Display(Name = "Middle Name")]
        public String MiddleName{get;set;}
        [Required]
    [Display(Name = "Last Name")]
        public String LastName { get; set; }
        [Required]
    [Display(Name = "Email Address")]
        public String EmailAddress { get; set; }
}

}