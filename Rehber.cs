namespace proje_1{
    public class Rehber
    {
        public Rehber(string isim, string soyisim, string no)
        {
            this.Isim = isim;
            this.Soyisim = soyisim; 
            this.No = no;
        }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string No { get; set; }
    }
}