using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNotes.ML.Models
{
    class Chi_squared_data_row
    {

        private List<float> data { get; set; }
        public List<float> ExpectedFrequancy { get; set; }
        private float total { get; set; }

        public string name { get; set; }


        Chi_squared_data_row()
        {
            data = new List<float>();
            name = Guid.NewGuid().ToString();

        }

        Chi_squared_data_row(string title)
        {
            data = new List<float>();
            name = title;
        }


        public void AddDataItem(float newValue)
        {
            data.Add(newValue);
        }

        public float getItemAtPosition(int position)
        {
            if (position > data.Count)
            {
                throw new IndexOutOfRangeException("The position searched for is a larger number then the size of the list");
            }
            return data.ElementAt(position);

        }

        public float Sum()
        {
            return data.Sum();
        }

        public int Count()
        {
            return data.Count();
        }
        
        
    }
}
