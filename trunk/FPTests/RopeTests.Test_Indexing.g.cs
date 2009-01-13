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
        public void Test_Indexing01() {
            string[] ss = new string[1];
            ss[0] = "\u8000";
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing03() {
            string[] ss = new string[2];
            ss[0] = new string('@', 14);
            ss[1] = new string('\0', 14);
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing04() {
            string[] ss = new string[2];
            ss[0] = new string('@', 14);
            ss[1] = new string('\0', 10);
            this.Test_Indexing(ss, 14);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing05() {
            string[] ss = new string[2];
            ss[0] = "\u8000";
            ss[1] = "\0";
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing06() {
            string[] ss = new string[2];
            ss[0] = "\u8000\0";
            ss[1] = "";
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing13() {
            string[] ss = new string[7];
            ss[0] = "";
            ss[1] = "";
            ss[2] = "";
            ss[3] = "";
            ss[4] = "";
            ss[5] = "";
            ss[6] = "\u8000\0\0\0\0\0";
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing14() {
            string[] ss = new string[6];
            ss[0] = "\0";
            ss[1] = "\0";
            ss[2] = "\0";
            ss[3] = "\0\0";
            ss[4] = "\u0400\u0400";
            ss[5] = "\0";
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing15() {
            string[] ss = new string[6];
            ss[0] = new string('\0', 15);
            ss[1] = "\0\0";
            ss[2] = "\u2000";
            ss[3] = "\0\0";
            ss[4] = "\0\0";
            ss[5] = "\0";
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing16() {
            string[] ss = new string[6];
            ss[0] = "\0\0\0\0";
            ss[1] = new string('\u2000', 15);
            ss[2] = "\0\0";
            ss[3] = "\0";
            ss[4] = "\0";
            ss[5] = "\0";
            this.Test_Indexing(ss, 0);
        }

    }
}
