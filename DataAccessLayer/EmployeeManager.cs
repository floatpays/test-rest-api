namespace RestApiExercise.DataAccessLayer;

public class EmployeeManager
{
    public EmployeeDbEntity GetEmployee(int employeeId)
    {
        // Database logic to load employee from the database and
        // map to EmployeeDTO object.
        return new EmployeeDbEntity();
    }

    public void Delete(int employeeId)
    {
        // Database logic to delete employee from the database
    }
}
