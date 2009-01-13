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
        public void Test_TrimStart01() {
            string[] ss = new string[1];
            char[] cs = new char[1];
            ss[0] = "\u8000";
            cs[0] = '\u8000';
            this.Test_TrimStart(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart03() {
            string[] ss = new string[1];
            char[] cs = new char[1];
            ss[0] = "\u8000";
            this.Test_TrimStart(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart14() {
            string[] ss = new string[1];
            char[] cs = new char[0];
            ss[0] = "\u1680";
            this.Test_TrimStart(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart15() {
            string[] ss = new string[1];
            char[] cs = new char[0];
            ss[0] = "\u1680\u2000";
            this.Test_TrimStart(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart16() {
            string[] ss = new string[1];
            char[] cs = new char[0];
            ss[0] =
              "\u1680\0\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680";
            this.Test_TrimStart(ss, cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart17() {
            string[] ss = new string[1];
            char[] cs = new char[0];
            ss[0] = "\u1680\0";
            this.Test_TrimStart(ss, cs);
        }

    }
}
