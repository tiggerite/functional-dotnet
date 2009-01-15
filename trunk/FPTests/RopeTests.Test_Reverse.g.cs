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
        public void Test_Reverse01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            this.Test_Reverse("@");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse02() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            this.Test_Reverse(new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse13() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true);
            this.Test_Reverse(new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse14() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)126)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)126);
            this.Test_Reverse(new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse15() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)120)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)109)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true);
            this.Test_Reverse(new string('\u0002', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse16() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)104)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)97)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true)
                .At(11, "goDeeper", (object)true)
                .At(12, "length1", (object)15);
            this.Test_Reverse(new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse17() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)119)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)112)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true);
            this.Test_Reverse(new string('\b', 126));
        }

    }
}
