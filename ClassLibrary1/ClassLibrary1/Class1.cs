
namespace HRAdministrationAPI
{
   public interface IEmployee
    {
        public int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

    }
}
