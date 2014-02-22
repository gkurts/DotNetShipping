using DotNetShipping.ShippingProviders;
using Xunit;

namespace DotNetShipping.Tests.Features
{
    public class Functionality
    {
        [Fact]
        public void UPS_Should_Default_To_Live_URL()
        {
            var upsProvider = new UPSProvider("", "", "", "Nothing Really"); //doesn't matter - not transmitting anything
            Assert.True(!upsProvider.UseTestEnvironment);
        }

        [Fact]
        public void UPS_Should_BeSwitchable_To_CIE_URL()
        {
            var upsProvider = new UPSProvider("", "", "", "Nothing Really"); //doesn't matter - not transmitting anything
            upsProvider.UseTestEnvironment = false;
            Assert.False(upsProvider.UseTestEnvironment);
        }
    }
}