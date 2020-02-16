using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Concrete
{
    class DbInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var reviews = new List<Review>
            {
                new Review { Author = "Author1", Date = DateTime.Now, Text = "wbersvdfsdvfwevfdsvfsvtsddsfvgdsv" },
                new Review {Author = "Author2", Date = DateTime.Now, Text = "zxvzxvxczvzxvwevfdsvfsvtsddsfvgdsv" },
                new Review { Author = "Author3", Date = DateTime.Now, Text = "uyiyuiyuiyuiyuivfdsvfsvtsddsfvgdsv" }
            };
            reviews.ForEach(x => context.Reviews.Add(x));
            context.SaveChanges();

            var articles = new List<Article>
            {
               new Article {Name = "Linux kernel", Date= new DateTime(2019, 10, 5), Text ="The Linux kernel is a free and open-source, monolithic, Unix-like operating system kernel. The Linux family of operating systems is based on this kernel and deployed on both traditional computer systems such as personal computers and servers, usually in the form of Linux distributions, and on various embedded devices such as routers, wireless access points, PBXes, set-top boxes, FTA receivers, smart TVs, PVRs, and NAS appliances. While the adoption of the Linux kernel in desktop computer operating system is low, Linux-based operating systems dominate nearly every other segment of computing, from mobile devices to mainframes. Since November 2017, all of the world's 500 most powerful supercomputers run Linux. The Android operating system for tablet computers, smartphones, and smartwatches also uses the Linux kernel."},
               new Article {Name = "Artificial Island, New Jersey", Date = new DateTime(2019,11,15), Text ="Artificial Island is a U.S. island located along the eastern shore of the Delaware River, mostly in southwestern New Jersey with a tiny portion inside Delaware's boundaries.[1] It is part of both Lower Alloways Creek Township, Salem County, New Jersey and New Castle County, Delaware. The island is separated from mainland New Jersey by Alloway Creek and Hope Creek. It is called artificial since portions of the island are composed of land reclaimed from Delaware Bay. An artificial island is an island constructed by man rather than created by natural means. The island is geographically unusual since it contains one of two tiny exclaves of the state of Delaware, which is created by the Delaware-New Jersey land border crossing the northern tip of the island, an area that is completely cut off from the rest of Delaware across the Delaware River to the west, and has no road connections to it. New Jersey is separated from Delaware by the Delaware River except for these two areas, which has a land border. The only land access to this exclave at the north tip of the island is from New Jersey. This exclave was created as a result of the Twelve-Mile Circle, which was part of the resolution of the Penn-Calvert Boundary Dispute among the surrounding states of Pennsylvania, Maryland, Delaware, New Jersey, and West Virginia."},
               new Article {Name = "Tesla, Inc.", Date = new DateTime(2019, 12,17), Text = "Tesla Motors was incorporated in July 2003 by Martin Eberhard and Marc Tarpenning with 98% of the initial funds being provided by Chairman of the Board Elon Musk, who appointed Eberhard to be the first CEO. The founders were influenced to start the company after GM recalled all its EV1 electric cars in 2003 and then destroyed them, and seeing the higher efficiency of battery-electric cars as an opportunity to break the usual correlation between high performance and low mileage. Elon Musk led the Series A round of investment in February 2004, joining Tesla's board of directors as its chairman. Tesla's primary goal was to commercialize electric vehicles, starting with a premium sports car aimed at early adopters and then moving into more mainstream vehicles, including sedans and affordable compacts.Musk took an active role within the company and oversaw Roadster product design at a detailed level.[33] In addition to his daily operational roles, Musk was the controlling investor in Tesla from the first financing round, funding $6.5 million of the Series A round of US$7.5 million with personal funds. Musk later led Tesla Motors' Series B, $9 million of US$13 million, and co-led the third, US$12 million of US$40 million round in May 2006."},
               new Article{Name = "Paintball", Date = new DateTime(2020,1,10), Text = "Paintball is a competitive team shooting sport in which players eliminate opponents from play by hitting them with spherical dye-filled gelatin capsules (paintballs) that break upon impact. Paintballs are usually shot using a low-energy air weapon called a paintball marker that is powered by compressed air (nitrogen) or carbon dioxide and was originally designed for remotely marking trees and cattle.The game was initially developed in May 1981 by Hayes Noel (a Wall Street stock trader) and Charles Gaines (an avid outdoorsman and writer). Best friends, Noel and Gaines argued about who would be better suited for survival, a city dweller who knew how people's minds worked (Noel) or a man who had spent his youth hunting, fishing, and building cabins in the woods (Gaines). The two men chanced upon an advertisement for a paint gun and were inspired to settle their argument with paintball markers, eventually creating the sport that is now called Paintball."}
            };
            articles.ForEach(x => context.Articles.Add(x));
            context.SaveChanges();

        }
    }
}
