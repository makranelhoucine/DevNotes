using WiredBrainCoffeeCompany.Data;
using WiredBrainCoffeeCompany.Entites;
using WiredBrainCoffeeCompany.Repositories;

var employeesRepository = new SqlRepository<Employee>(new WiredBrainCoffeeDbContext());
AddEmployees(employeesRepository);
AddManagers(employeesRepository);

var organizationRepository = new ListRepository<Organization>();
AddOrganizations(organizationRepository);

WriteAllToConsole(employeesRepository);
WriteAllToConsole(organizationRepository);

Console.ReadLine();

void AddEmployees(IRepository<Employee> repository)
{
    var employees = new[]
    {
        new Employee() { Name = "Info1" },
        new Employee() { Name = "Info2" },
        new Employee() { Name = "Info3" }
    };

    repository.AddBatch(employees);
}

void AddOrganizations(IRepository<Organization> repository)
{
    var organizations = new[]
    {
        new Organization() { Name = "Entropy1" },
        new Organization() { Name = "Entropy2" },
        new Organization() { Name = "Entropy3" }
    };

    repository.AddBatch(organizations);
}

void AddManagers(IWriteRepository<Manager> repository)
{
    var item = new Manager() { Name = "Sara" };
    var copiedItem = item.Copy();
    repository.Add(item);

    if(copiedItem is not null)
    {
        copiedItem.Name += "_Copy";
        repository.Add(copiedItem);
    }

    repository.Add(new Manager() { Name = "Henry" });

    employeesRepository.Save();
}

void WriteAllToConsole(IReadRepository<IEntityBase> repository)
{
    var elements = repository.GetAll(); 
    foreach (var el in elements)
    {
        Console.WriteLine(el);
    }
}



