using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    [Table("Text")]
    public class Text
    {
        //сущность текст
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id  { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public double Size { get; set; }
        public DateTime DateOfCreate { get; set; }
        public decimal Price { get; set; }
        public double NumberOfSales { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
