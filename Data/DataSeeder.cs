using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AppInsightDemo.Web.Data
{
    public static class DataSeeder
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetService<AppInsightDemoContext>();

            if (!db.Users.Any())
            {
                db.Users.Add(new User
                {
                    Email = "mariano.alguien@gmail.com",
                    LastName = "Alguien",
                    Name = "Mariano",
                    Phone = "+549123123123",
                    Image = "http://steezo.com/wp-content/uploads/2012/12/man-in-suit2.jpg"

                });
                db.Users.Add(new User
                {
                    Email = "ramiro.martinez@gmail.com",
                    LastName = "Martinez",
                    Name = "Ramiro",
                    Phone = "+549123123123",
                    Image = "http://stockfresh.com/files/s/scheriton/m/21/2001012_stock-photo-business-man-in-suit-with-cheesy-grin.jpg"

                });
                db.Users.Add(new User
                {
                    Email = "juan.quien@gmail.com",
                    LastName = "Juan",
                    Name = "Quien",
                    Phone = "+54933968597",
                    Image = "https://hayathair.com/wp-content/uploads/2017/01/qcBoz77pi.png"

                });
                db.Users.Add(new User
                {
                    Email = "fran.toro@gmail.com",
                    LastName = "Toro",
                    Name = "Fran",
                    Phone = "+54966588745",
                    Image = "https://s-media-cache-ak0.pinimg.com/originals/e7/32/31/e732319ec90ada8d8d5321781f047c3d.jpg"

                });
                db.Users.Add(new User
                {
                    Email = "Martin.Valdez@gmail.com",
                    LastName = "Valdez",
                    Name = "Martin",
                    Phone = "+54912343123123",
                    Image = "http://i.dailymail.co.uk/i/pix/2016/08/22/18/377E798B00000578-3753378-image-m-35_1471885510748.jpg"

                });
                db.Users.Add(new User
                {
                    Email = "ger.nosequien@gmail.com",
                    LastName = "NoseQuien",
                    Name = "Ger",
                    Phone = "+549123123123",
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM0NDM1Nzc4MV5BMl5BanBnXkFtZTcwNjQ2NDQxOA@@._V1_UY1200_CR116,0,630,1200_AL_.jpg"

                });
                db.SaveChanges();
            }

            db.SaveChanges();
        }
    }
}