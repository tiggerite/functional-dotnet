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
        public void Test_Enumeration01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            this.Test_Enumeration("\u0001");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration03() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            this.Test_Enumeration(
            "\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0"
            );
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration04() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true);
            this.Test_Enumeration(
            "\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0"
            );
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration05() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)126);
            this.Test_Enumeration(
            "\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0"
            );
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration06() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1);
            this.Test_Enumeration(new string('\u8000', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration07() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)3);
            this.Test_Enumeration(new string('\u8000', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration08() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)126)
                .At(3, "goDeeper", (object)true);
            this.Test_Enumeration(
            "\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0"
            );
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration09() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)126)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true);
            this.Test_Enumeration(
            "\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0"
            );
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration10() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)94)
                .At(3, "goDeeper", (object)true);
            this.Test_Enumeration(new string('\u0001', 100));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration11() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)126)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(6, "length1", (object)126);
            this.Test_Enumeration(
            "\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0"
            );
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration12() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)93);
            this.Test_Enumeration(new string('\b', 100));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration13() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)6);
            this.Test_Enumeration(new string('\u1000', 100));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration14() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)125)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true)
                .At(8, "length1", (object)94);
            this.Test_Enumeration(new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration15() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)13)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true)
                .At(8, "length1", (object)7);
            this.Test_Enumeration(new string('\u1000', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Enumeration16() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)125)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true)
                .At(8, "length1", (object)119);
            this.Test_Enumeration(new string('\u4000', 126));
        }

    }
}
