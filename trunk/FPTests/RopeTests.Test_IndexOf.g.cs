// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Xunit;
using Microsoft.Pex.Framework.Generated;

namespace FPTests
{
    public partial class RopeTests {

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_IndexOf02() {
            this.Test_IndexOf("\0", '\u0001');
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_IndexOf03() {
            this.Test_IndexOf("\0\0", '\u0001');
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_IndexOf04() {
            this.Test_IndexOf("\0", '\0');
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_IndexOf06() {
            this.Test_IndexOf("", '\u0001');
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_IndexOf09() {
            this.Test_IndexOf("\0\0\0", '\u0001');
        }

    }
}
