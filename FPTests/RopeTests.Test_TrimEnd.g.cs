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
        public void Test_TrimEnd01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[0];
            this.Test_TrimEnd("\u3000", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd02() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[1];
            this.Test_TrimEnd("\u0001", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd03() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[0];
            this.Test_TrimEnd("\u3000\u3000", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd04() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[0];
            this.Test_TrimEnd("\0 ", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd05() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true);
            char[] cs = new char[0];
            this.Test_TrimEnd
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd06() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true);
            char[] cs = new char[6];
            cs[0] = '\u0001';
            cs[1] = '\u0001';
            cs[2] = '\u0001';
            cs[3] = '\u0001';
            cs[4] = '\u0002';
            cs[5] = '\u0004';
            this.Test_TrimEnd
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0800\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        public void Test_TrimEnd07() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)3)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true);
            char[] cs = new char[6];
            this.Test_TrimEnd
                ("\0\0\0\0\0\0\0\0\0\u0002\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimEnd08() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true);
            char[] cs = new char[6];
            cs[0] = '\u0800';
            cs[1] = '\u0e00';
            cs[2] = '\u2c00';
            cs[3] = '\u0c02';
            cs[4] = '\u0800';
            cs[5] = '\u8c00';
            this.Test_TrimEnd
                ("\u0c00\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0c00\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800",
                cs);
        }

        [Fact]
        public void Test_TrimEnd09() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)100);
            char[] cs = new char[0];
            this.Test_TrimEnd(new string('\ufeff', 100), cs);
        }

        [Fact]
        public void Test_TrimEnd16() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)3)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true);
            char[] cs = new char[6];
            this.Test_TrimEnd
                ("\0\0\0\0\0\0\0\0\0\u0002\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        public void Test_TrimEnd18() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)100);
            char[] cs = new char[0];
            this.Test_TrimEnd(new string('\ufeff', 100), cs);
        }

    }
}
