using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    [Table ("Photo")]
    public class Photo
    {
        // сущность фото
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Size { get; set; }
        public DateTime DateCreate { get; set; }
        public String PhotoLink { get; set; }
        
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
        public double AmountOfPurchase { get; set; }



    }
}
