// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework;
using Xunit;

namespace FPTests
{
    public partial class RopeTests {
        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[0];
            this.Test_TrimStart("\u3000", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart02() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[1];
            this.Test_TrimStart("\u0001", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart03() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[0];
            this.Test_TrimStart("\u3000\u3000", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart04() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            char[] cs = new char[0];
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart05() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)114)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)114)
                .At(5, "goDeeper", (object)true);
            char[] cs = new char[0];
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0004\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart06() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)5);
            char[] cs = new char[2];
            cs[0] = '\u0400';
            cs[1] = '\u0200';
            this.Test_TrimStart("\0\0\0\u2000\0\0", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart07() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)5);
            char[] cs = new char[2];
            cs[0] = '\u4000';
            cs[1] = '\u0010';
            this.Test_TrimStart("\u4000\0\u0002\0\0\0", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart08() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)5);
            char[] cs = new char[1];
            this.Test_TrimStart("\0\0\u0080\0\0\u0080", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart09() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)5);
            char[] cs = new char[0];
            this.Test_TrimStart("\u1680\u1680\u1680\u1680\u1680\u1680", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart10() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true);
            char[] cs = new char[66];
            cs[0] = '\u0001';
            cs[1] = '\u0001';
            cs[2] = '\u0001';
            cs[3] = '\u0001';
            cs[4] = '\u0001';
            cs[5] = '\u0001';
            cs[6] = '\u0001';
            cs[7] = '\u0001';
            cs[8] = '\u0001';
            cs[9] = '\u0001';
            cs[10] = '\u0001';
            cs[11] = '\u0001';
            cs[12] = '\u0001';
            cs[13] = '\u0001';
            cs[14] = '\u0001';
            cs[15] = '\u0001';
            cs[16] = '\u0001';
            cs[17] = '\u0001';
            cs[18] = '\u0001';
            cs[19] = '\u0001';
            cs[20] = '\u0001';
            cs[21] = '\u0001';
            cs[22] = '\u0001';
            cs[23] = '\u0001';
            cs[24] = '\u0001';
            cs[25] = '\u0001';
            cs[26] = '\u0001';
            cs[27] = '\u0001';
            cs[28] = '\u0001';
            cs[29] = '\u0001';
            cs[30] = ' ';
            cs[31] = '\u8000';
            cs[32] = '\b';
            cs[33] = '\u0100';
            cs[34] = '\u0400';
            cs[35] = '\u0001';
            cs[36] = '\u0001';
            cs[37] = '\u0001';
            cs[38] = '\u0001';
            cs[39] = '\u0001';
            cs[40] = '\u0001';
            cs[41] = '\u0001';
            cs[42] = '\u0001';
            cs[43] = '\u0001';
            cs[44] = '\u0001';
            cs[45] = '\u0001';
            cs[46] = '\u0001';
            cs[47] = '\u0001';
            cs[48] = '\u0001';
            cs[49] = '\u0001';
            cs[50] = '\u0001';
            cs[51] = '\u0001';
            cs[52] = '\u0001';
            cs[53] = '\u0001';
            cs[54] = '\u0001';
            cs[55] = '\u0001';
            cs[56] = '\u0001';
            cs[57] = '\u0001';
            cs[58] = '\u0001';
            cs[59] = '\u0001';
            cs[60] = '\u0001';
            cs[61] = '\u0001';
            cs[62] = '\u0001';
            cs[63] = '\u0001';
            cs[64] = '\u0001';
            cs[65] = '\u0001';
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0010\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart11() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true);
            char[] cs = new char[66];
            cs[15] = '\u0005';
            cs[48] = '!';
            cs[62] = '\u8001';
            cs[65] = '\u0003';
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart12() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)2)
                .At(3, "goDeeper", (object)true);
            char[] cs = new char[0];
            this.Test_TrimStart
                ("\u1680\0\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680\u1680",
                cs);
        }

    }
}
