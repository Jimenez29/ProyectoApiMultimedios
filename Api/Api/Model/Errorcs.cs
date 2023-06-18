using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
    public class Error
    {


       
        [Key]
     
        public int IdErrores { get; set; }

        [MaxLength(150)]
        public string Sentencia { get; set; }

        [MaxLength(150)]
        public string Controller { get; set; }


        public DateTime CreatedAt { get; set; }

        public int IdUser { get; set; }

    }
}
