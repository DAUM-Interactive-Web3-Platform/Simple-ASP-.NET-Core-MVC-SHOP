using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class MockSnowboardRepository : ISnowboardRepository
    {
        private List<Snowboard> _snowboards;

        public MockSnowboardRepository()
        {
           if(_snowboards == null)
            {
                InitializeSnowboards();
            }
        }

        public IEnumerable<Snowboard> Snowboards => throw new NotImplementedException();

        public IEnumerable<Snowboard> GetAllSnowboards()
        {
            return _snowboards;
        }

        public Snowboard GetSnowboardById(int snowboardId)
        {
            return _snowboards.FirstOrDefault(s => s.Id == snowboardId);
        }

        private void InitializeSnowboards()
        {
            _snowboards = new List<Snowboard>
            {
                new Snowboard { Id = 1, Brand = "Burton", Model = "Custom", Price = 1200.24, Length = 152, LongDescription="It’s a double decade icon and the most trusted board ever. Any trick, any terrain…the Custom delivers! Since its humble beginnings, innovation has defined the Burton Custom series and set it apart as the most popular, versatile, and mimicked board in snowboarding. These days, the one-board answer to all terrain adds exclusive ingredients like Carbon Highlights and Squeezebox core profiling to the mix for drastic weight savings, crisper pop and deluxe handling to pilot through the mountain’s mixed bag.", RidingStyle = "Freestyle", ImageThumbnailUrl = "http://v-ie.uek.krakow.pl/~s199979/snowboards/Custom.jpg" },
                new Snowboard { Id = 2, Brand = "Burton", Model = "Process", Price = 1399, Length = 155, LongDescription = "Take your freestyle further with the board Mark McMorris chooses for lightweight performance and action-packed pop. Re-evolved to shed ounces and amplify pop, Mark McMorris picks the Burton Process for its twin freestyle playfulness and all-terrain prowess. The FSC™ Certified Super Fly II™ core creates a lighter, lift-off-ready deck, while Squeezebox core profiling transfers energy towards the tip and tail for snappier ollies and effortless stability.", RidingStyle= "Freestyle", ImageThumbnailUrl = "http://v-ie.uek.krakow.pl/~s199979/snowboards/Process.jpg" },
                new Snowboard { Id = 3, Brand = "Lib Tech", Model = "Skate Banana", Price = 2000.99, Length = 159, LongDescription = "The award-winning Skate Banana rips everything, it is easy to ride, easy to turn, catch-free and forgiving, floats in powder, is unreal for jibbing and freestyle. The Skate Banana is a fantastic board and will never grow old in your quiver.", RidingStyle = "Jibbing", ImageThumbnailUrl = "http://v-ie.uek.krakow.pl/~s199979/snowboards/SkateBanana.jpg"},
                new Snowboard { Id = 4, Brand = "Gnu", Model = "Hyak BTX", Price = 1100, Length = 160, LongDescription = "Its value is inherent in its design. The Hyak twin shape will take you for a ride of infinite opportunity either direction you choose to ride it. Heritage print top material, Verzure instantly sheds snow for more eyes on the rideable art brought to you by Seattle artist Robert Hardgrave. This board will turn heads.", RidingStyle = "All mountain", ImageThumbnailUrl ="http://v-ie.uek.krakow.pl/~s199979/snowboards/Hyak.jpg"},
                new Snowboard { Id = 5, Brand = "Bataleon", Model = "G.W 2018", Price = 1499,  Length = 151, LongDescription = "The G.W is Bataleon's finest composition of the best elements. Out comes an all-mountain chart-stormer with great pop, control and power! Go ahead, put this bad ass on repeat and press Play! But watch out, that's a hard-liner!", RidingStyle = "Freestyle", ImageThumbnailUrl = "http://v-ie.uek.krakow.pl/~s199979/snowboards/G.W.jpg"},
                new Snowboard { Id = 6, Brand = "Rome", Model = "Mechanic", Price = 999.99, Length = 156, LongDescription = "The Mechanic is dialled for all-around good times on the mountain. Cruise turns. Find a line in the woods. Hit the same side hit every day. Take a lap, or ten, through the park. A single shot of pop-enhancing HotRods technology teams up with a flat rocker profile for the right blend of response and fun.", RidingStyle = "All mountain", ImageThumbnailUrl = "http://v-ie.uek.krakow.pl/~s199979/snowboards/Mechanic.jpg"},
                new Snowboard { Id = 7, Brand = "Rome", Model = "Buckshot", Price = 1399, Length = 147, LongDescription = "The brainchild of Ozzy Henning and Toni Kerkelä, the award-winning positive cambered Buckshot board by Rome is built for riders who see features everywhere they look. With a freestyle-friendly flex that begs to be pressed and locks into rails with ease, the Buckshot is the go-to for park provide across the globe. Rebound sidewalls help to absorb impacts so that you can disaster-front board with confidence. ", RidingStyle = "Jibbing",  ImageThumbnailUrl = "http://v-ie.uek.krakow.pl/~s199979/snowboards/Buckshot.jpg"},
                new Snowboard { Id = 8, Brand = "Bataleon", Model = "Whatever", Price = 1150.99, Length = 154, LongDescription = "What kind of snow does it prefer? Whatever. Once again the name says it all. This board is simply capable of whatever. It's comfortable from park to off-piste. So ride the Whatever whenever and however you please!", RidingStyle = "Freeride", ImageThumbnailUrl = "http://v-ie.uek.krakow.pl/~s199979/snowboards/Whatever.jpg"},
                new Snowboard { Id = 9, Brand = "Lib Tech", Model = "Jack Knife", Price = 1555.99, Length = 159, LongDescription = "After a decade plus of sitting on top of the food chain Eric Jackson knows just what he wants in a dream board. The EJack Knife is a directional C3 camber board with a smooth entry extended floaty nose made even more effortless with a mild taper then finished off with legendary Alaskan folk artist Ray Troll’s art. If you want to gut and clean some double black diamonds with maximum speed, precision, and fun, get the EJack Knife.", RidingStyle = "Freeride", ImageThumbnailUrl = "http://v-ie.uek.krakow.pl/~s199979/snowboards/JackKnife.jpg"}

            };
        }




    }
}
