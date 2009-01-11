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
        public void Test_Concat01() {
            string[] ss = new string[0];
            this.Test_Concat(ss, ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat02() {
            string[] ss = new string[1];
            ss[0] = "";
            this.Test_Concat(ss, ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat03() {
            string[] ss = new string[1];
            string[] ss1 = new string[1];
            ss[0] = new string('\u4000', 27);
            ss1[0] = "\u4000";
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat04() {
            string[] ss = new string[4];
            string[] ss1 = new string[4];
            ss[0] = "\u8000";
            ss[1] = new string('\u8000', 29);
            ss[2] = new string('\u8000', 29);
            ss[3] = "\u8000\u8000\u8000";
            ss1[0] = "\u8000\u8000\u8000";
            ss1[1] = new string('\u8000', 29);
            ss1[2] = new string('\u2000', 25);
            ss1[3] = "\u0100\u0100\u0100\u0100\u0100\u0100\u0100\u0100";
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        public void Test_Concat05() {
            string[] ss = new string[2];
            string[] ss1 = new string[31];
            ss[0] = "\u1000";
            ss[1] = "\u1000";
            ss1[0] = new string('\u1000', 28);
            ss1[1] = new string('\u1000', 28);
            ss1[2] = "\u2000";
            ss1[3] = new string('\u1000', 28);
            ss1[4] = new string('\u1000', 28);
            ss1[5] = new string('\u1000', 28);
            ss1[6] = new string('\u1000', 28);
            ss1[7] = new string('\u1000', 28);
            ss1[8] = new string('\u1000', 28);
            ss1[9] = new string('\u1000', 28);
            ss1[10] = new string('\u1000', 28);
            ss1[11] = new string('\u1000', 28);
            ss1[12] = new string('\u1000', 28);
            ss1[13] = new string('\u1000', 28);
            ss1[14] = new string('\u1000', 28);
            ss1[15] = new string('\u1000', 28);
            ss1[16] = new string('\u1000', 28);
            ss1[17] = new string('\u1000', 28);
            ss1[18] = new string('\u1000', 28);
            ss1[19] = new string('\u1000', 28);
            ss1[20] = new string('\u1000', 28);
            ss1[21] = new string('\u1000', 28);
            ss1[22] = new string('\u1000', 28);
            ss1[23] = new string('\u1000', 28);
            ss1[24] = new string('\u1000', 28);
            ss1[25] = new string('\u1000', 28);
            ss1[26] = new string('\u1000', 28);
            ss1[27] = new string('\u1000', 28);
            ss1[28] = new string('\u1000', 28);
            ss1[29] = new string('\u1000', 28);
            ss1[30] = new string('\u1000', 28);
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat06() {
            string[] ss = new string[2];
            string[] ss1 = new string[0];
            ss[0] = "\u8000";
            ss[1] = "\u8000";
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat07() {
            string[] ss = new string[3];
            string[] ss1 = new string[0];
            ss[0] = "\u8000";
            ss[1] = "\u8000";
            ss[2] = "";
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        public void Test_Concat12() {
            string[] ss = new string[2];
            string[] ss1 = new string[31];
            ss[0] = "\u1000";
            ss[1] = "\u1000";
            ss1[0] = new string('\u1000', 28);
            ss1[1] = new string('\u1000', 28);
            ss1[2] = "\u2000";
            ss1[3] = new string('\u1000', 28);
            ss1[4] = new string('\u1000', 28);
            ss1[5] = new string('\u1000', 28);
            ss1[6] = new string('\u1000', 28);
            ss1[7] = new string('\u1000', 28);
            ss1[8] = new string('\u1000', 28);
            ss1[9] = new string('\u1000', 28);
            ss1[10] = new string('\u1000', 28);
            ss1[11] = new string('\u1000', 28);
            ss1[12] = new string('\u1000', 28);
            ss1[13] = new string('\u1000', 28);
            ss1[14] = new string('\u1000', 28);
            ss1[15] = new string('\u1000', 28);
            ss1[16] = new string('\u1000', 28);
            ss1[17] = new string('\u1000', 28);
            ss1[18] = new string('\u1000', 28);
            ss1[19] = new string('\u1000', 28);
            ss1[20] = new string('\u1000', 28);
            ss1[21] = new string('\u1000', 28);
            ss1[22] = new string('\u1000', 28);
            ss1[23] = new string('\u1000', 28);
            ss1[24] = new string('\u1000', 28);
            ss1[25] = new string('\u1000', 28);
            ss1[26] = new string('\u1000', 28);
            ss1[27] = new string('\u1000', 28);
            ss1[28] = new string('\u1000', 28);
            ss1[29] = new string('\u1000', 28);
            ss1[30] = new string('\u1000', 28);
            this.Test_Concat(ss, ss1);
        }

    }
}
