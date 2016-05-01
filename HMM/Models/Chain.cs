using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNotes.ML.Models
{
    class StringChain
    {
        /// <summary>
        /// x-1 (the pre string)
        /// Written by the user application read by the processor
        /// </summary>
        public string x_1 { get; set; }

        /// <summary>
        /// x (the present string)
        /// Written by the processor and read by the user application.
        /// </summary>
        public string x { get; set; }
    }
}
