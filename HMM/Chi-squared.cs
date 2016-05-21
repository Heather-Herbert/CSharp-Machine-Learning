using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CryptoNotes.ML.Models;

namespace CryptoNotes.ML
{
    class Chi_squared
    {

        public List<Chi_squared_data_row> matrix { get; set; }
        public Chi_squared_footer footer { get; set; }

        Chi_squared()
        {
            matrix = new List<Chi_squared_data_row>();
            footer = new Chi_squared_footer();

        }

        public void Add(Chi_squared_data_row row)
        {
            foreach (Chi_squared_data_row item in matrix)
            {
                if (item.name == row.name)
                {
                    matrix.Remove(item);
                }
            }

            matrix.Add(row);
        }


        public float CalculatePValue

    }
}
