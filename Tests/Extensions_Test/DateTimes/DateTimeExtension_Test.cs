using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Extensions.DateTimes;
using Shouldly;

namespace Extensions_Test.DateTimes
{
    public class DateTimeExtension_Test
    {
        [Fact]
        public void ToUnixTimeStamp_UnixEpoch_Test()
        {
            //Arrange
            try
            {
                var time = DateTime.UnixEpoch;
                //Act
                var timeStamp = time.ToUnixTimeStamp();
                //Assert
                timeStamp.ShouldBeEquivalentTo((double)0);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Fact]
        public void ToUnixTimeStamp_Exception_Test()
        {
            try
            {
                var time = DateTime.UnixEpoch - TimeSpan.FromMinutes(60);
                var timeStamp = time.ToUnixTimeStamp();
            }
            catch (Exception ex)
            {
                ex.ShouldBeOfType<ArgumentOutOfRangeException>();
            }
        }

        [Fact]
        public void ToUnixTimeStamp_Test()
        {
            try
            {
                var time = new DateTime(2000,1,1,0,0,0);
                var timeStamp = time.ToUnixTimeStamp();
                timeStamp.ShouldBe((double)946684800);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
