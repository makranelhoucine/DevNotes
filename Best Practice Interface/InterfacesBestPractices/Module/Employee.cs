public class Employee
{
    public IReaderWriter<EmployeeData> EmployeeReaderWriter { get; set; }

    public Employee()
    {
        this.EmployeeReaderWriter = new FileReaderWriter<EmployeeData>();
        this.EmployeeReaderWriter.Initialize();
        this.WriteSampleEmployee();
    }

    private void WriteSampleEmployee()
    {
        this.EmployeeReaderWriter.Write(
            new EmployeeData
            {
                DataId = 1,
                DataDescription = "Some description.",
                EmployeeName = "Ahmed" 
            });
    }

    public EmployeeData EmployeeById(int idEmployee) => this.EmployeeReaderWriter.Read(idEmployee);
}