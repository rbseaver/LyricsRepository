using System;
using AutoMoqCore;
using NUnit.Framework;

namespace LyricsRepository.Tests.Unit
{
    [TestFixture]
    public abstract class TestBase
    {
        public AutoMoqer Mocker { get; private set; }

        [SetUp]
        public void SetUp() => Mocker = new AutoMoqer();
    }
}