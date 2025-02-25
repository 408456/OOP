public class Student
{
    public double Isy { get; set; } 
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int StudyYear { get; set; }
    public required string Major { get; set; }
    public required string Group { get; set; }
    public required string Email { get; set; }

    // Builder
    public class Builder
    {
        private double isy;  
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private int StudyYear;
        private string major;
        private string group;
        private string email;

        public Builder SetIsy(double isy)
        {
            this.isy = isy;
            return this;
        }

        public Builder SetFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public Builder SetLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public Builder SetBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
            return this;
        }

        public Builder SetStudyYear(int StudyYear)
        {
            this.StudyYear = StudyYear;
            return this;
        }

        public Builder SetMajor(string major)
        {
            this.major = major;
            return this;
        }

        public Builder SetGroup(string group)
        {
            this.group = group;
            return this;
        }

        public Builder SetEmail(string email)
        {
            this.email = email;
            return this;
        }

        public Student Build()
        {
            return new Student
            {
                Isy = isy, 
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                StudyYear = StudyYear,
                Major = major,
                Group = group,
                Email = email
            };
        }
    }
}
