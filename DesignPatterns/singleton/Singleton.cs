using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class Singleton
    {
        private static object lockObject = new object();
        private static Singleton _singleton;
        private Singleton() { }

        public static Singleton GetSingleton()
        {
            if (_singleton == null)
            {
                lock (lockObject)
                {
                    if (_singleton == null)
                    {
                        _singleton = new Singleton();
                        //return _singleton;
                    }

                }
            }
            return _singleton;
        }
    }
}
