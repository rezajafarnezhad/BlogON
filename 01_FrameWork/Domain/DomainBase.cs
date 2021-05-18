using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FrameWork.Domain
{
    public class DomainBase<T>
    {

        public T Id { get;private set; }
        public DateTime dateTime { get;private set; }



        public DomainBase()
        {
            dateTime = DateTime.Now;
        }

    }

    
}
