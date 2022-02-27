using BLL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class WebContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        public WebContext(DbContextOptions<WebContext> options) : base(options)
        {

        }
        internal DbSet<Photo> Photos { get; set; }
        internal DbSet<Author> Authors { get; set; }
        internal DbSet<Text> Texts { get; set; }

        // заполнение дефолтными сущностями бд 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(

                new Author
            {
                Id = 1,
                Name = "Oleg",
                Age = 18,
                NickName = "OLL",

            },
            
                new Author
            {

                Id = 2,
                Name = "Roman",
                Age = 20,
                NickName = "R0maNga"
            },
             new Author
            {
                Id = 3,
                Name = "Kate",
                Age = 30,
                NickName = "K1"
            }
            );



            modelBuilder.Entity<Photo>().HasData(
                


                    new Photo
                    {
                        Id = 1,
                        Name = "Cat",
                        PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/0/0e/Felis_silvestris_silvestris.jpg",
                        AmountOfPurchase = 10,
                        Price = 10,
                        Size = 0.1,
                        AuthorId = 1
                    },
                    new Photo
                    {
                        Id = 2,
                        Name = "Dog",
                        PhotoLink = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.bbc.com%2Frussian%2Ffeatures-42026094&psig=AOvVaw0nDdk7YuHg0Ng35KcDlqjd&ust=1645888835929000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCPD9pO2Tm_YCFQAAAAAdAAAAABAD",
                        AmountOfPurchase = 20,
                        AuthorId = 2,
                        Price = 5,
                        Size = 0.2

                    },
                    new Photo
                    {
                        Id = 3,
                        Name = "Fish",
                        PhotoLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTr5mkpGpBy9xQgR2soK52FINmgWr7A5x9oEw&usqp=CAU",
                        AmountOfPurchase = 30,
                        AuthorId = 3,
                        Price = 50,
                        Size = 0.3

                    }


                 );

            modelBuilder.Entity<Text>().HasData(
                new Text
                {
                    Id = 1,
                    Name = "About books",
                    AuthorId = 1,
                    Size = 0.1,
                    Price = 4,
                    Content = "smth adout books",
                    NumberOfSales = 10
                },

            new Text
            {
                Id = 2,
                Name = "About animals",
                AuthorId = 2,
                Size = 1,
                Price = 8,
                Content = "smth adout animals",
                NumberOfSales = 20
            },

            new Text
            {
                Id = 3,
                Name = "About nothing",
                AuthorId = 3,
                Size = 0.2,
                Price = 1,
                Content = "nothing",
                NumberOfSales = 1

            }
            );


        }
    }
}