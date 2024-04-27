namespace CoderzApp204.Models.SharedProp
{
    public class CommonProp
    {
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public enum Genders
        {
            Male,
            Female
        }
    }
}
