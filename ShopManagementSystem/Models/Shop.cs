
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
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

        [Required]
        public string EmailAddress { get; set; }
        [Required]
        private byte[] Password {get; set;}
         public byte[] PasswordValue1 {get; set;}
         public byte[] PasswordValue2 {get; set;}
         
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


        public List<Administrator> Administrators = new List<Administrator> { };
        public List<Employee> Employees = new List<Employee> { };
    }



}