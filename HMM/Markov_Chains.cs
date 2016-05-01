using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNotes.ML
{
    public class Markov_Chains
    {
        private List<KeyValuePair< KeyValuePair<string, string>, decimal>> probability = new List<KeyValuePair<KeyValuePair<string, string>, decimal>>();
        private Dictionary<KeyValuePair<string, string>, int> frequancy = new Dictionary<KeyValuePair<string, string>, int>();


        public void learn(string[] data)
        {

            List<string> ListOfData = new List<string>(data.ToList<string>());

            // Build up the count table

            StringBuilder x_1String = new StringBuilder("");
            int totalElements = 0;

            foreach (string item in ListOfData)
            {

                KeyValuePair<string, string> currentItem = new KeyValuePair<string, string>(x_1String.ToString(), item);

                if (frequancy.Keys.Contains(currentItem))
                {
                    frequancy[currentItem]++;
                } else
                {
                    frequancy.Add(currentItem, 0);
                }

                totalElements++;
                x_1String = new StringBuilder(item);

            }

            // build the frequancy table

            foreach (KeyValuePair<KeyValuePair<string,string>,int> item in frequancy)
            {

                KeyValuePair<string, string> currentItem = item.Key;
                KeyValuePair<KeyValuePair<string, string>, decimal> itemToAdd = new KeyValuePair<KeyValuePair<string, string>, decimal>(currentItem, item.Value / totalElements);

                probability.Add(itemToAdd);


            }





        }

        public string next(string x_1Word, decimal varance)
        {

            Dictionary<string, decimal> nextLikely = new Dictionary<string, decimal>();

            foreach (KeyValuePair<KeyValuePair<string, string>, decimal> item in probability)
            {

                Random PRNG = new Random(DateTime.Now.Millisecond);
                
                KeyValuePair<string, string> wordPair = item.Key;
                if (wordPair.Key == x_1Word)
                {
                    nextLikely.Add(wordPair.Value, item.Value + (decimal)PRNG.NextDouble());
                }
                
            }

            List<KeyValuePair<string,decimal>> nextLikelyInOrder = nextLikely.ToList();

            nextLikelyInOrder.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            string returnValue = "";

            if (nextLikelyInOrder.Count > 0 )
            {
                returnValue = nextLikelyInOrder[0].Key;
            }

            return returnValue; 

        }

    }
}
