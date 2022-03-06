using NUnit.Framework;
using FANTASY4YOU;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized;

namespace NUNIT_TESTS
{
    public class Tests
    {
        string username;
        int id;
        string password;
        int characterNumber;
        string characterName;
        int characterCreated;
        DatabaseController connection;
        LogicController logic;
        
        [SetUp]
        public void Setup()
        {
           
            connection = new DatabaseController();
            logic = new LogicController();
        }
        /// <summary>
        /// Tests for DataAccessLayer
        /// </summary>
        [Test]
        public void SelectUserIdFromDB()
        {
            username = "Tester";
            int result = connection.SelectUserIdFromDB(username);
            Assert.AreEqual(result, 3);
        }


        [Test]
        public void CheckIfUsernameExists()
        {
            username = "Tester";
            bool result = connection.CheckIfUsernameExists(username);
            Assert.IsTrue(result);
        }

        [Test]

        public void CheckIfUsernameExists2()
        {
            username = "Ezi";
            bool result = connection.CheckIfUsernameExists(username);
            Assert.IsFalse(result);
        }

        [Test]
        public void NumberOfCharactersCreated()
        {
            id = 3;
            
            int result = connection.NumberOfCharactersCreated(id);
            Assert.AreEqual(result,1);
        }

        [Test]
        public void CheckUserCredentials()
        {
            username = "Tester"; 
            password = "test";
            bool result = connection.CheckUserCredentials(username, password);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckUserCredentials2()
        {
            username = "Ezi";
            password = "12345";
            bool result = connection.CheckUserCredentials(username, password);
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckCharacterNameExistForUser()
        {
            characterName = "Tester";
            id = 3;
            bool result = connection.CheckCharacterNameExistForUser(characterName, id);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckCharacterNameExistForUser2()
        {
            characterName = "Alex";
            id = 3;
            bool result = connection.CheckCharacterNameExistForUser(characterName, id);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests for LogicLayer
        /// </summary>

        //!!!!Warning Check File for Username and Credentials before test!!!!
        [Test] 
        public void SelectUserId()
        {
            
            int result = logic.SelectUserId();
            Assert.AreEqual(result, 3);
        }

        //!!!!Warning Check File for Username and Credentials before test!!!!
        [Test]
        public void NumberOfCharactersCreatedLogic()
        {
            characterCreated = logic.NumberOfCharactersCreated();
            Assert.AreEqual(characterCreated, 2);
        }

        //!!!!Warning Check File for Username and Credentials before test!!!!
        [Test]
        public void ReadUsernameFromUsernameFile()
        {
            username = logic.ReadUsernameFromUsernameFile();
            Assert.AreEqual(username, "Tester");
        }

        //!!!!Warning Check File for Username and Credentials before test!!!!
        [Test]
        public void ReadUsernameFromCredentialsFile()
        {
            username = logic.ReadUsernameFromCredentialsFile();
            Assert.AreEqual(username, "Tester");
        }

        //!!!!Warning Check File for Username and Credentials before test!!!!
        [Test]
        public void ReadPasswordFromCredentialsFile()
        {
            password = logic.ReadPasswordFromCredentialsFile();
            Assert.AreEqual(password, "test");
        }

        [Test]
        public void CheckIfUsernameExistsLogic()
        {
            username = "Tester";
            bool result = logic.CheckIfUsernameExists(username);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckIfUsernameExistsLogic2()
        {
            username = "Tester2";
            bool result = logic.CheckIfUsernameExists(username);
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckCharacterNameExistForUserLogic()
        {
            characterName = "Tester";
            bool result = logic.CheckCharacterNameExistForUser(characterName);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckCharacterNameExistForUserLogic2()
        {
            characterName = "Tester1";
            bool result = logic.CheckCharacterNameExistForUser(characterName);
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckUserCredentialsLogic()
        {
            username = "Tester";
            password = "test";
            bool result = logic.CheckUserCredentials(username, password);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckUserCredentialsLogic2()
        {
            username = "Tester1";
            password = "test";
            bool result = logic.CheckUserCredentials(username, password);
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckIfTextBoxOnlyNumbers()
        {

            string textBox = "1234";
            bool result = logic.CheckIfTextBoxOnlyNumbers(textBox);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckIfTextBoxOnlyNumbers2()
        {

            string textBox = "awawaw";
            bool result = logic.CheckIfTextBoxOnlyNumbers(textBox);
            Assert.IsFalse(result);
        }
    }
}