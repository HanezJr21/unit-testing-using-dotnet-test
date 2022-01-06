using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
		{
			bool result=true;
			if (candidate == 1)
			{
				result=false;
			}
			else if (candidate == 2)
			{
				result=true;
			}
			return result;
		}
    }
}