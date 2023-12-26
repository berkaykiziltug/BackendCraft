using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //base in 2 parametreli olan constructorini calistir demek.
        public SuccessResult(string message) : base(true, message)
        {
            
        }

        //mesaj vermek istemiyorsak direkt olarak base class'in tek parametreli, success'i true olan constructoru calistiririz.
        public SuccessResult() : base(true)
        {

        }
    }
}
