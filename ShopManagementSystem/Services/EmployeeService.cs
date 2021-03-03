using ShopManagementSystem.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace ShopManagementSystem.Services
{
    public class EmployeeService
    {
        private readonly IMongoCollection<Employee> _employees;
         private readonly IMongoCollection<Shop> _shop;

        public EmployeeService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("ShopManagementSystemDB"));
            var database = client.GetDatabase("ShopManagementSystemDB");
         _employees = database.GetCollection<Employee>("Employees");
         _shop = database.GetCollection<Shop>("ShopManagementSystemCollection");
        }

        public List<Employee> Get() =>
            _employees.Find(Employee => true).ToList();

        public Employee Get(string id) =>
            _employees.Find<Employee>(Employee => Employee.Id == id).FirstOrDefault();

        public Employee Create(Employee employee)
        {
            _employees.InsertOne(employee);
            return employee;
        }

        public void Update(string id, Employee employeeIn) =>
            _employees.ReplaceOne(employee => employee.Id == id, employeeIn);

        public void Remove(Shop employeeIn) =>
            _employees.DeleteOne(employee => employee.Id == employeeIn.Id);

        public void Remove(string id) => 
            _employees.DeleteOne(employee => employee.Id == id);
    }
}