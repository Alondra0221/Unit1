using System;
namespace Cars
{
    public class License
    {
        ///Atributes.
        public List<License> lisencia;
        public int codeP { get; set; }
        public DateTime initial { get; set; }
        public DateTime expiration { get; set; }
        public string status { get; set; }
        public string type { get; set; }

       public License()
        {
            
            //Constructor.
            this.codeP = 0;
            this.initial = new DateTime();
            this.expiration = new DateTime() ;
            this.status = "";
            this.type = "" ;
            this.lisencia = new List<License>();



        }
        

    }
}

