using CustomGenericLinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomeGenericLinkedList.Tests
{
    [TestFixture]
    public class ListTests
    {
        [Test]
        public void Should_Add_integer_To_List()
        {
            //Arrange
            var numbers = new GenericList<int>();
            //Act
            numbers.Add(2);
            //Assert
            Assert.AreEqual(2, numbers.GetByPosition(0));

        }

        [Test]
        public void Should_Add_string_To_List()
        {
            //Arrange
            var word = new GenericList<string>();
            //Act
            word.Add("Dube");
            word.Add("John");
            word.AddByPositon("Jabulani",1);
            //Assert
            Assert.AreEqual("Jabulani", word.GetByPosition(1));

        }

        [Test]
        public void Delete_value_from_node()
        {
            //Arrange
            var word = new GenericList<string>();
            //Act
            word.Add("Dube");
            word.Add("John");
            word.DeleteByPosition(1);
            //Assert
            Assert.AreEqual("Dube", word.GetByPosition(0));

        }


        [Test]
        public void Display_node()
        {
            //Arrange
            var word = new GenericList<string>();
            //Act
            word.Add("Dube");
            word.Add("John");
            //Assert
            Assert.AreEqual("Dube,John,", word.DisplayNode());

        }

    }
}
