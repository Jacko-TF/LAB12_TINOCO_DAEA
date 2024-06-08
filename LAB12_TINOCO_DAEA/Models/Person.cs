namespace LAB12_TINOCO_DAEA.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirthday { get; set; }

        public Person(int personId, string firtsName, string lastName, string address)
        {
            this.PersonId = personId;
            this.FirstName = firtsName;
            this.LastName = lastName;
            this.Address = address;
        }
    }
}
