using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public interface IComponent
    {
        string Title { get; set; }
        void Draw();
        void AddComponent(IComponent component);

    }

    public class Map : IComponent 
    { 
        private readonly List<IComponent> _map = new List<IComponent>();

        public string Title { get; set; }
        public Map(string Title)
        {
            this.Title = Title;
        }
        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }

        public string Find(Predicate<IComponent> predicate)
        {
            foreach (IComponent i in _map)
            {
                if (predicate(i))
                {
                    return i.Title;
                }
            }
            return null;
        }
        public void Draw()
        {
            Console.WriteLine(Title);
        }

    }

    public class Leaf: IComponent
    {
        public string Title { get; set; }
        public Leaf(string Title)
        { }
        public void Draw()
        {
            Console.WriteLine(Title);
        }

        public void AddComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

    }
}
