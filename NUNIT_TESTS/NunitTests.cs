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




    }
}