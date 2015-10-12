﻿/*
 * FOG Service : A computer management client for the FOG Project
 * Copyright (C) 2014-2015 FOG Project
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 3
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

using System.Text;
using FOG.Core;
using FOG.Core.Data;
using NUnit.Framework;

namespace FOGService.Tests.Core.Data
{
    [TestFixture]
    public class HashTests
    {
        [SetUp]
        public void Init()
        {
            Log.Output = Log.Mode.Console;
        }

        [Test]
        public void MD5()
        {
            // MD5 hash a known byte set
            var testBytes = Encoding.ASCII.GetBytes("TestString");
            const string md5 = "5B56F40F8828701F97FA4511DDCD25FB";

            var calculatedMD5 = Hash.MD5(testBytes);
            StringAssert.AreEqualIgnoringCase(md5, calculatedMD5);

            // Test invalid data
            Assert.IsNull(Hash.MD5((byte[]) null));
        }

        [Test]
        public void SHA512()
        {
            // MD5 hash a known byte set
            var testBytes = Encoding.ASCII.GetBytes("TestString");
            const string sha512 = "69DFD91314578F7F329939A7EA6BE4497E6FE3909B9C8F308FE711D29D4340D90D77B7FDF359B7D0DBEED940665274F7CA514CD067895FDF59DE0CF142B62336";

            var calculatedSHA512 = Hash.SHA512(testBytes);
            StringAssert.AreEqualIgnoringCase(sha512, calculatedSHA512);

            // Test invalid data
            Assert.IsNull(Hash.MD5((byte[])null));
        }
    }
}