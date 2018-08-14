using BotClient.Commands.Input;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.BotClient.Commands.Input
{
    [TestClass]
    public class InputCommandLexerTests
    {
        [TestMethod]
        public void TestSingleParameter()
        {
            string input = "!join vorago Lutson";

            var userCommandInput = InputCommandLexer.ToCommandInput(input);
            Assert.AreEqual('!', userCommandInput.FirstToken);
            Assert.AreEqual("join", userCommandInput.Name);
            string[] expectedParams = { "vorago", "Lutson" };
            Assert.AreEqual(expectedParams[0], userCommandInput.Parameters[0]);
            Assert.AreEqual(expectedParams[1], userCommandInput.Parameters[1]);
        }

        [TestMethod]
        public void TestMultiParameter()
        {
            string input = @"!join vorago ""Lut son"" ";

            var userCommandInput = InputCommandLexer.ToCommandInput(input);
            Assert.AreEqual('!', userCommandInput.FirstToken);
            Assert.AreEqual("join", userCommandInput.Name);
            string[] expectedParams = { "vorago", "Lut son" };
            Assert.AreEqual(expectedParams[0], userCommandInput.Parameters[0]);
            Assert.AreEqual(expectedParams[1], userCommandInput.Parameters[1]);

        }
    }
}
