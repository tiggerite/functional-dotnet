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
        public void Test_TrimEnd01() {
            string[] ss = new string[1];
            char[] cs = new char[1];
            ss[0] = "\u8000";
            cs[0] = '\u8000';
            this.Test_TrimEnd(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd02() {
            string[] ss = new string[1];
            char[] cs = new char[1];
            ss[0] = "\u2000";
            cs[0] = '\u2800';
            this.Test_TrimEnd(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd03() {
            string[] ss = new string[1];
            char[] cs = new char[0];
            ss[0] = "\u1680";
            this.Test_TrimEnd(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd04() {
            string[] ss = new string[1];
            char[] cs = new char[1];
            ss[0] =
              "\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2010";
            cs[0] = '\u2010';
            this.Test_TrimEnd(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd05() {
            string[] ss = new string[1];
            char[] cs = new char[0];
            ss[0] = "\u1680\u2000";
            this.Test_TrimEnd(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd06() {
            string[] ss = new string[1];
            char[] cs = new char[1];
            ss[0] = "\u8000\0";
            this.Test_TrimEnd(ss, cs);
        }

    }
}
