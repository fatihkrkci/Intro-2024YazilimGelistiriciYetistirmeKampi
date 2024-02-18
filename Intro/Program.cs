using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables -> camelCase
bool isAuthenticated = false;

Console.WriteLine(message1);

//condition
if (isAuthenticated == true)
{
    Console.WriteLine("Buton --> Hoş Geldin Fatih");
}
else
{
    Console.WriteLine("Sisteme Giriş Yap");
}

string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3" , "Kredi 4", "Kredi 5", "Kredi 6"};
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new CourseManager(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod Bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Fatih";
customer1.LastName = "Kürekçi";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "10987654321";
customer2.FirstName = "Engin";
customer2.LastName = "Demiroğ";
customer2.CustomerNumber = "1234567";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}