using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplementation
{
    internal class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
