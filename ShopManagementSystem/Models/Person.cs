
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopManagementSystem.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        private byte[] Password {get; set;}
        public void SetPassword(string password)
    {
        byte[] passvalues=Encoding.ASCII.GetBytes(password); 
        using (SHA256 mySHA256 = SHA256.Create())
            {
                var hashpass= mySHA256.ComputeHash(passvalues);
                 this.Password=hashpass;
            }
    }

    public bool CheckPassword(string password)
    {
        byte[] passvalues=Encoding.ASCII.GetBytes(password); 
        using (SHA256 mySHA256 = SHA256.Create())
            {
                var hashpass= mySHA256.ComputeHash(passvalues);
                 
                 if(this.Password==hashpass)
                 {
                     return true;
                 }
                 return false;
            }

    }


    }

}