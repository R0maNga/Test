using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    [Table("Author")]
    public class Author
    {
        //сущность автор
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Photo> Photos { get; set;  }= new List<Photo>();
        public List<Text> Texts { get; set;  }= new List<Text>();

    }
}
