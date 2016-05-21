using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNotes.ML.Models
{
    class Chi_squared_footer
    {
        
        private List<float> data { get; set; }
        
        public void Clear()
        {
            data.Clear();
        }

        public void Add(float total)
        {
            data.Add(total);
        }

    }
}
