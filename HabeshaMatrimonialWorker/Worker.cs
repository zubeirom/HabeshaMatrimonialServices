using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HabeshaMatrimonialWorker
{
    class Worker
    {
        public void ActivateWorker(Action action, int interval)
        {
            try
            {
                while(true)
                {
                    action(); 
                    Thread.Sleep(interval);
                }
            } catch(Exception e)
            {
                throw e;
            }
        }
    }
}
