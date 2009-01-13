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
        public void Test_SubString02() {
            string[] ss = new string[1];
            ss[0] = "\u8000";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString03() {
            string[] ss = new string[1];
            ss[0] = "\u8000";
            this.Test_SubString(ss, 0, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString05() {
            string[] ss = new string[1];
            ss[0] = "\u8000\u8000\u8000";
            this.Test_SubString(ss, 2, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString08() {
            string[] ss = new string[1];
            ss[0] = new string('\u8000', 30);
            this.Test_SubString(ss, 4, 21);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString09() {
            string[] ss = new string[3];
            ss[0] = new string('\0', 14);
            ss[1] = "\u0400\0\0\0\0\0\0\0\0\0\0\0\0\0";
            ss[2] = "";
            this.Test_SubString(ss, 1, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString10() {
            string[] ss = new string[4];
            ss[0] = "\u8000";
            ss[1] = "";
            ss[2] = "";
            ss[3] = "";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString11() {
            string[] ss = new string[3];
            ss[0] = "\u8000\u8000\u8000";
            ss[1] = new string('\0', 14);
            ss[2] = "";
            this.Test_SubString(ss, 0, 3);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString18() {
            string[] ss = new string[3];
            ss[0] = "\u0800";
            ss[1] = "\0";
            ss[2] = "";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString20() {
            string[] ss = new string[3];
            ss[0] = "\u2000\u2000\u2000\u2000";
            ss[1] = new string('\0', 13);
            ss[2] = "";
            this.Test_SubString(ss, 0, 17);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString21() {
            string[] ss = new string[3];
            ss[0] = new string('\0', 18);
            ss[1] = "\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000";
            ss[2] = "";
            this.Test_SubString(ss, 1, 17);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString28() {
            string[] ss = new string[3];
            ss[0] = new string('\u4000', 14);
            ss[1] = "\0\0\0\0";
            ss[2] = "";
            this.Test_SubString(ss, 0, 17);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString29() {
            string[] ss = new string[3];
            ss[0] = "\u8000";
            ss[1] = new string('\0', 16);
            ss[2] = "";
            this.Test_SubString(ss, 0, 6);
        }

    }
}
