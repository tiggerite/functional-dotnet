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
        public void Test_Indexing02() {
            string[] ss = new string[2];
            ss[0] = "\u8000\u8000\u8000\u8000";
            ss[1] = new string('\u8000', 26);
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing03() {
            string[] ss = new string[2];
            ss[0] = "\u8000";
            ss[1] = new string('\u8000', 26);
            this.Test_Indexing(ss, 4);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing04() {
            string[] ss = new string[2];
            ss[0] = new string('\u2000', 26);
            ss[1] = new string('\u8000', 16);
            this.Test_Indexing(ss, 28);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing05() {
            string[] ss = new string[2];
            ss[0] = "\u8000\u8000";
            ss[1] = "\u8000";
            this.Test_Indexing(ss, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing06() {
            string[] ss = new string[2];
            ss[0] = "\u8000\u8000\u8000";
            ss[1] = "";
            this.Test_Indexing(ss, 0);
        }

    }
}
