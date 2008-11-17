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
    public partial class RASequenceTests {
        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt01() {
            int[] ints = new int[1];
            this.Test_SplitAt<int>(ints, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt02() {
            int[] ints = new int[2];
            this.Test_SplitAt<int>(ints, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt03() {
            int[] ints = new int[2];
            this.Test_SplitAt<int>(ints, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt04() {
            int[] ints = new int[3];
            this.Test_SplitAt<int>(ints, 2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt05() {
            int[] ints = new int[3];
            this.Test_SplitAt<int>(ints, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt06() {
            int[] ints = new int[6];
            this.Test_SplitAt<int>(ints, 2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt07() {
            int[] ints = new int[6];
            this.Test_SplitAt<int>(ints, 4);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt08() {
            int[] ints = new int[14];
            this.Test_SplitAt<int>(ints, 2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt09() {
            int[] ints = new int[15];
            this.Test_SplitAt<int>(ints, 13);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt10() {
            int[] ints = new int[31];
            this.Test_SplitAt<int>(ints, 2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt11() {
            int[] ints = new int[14];
            this.Test_SplitAt<int>(ints, 6);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt12() {
            int[] ints = new int[31];
            this.Test_SplitAt<int>(ints, 15);
        }

        [Fact]
        [PexGeneratedBy(typeof(RASequenceTests))]
        public void Test_SplitAt13() {
            int[] ints = new int[31];
            this.Test_SplitAt<int>(ints, 3);
        }

    }
}
