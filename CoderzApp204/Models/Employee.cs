using CoderzApp204.Models.SharedProp;

namespace CoderzApp204.Models
{
    public class Employee : CommonProp
    {
        // PK : Not Null , not Duplicate
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public Genders Gender { get; set; }



    }
}
