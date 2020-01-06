﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseApp.Tests
{
    public class BirthdayTest
    {
        [Fact]
        public void TestBirthdayEqualsCurrentDate()
        {
            var ecString = "Years 0, mounth 0, days 0";
            Birthday birthday = new Birthday(DateTime.Now);
            Assert.Equal(ecString, birthday.ToString());
        }

        [Fact]
        public void TestBirthdayBeforeCurrentDate()
        {
            var ecString = "Years 18, mounth 219, days 6690";
            Birthday birthday = new Birthday(new DateTime(2001, 9, 12));
            Assert.Equal(ecString, birthday.ToString());
        }

        [Fact]
        public void TestBirthdayAfterCurrentDate()
        {
            var ecString = "Years 0, mounth 0, days 0";
            Birthday birthday = new Birthday(new DateTime(3002, 9, 12));
            Assert.Equal(ecString, birthday.ToString());
        }
    }
}
