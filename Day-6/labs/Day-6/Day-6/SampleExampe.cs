using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class SampleFile
    {
        public SampleFile()
        {
                
        }
        ~ SampleFile()
        {

        }
    }
    class SampleImplemation : IDisposable
    {
        bool isDisposing = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                if(disposing)
                {
                    //
                }
                isDisposing = true;
            }
        }

        ~SampleImplemation()
        {
            Dispose(false);
        }
    }
    internal class SampleExampe
    {

        public static void Main3()
        {
            SampleImplemation sample=new SampleImplemation();
            sample.Dispose();

        }
    }
}
