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
        public void Test_Creation09() {
            string[] ss = new string[1];
            ss[0] = new string('\0', 510);
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation10() {
            string[] ss = new string[4];
            ss[0] = new string('\0', 510);
            ss[1] = new string('\0', 510);
            ss[2] = new string('\0', 510);
            ss[3] = new string('\0', 510);
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation11() {
            string[] ss = new string[2];
            ss[0] = new string('\0', 510);
            ss[1] = new string('\0', 510);
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation12() {
            string[] ss = new string[3];
            ss[0] = new string('\0', 510);
            ss[1] = new string('\0', 510);
            ss[2] = new string('\0', 510);
            this.Test_Creation(ss);
        }

    }
}
