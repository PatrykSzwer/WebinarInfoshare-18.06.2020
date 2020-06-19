using System.ComponentModel;

namespace WebinarMVC.Models
{
    public class Student
    {
        [DisplayName("Imie")]
        public string FirstName { get; set; }

        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        public int[] Grades { get; set; }

        [DisplayName("Numer albumu")]
        public int AlbumId { get; set; }
    }
}
