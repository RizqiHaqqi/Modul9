namespace Modul9_1302220016
{
    public class mhs
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }
        public mhs(string Nama, string NIM, List<string> Course, int Year)
        {
            this.Nama = Nama;
            this.NIM = NIM;
            this.Course = Course;
            this.Year = Year;
        }  
    }
}
