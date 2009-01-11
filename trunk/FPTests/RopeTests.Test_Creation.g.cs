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
        public void Test_Creation01() {
            string[] ss = new string[0];
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation03() {
            string[] ss = new string[1];
            ss[0] = new string('\0', 508);
            this.Test_Creation(ss);
        }

        [Fact]
        public void Test_Creation04() {
            string[] ss = new string[2];
            ss[0] = new string('\0', 256);
            ss[1] = new string('\0', 256);
            this.Test_Creation(ss);
        }

    }
}
