using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //params verdigimiz zaman run icerisine istedigimiz kadar(virgul ile) IResult verebiliriz parametre olarak.
        //arka planda gönderdigimiz tüm parametreleri array halinde logics'e atiyor.
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if(!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }
    }
}
