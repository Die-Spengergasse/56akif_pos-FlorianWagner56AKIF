using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCollection.App
{
    public class Teacher : Person
    {
        public override string GetArriveType()
        {
            return "Reist meist mit dem Auto an.";
        }
    }
}
