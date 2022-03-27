using DayTrip_NJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayTrip_NJ.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Delaware Water Gap", Description="Go hiking, boating, kayaking, rafting, or cycling in the Delaware Water Gap National Recreation Area." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Atlantic City", Description="Gamble at casinos, walk on the Atlantic Boardwalk, and go on carnival rides by the beach." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Cape May", Description="Visit the beach, go skydiving, go birding, or fish by the Cape May Estuary." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Cheesequake State Park", Description="Camp, picnic, bike, and hike through varied ecosystems in this beautiful state park." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "High Point State Park", Description="Hike up to the summit of Kittatinny Ridge and enjoy spectacular views of NJ from its highest peak." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Liberty State Park", Description="Enjoy views of the Statue of Liberty and the Manhattan skyline." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Six Flags Great Adventure", Description = "Feel the thrill of the world's tallest rollercoaster at New Jersey's top theme park." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Grounds for Sculpture", Description = "Walk through the 42 acres of park in awe of hundreds of contemporary sculptures." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Mountain Creek Resort (seasonal)", Description = "Ski through over 167 skiable acres and 1,000 feet of vertical skiing trails during the winter months." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Branch Brook Park (seasonal)", Description = "Visit Branch Brook Park in early April to see the blooming cherry blossoms that the park is famed for." }
            };
        }
        
        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}