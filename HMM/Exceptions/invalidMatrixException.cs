using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNotes.ML.Exceptions
{
[System.Serializable]
public class invalidMatrixException : Exception
    {
        public invalidMatrixException() { }
        public invalidMatrixException(string message) : base(message) { }
        public invalidMatrixException(string message, Exception inner) : base(message, inner) { }
        protected invalidMatrixException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    {
    }
}
