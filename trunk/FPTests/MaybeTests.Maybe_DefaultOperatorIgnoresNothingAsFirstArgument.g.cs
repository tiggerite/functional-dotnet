// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using FP.Core;
using Xunit;
using Microsoft.Pex.Framework.Generated;

namespace FPTests
{
    public partial class MaybeTests {
        [Fact]
        [PexGeneratedBy(typeof(MaybeTests))]
        public void Maybe_DefaultOperatorIgnoresNothingAsFirstArgument01() {
            this.Maybe_DefaultOperatorIgnoresNothingAsFirstArgument(default(Maybe<int>));
        }

        [Fact]
        [PexGeneratedBy(typeof(MaybeTests))]
        [PexNotCompilable]
        public void Maybe_DefaultOperatorIgnoresNothingAsFirstArgument02() {
            /* 
            Maybe<int> maybe = default(Maybe<int>);
            // cannot set FP.Core.Maybe`1[System.Int32]._hasValue: field is not visible
            maybe._hasValue = true;
            this.Maybe_DefaultOperatorIgnoresNothingAsFirstArgument(maybe);
            */
        }

    }
}
