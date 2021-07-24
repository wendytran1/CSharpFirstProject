﻿using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            //Arrange
            StreamingContent content = new StreamingContent();

            content.Title = "Toy Story"; //call title here


            //Act
            string expected = "Toy Story";
            string actual = content.Title;


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
