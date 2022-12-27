using Buisness.Models;
using Buisness.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class DBTest
    {
        [TestMethod]
        public void aRegisterUserTest()
        {
            Database.Register("Олег Олегов", "oleg", "oleg");
        }

        [TestMethod]
        public void bGetUser()
        {
            Database.GetUser("oleg", "oleg");
        }

        [TestMethod]
        public void cGetUserByName()
        {
            Database.GetUserByUsername("oleg");
        }

        [TestMethod]
        public void dHealthcheck()
        {
            Database.HealthCheck();
        }

        [TestMethod]
        public void eGetCert()
        {
            Database.GetCertificateById(1);
        }

        [TestMethod]
        public void fDeleteUser()
        {
            User user = Database.GetUser("oleg", "oleg");
            if (user != null)
            {
                Database.DeleteUserById(user.Id);
            }
        }

        [TestMethod]
        public void gGetUsers()
        {
            Database.GetUsers();
        }
    }

    [TestClass]
    public class PerformanceTest
    {
        private static int records = 1000;
        private static Random rndm = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwqyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rndm.Next(s.Length)]).ToArray());
        }


        [TestMethod]
        public void aRegisterPerformance()
        {
            Database.Register("test", "test", "test");
            
            for (int i = 0; i < records - 1; i++)
            {
                Database.Register(RandomString(10), RandomString(10), RandomString(10));
            }
        }

        [TestMethod]
        public void bDeletePerformance()
        {
            User user = Database.GetUser("test", "test");
            for (int i = user.Id; i < user.Id + records; i++)
            {
                Database.DeleteUserById(i);
            }
        }
    }

    [TestClass]
    public class NullField
    {
        [TestMethod]
        [ExpectedException(typeof(MySqlException), "Column 'name' cannot be null.")]
        public void NullName()
        {
            Database.Register(null, "ex", "ex");
        }

        [TestMethod]
        [ExpectedException(typeof(MySqlException), "Column 'password' cannot be null.")]
        public void NullPassword()
        {
            Database.Register("ex", "ex", null);
        }

        [TestMethod]
        [ExpectedException(typeof(MySqlException), "Column 'username' cannot be null.")]
        public void NullUsername()
        {
            Database.Register("ex", null, "ex");
        }
    }
}