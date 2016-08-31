using System.IO;
// <copyright file="ActionExpressionTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleEngine.Decisions.Tests;

namespace RuleEngine.Decisions.Tests.Tests
{
    [TestClass]
    [PexClass(typeof(ActionExpression))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ActionExpressionTest
    {

        [PexMethod]
        [PexAllowedException(typeof(DirectoryNotFoundException))]
        public void double1([PexAssumeUnderTest]ActionExpression target)
        {
            target.double1();
            // TODO: 将断言添加到 方法 ActionExpressionTest.double1(ActionExpression)
        }
    }
}
