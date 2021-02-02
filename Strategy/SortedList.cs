using System.Collections.Generic;

namespace Strategy
{
    public class SortedList<T> where T : class
    {
        private List<T> items;

        public SortedList()
        {
            this.items = new List<T>();
            this.SortStrategy = new BubbleSort();
        }

        public SortStrategy SortStrategy { get; set; }

        public void Sort()
        {
            this.SortStrategy.Sort(items);
        }
    }
}