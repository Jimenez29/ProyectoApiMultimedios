using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public class Auditoria
    {

        [Key]

        [MaxLength(11)]

        public int IdAuditoria { get; set; }

        [MaxLength(150)]
        public string Sentencia { get; set; }

        [MaxLength(150)]
        public string Controller { get; set; }

        [MaxLength(11)]
        public int IdMenu { get; set; }

        [MaxLength(11)]
        public int IdUser { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }

    }
}
