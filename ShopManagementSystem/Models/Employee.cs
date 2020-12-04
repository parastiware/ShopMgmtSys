using ShopManagementSystem.Models;
using System.Security.Cryptography;
using System.Text;

public class Employee:Person
{

public int Salary { get; set; }

public const bool  IsEmployee = true;



}