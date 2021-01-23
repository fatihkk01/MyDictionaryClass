using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryClass
{
    class GameDictionary<Id,Name,ReleaseDate,Price,Point>
    {
        Id[] id;
        Name[] name;
        ReleaseDate[] releaseDate;
        Price[] price;
        Point[] point;

        public GameDictionary()
        {
            id = new Id[0];
            name = new Name[0];
            releaseDate = new ReleaseDate[0];
            price = new Price[0];
            point = new Point[0];
        }

        public void Add(Id ids, Name names, ReleaseDate releaseDates, Price prices, Point points)
        {
            Id[] tempId = id;
            Name[] tempName = name;
            ReleaseDate[] tempReleaseDate = releaseDate;
            Price[] tempPrice = price;
            Point[] tempPoint = point;

            id = new Id[id.Length + 1];
            name = new Name[name.Length + 1];
            releaseDate = new ReleaseDate[releaseDate.Length + 1];
            price = new Price[price.Length + 1];
            point = new Point[point.Length + 1];

            for (int i = 0; i < tempId.Length; i++)
            {
                id[i] = tempId[i];
                name[i] = tempName[i];
                releaseDate[i] = tempReleaseDate[i];
                price[i] = tempPrice[i];
                point[i] = tempPoint[i];
                
            }

            id[id.Length-1] = ids;
            name[name.Length - 1] = names;
            releaseDate[releaseDate.Length - 1] = releaseDates;
            point[point.Length - 1] = points;
            price[price.Length - 1] = prices;

        }

        public int Length
        {
            get { return id.Length; }
        }

        public Id[] Ids
        {
            get { return id; }
        }

        public Name[] Names
        {
            get { return name; }
        }

        public ReleaseDate[] ReleaseDates
        {
            get { return releaseDate; }
        }

        public Point[] Points
        {
            get { return point; }
        }

        public Price[] Prices
        {
            get { return price; }
        }

        public void Read()
        {

            Console.WriteLine("----------------------GAMES----------------------");
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine("Id : "+id[i]);
                Console.WriteLine("Name : "+name[i]);
                Console.WriteLine("Release Date : "+releaseDate[i]);
                Console.WriteLine("Point : "+point[i]);
                Console.WriteLine("Price : "+price[i]);
                Console.WriteLine("-------------------------------------------------");
            }
        }

    }
}
