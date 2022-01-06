using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnSuccess()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(3);
			Assert.True(result,"Success");
        }
		
		[Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);
			Assert.False(result,"Fail");
        }
		
		[Fact]
        public void IsPrime_InputIs1_ReturnFalse2()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);
			Assert.False(result,"Fail");
        }
		
		[Fact]
        public void IsPrime_InputIs1_ReturnSuccess2()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(3);
			Assert.True(result,"Success");
        }
		
		[Fact]
        public void IsPrime_InputIs1_ReturnSuccess3()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(3);
			Assert.True(result,"Success");
        }
    }
}