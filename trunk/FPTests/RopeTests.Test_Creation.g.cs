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
        public void Test_Creation01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            this.Test_Creation(new string('\0', 126));
        }

        [Fact]
        public void Test_Creation02() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            this.Test_Creation(
            "\u2863\u8003\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863\u2863"
            );
        }

        [Fact]
        public void Test_Creation03() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            this.Test_Creation(
            "\u8033\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0"
            );
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation04() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            this.Test_Creation("@");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation06() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            this.Test_Creation(new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation07() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)126)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true);
            this.Test_Creation(new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation08() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)126)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)126);
            this.Test_Creation(new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation11() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true);
            this.Test_Creation(new string('\u0001', 100));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation14() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)93)
                .At(3, "goDeeper", (object)true);
            this.Test_Creation(new string('\u0001', 100));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation15() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)2)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)1);
            this.Test_Creation(new string('@', 100));
        }

    }
}
