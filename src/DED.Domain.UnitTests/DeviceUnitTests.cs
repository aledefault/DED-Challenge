using System;
using System.Collections.Generic;
using Xunit;

namespace DED.Domain.UnitTests
{
    public class DeviceUnitTests
    {
        [Theory]
        [MemberData(nameof(GetValidDevices))]
        public void Is_a_valid_device(Device device)
        {
            Assert.True(device.IsValid());
        }

        [Theory]
        [MemberData(nameof(GetInvalidDevices))]
        public void Is_a_invalid_device(Device device)
        {
            Assert.False(device.IsValid());
        }

        public static IEnumerable<object[]> GetValidDevices()
        {
            yield return new[]
            {
                new Gateway(Guid.NewGuid(), "34001018B720004557", "1.1.1.1", 0, "X", "Pro")
            };

            yield return new[]
            {
                new WaterMeter(Guid.NewGuid(), "34001018B720004557", "X", "")
            };

            yield return new[]
            {
                new EnergyMeter(Guid.NewGuid(), "34001018B720004557", "X", "Deluxe")
            };
        }

        public static IEnumerable<object[]> GetInvalidDevices()
        {
            yield return new[]
            {
                new Gateway(Guid.NewGuid(), "34001018B72000455", "1.1.1.1", 0, "X", "")
            };

            yield return new[]
            {
                new Gateway(Guid.NewGuid(), "34001018B720004557", "1.1.1", 0, "X", "")
            };

            yield return new[]
            {
                new Gateway(Guid.NewGuid(), "34001018B720004557", "1.1.1", 65536, "X", "")
            };

            yield return new[]
            {
                new Gateway(Guid.NewGuid(), "34001018B720004557", "1.1.1", 0, "X", "")
            };

            yield return new[]
            {
                new Gateway(Guid.NewGuid(), "34001018B720004557", "1.1.1", -1, "X", "")
            };

            yield return new[]
            {
                new WaterMeter(Guid.NewGuid(), "34001018B72004557", "X", "")
            };

            yield return new[]
            {
                new EnergyMeter(Guid.NewGuid(), "34001018B72004557", "X", "")
            };
        }
    }
}
