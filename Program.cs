using Infrastructure.Models;
using Infrastructure.Services;

using Npgsql;

SqlCommanServices sqlCommanServices = new SqlCommanServices();

CustomerServices customerServices = new CustomerServices();

Console.WriteLine("Create Customer");
Customer customer = new Customer();
Console.Write("Full name : ");
customer.FullName = Console.ReadLine();
Console.Write("Phone number : ");
customer.PhoneNumber = Console.ReadLine();
Console.Write("Date Of Birth : ");
customer.DateOfBirth = DateTime.Parse(Console.ReadLine());
Console.Write("Email : ");
customer.Email = Console.ReadLine();
Console.Write("Is Active : ");
customer.IsActive = bool.Parse(Console.ReadLine());
Console.Write("MembershipType : ");
customer.MembershipType = Console.ReadLine();
Console.Write("RegistrationDate : ");
customer.RegistrationDate =DateTime.Parse(Console.ReadLine());
Console.WriteLine(customerServices.CreateCustomer(customer));
Console.WriteLine("GetAllCustomers");
Console.WriteLine(customerServices.GetAllCustomers());
Console.WriteLine("GetCustomerById");
Console.WriteLine(customerServices.GetCustomerById(1));
Console.WriteLine("UpdateCustomer");
Console.WriteLine(customerServices.UpdateCustomer(customer));
Console.WriteLine("DeleteCustomer");
Console.WriteLine(customerServices.DeleteCustomer(10));

