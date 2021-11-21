using WiredBrainCoffeeCompany.Data;
using WiredBrainCoffeeCompany.Entites;
using WiredBrainCoffeeCompany.Repositories;

var employeesRepository = new SqlRepository<Employee>(new WiredBrainCoffeeDbContext());
employeesRepository.Add(new Employee() { Name = "Info" });

var organizationRepository = new ListRepository<Organization>();
organizationRepository.Add(new Organization() { Name = "Entropy" });

employeesRepository.Save();
organizationRepository.Save();

WriteAllToConsole(employeesRepository);

void WriteAllToConsole(IRepository<Employee> repository)
{
    var elements = repository.GetAll();
    foreach (var el in elements)
    {
        Console.WriteLine(el);
    }
}

Console.ReadLine();

