using System;
using ShopManagementSystem.Models;

public class Administrator : Person
{
    private readonly Guid AdminKey = Guid.NewGuid();
    private string Password {get; set;}

    public bool IsAdmin(Guid key)
    {
        if(this.AdminKey==key)
        return true;
        else
        return false;

    }
    

}