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
        public void Test_Indexing01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            this.Test_Indexing("\u0010", 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing02() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            this.Test_Indexing
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing03() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true);
            this.Test_Indexing
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing04() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)100);
            this.Test_Indexing
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing17() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(3, "goDeeper", (object)true);
            this.Test_Indexing
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing18() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true);
            this.Test_Indexing(new string('\u0001', 100), 60);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing19() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true);
            this.Test_Indexing(new string('\u0001', 100), 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing20() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)1);
            this.Test_Indexing(new string('\u0001', 100), 60);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing21() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)5)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)1);
            this.Test_Indexing(new string('\u0001', 100), 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing22() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)100)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(6, "length1", (object)100);
            this.Test_Indexing
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing23() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)94);
            this.Test_Indexing(new string('\u4000', 100), 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing24() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)94)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)80);
            this.Test_Indexing(new string('\u0200', 100), 48);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing25() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)93)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)86);
            this.Test_Indexing(new string('\u0002', 100), 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Indexing26() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(7, "goDeeper", (object)true)
                .At(9, "goDeeper", (object)true)
                .At(11, "goDeeper", (object)true)
                .At(12, "length1", (object)92);
            this.Test_Indexing(new string(' ', 100), 96);
        }

    }
}
