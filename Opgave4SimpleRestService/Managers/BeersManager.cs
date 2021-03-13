using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Opgave4SimpleRestService.Model;

namespace Opgave4SimpleRestService.Managers
{
    public class BeersManager
    {
        private static int _followingId = 1;
        private static readonly List<Beer> MyData = new List<Beer>
        {
            new Beer(id: _followingId++, "Alkoholfrei Bavaria", 10, 0),
            new Beer(id: _followingId++, "Erdinger", 20, 7),
            new Beer(id: _followingId++, "Carlsberg", 8, 5)
        };

        public List<Beer> GetAll()
        {
            return new List<Beer>(MyData);
        }

        public Beer GetId(int id)
        {
            return MyData.Find(beer => beer.Id == id);
        }

        public Beer Create(Beer createBeer)
        {
            createBeer.Id = _followingId++;
            MyData.Add(createBeer);
            return createBeer;
        }

        public Beer Delete(int id)
        {
            Beer deleteBeer = MyData.Find(findBeer => findBeer.Id == id);
            MyData.Remove(deleteBeer);
            return deleteBeer;
        } 
        
        public Beer Update(int id, Beer updateBeer)
        {
            Beer beer = MyData.Find(findBeer => findBeer.Id == id);
            beer.Name = updateBeer.Name;
            beer.Price = updateBeer.Price;
            beer.Abv = updateBeer.Abv;
            return beer;
        }

    }
}
