using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrowserLibrary;
using assemblyBrowser;

namespace UnitTestAssembly
{
    [TestClass]
    public class UnitTest1
    {
        InformAboutAssembly inform;
        List<NameSpaceClass> list;
        [TestInitialize]
        public void Init()
        {
            inform = new InformAboutAssembly(@"..\..\Json.dll");
            list = inform._namespaces;
        }
        [TestMethod]
        public void TestNotNull()
        {
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void TestNameJson()
        {
            Assert.AreEqual("Json",list[0]._nameNameSpace);
        }

        [TestMethod]
        public void TestClassName()
        {
            Assert.AreEqual("JsonToken",list[0]._classes[0]._nameClass);
        }

        [TestMethod]
        public void TestClassCount()
        {
            Assert.IsTrue(list[0]._classes.Count == 1);
        }

        [TestMethod]
        public void TestProperties()
        {
            Assert.IsTrue(list[1]._classes[0]._properties != null);
            Assert.IsTrue(list[1]._classes[0]._properties.Count > 0);
            Assert.IsFalse(list[1]._classes[0]._abstract);
            Assert.IsTrue(list[1]._classes[0]._class);
            Assert.IsFalse(list[1]._classes[0]._interface);
            Assert.IsTrue(list[1]._classes[0]._public);
            Assert.IsTrue(list[1]._classes[0]._methods[16]._public);
            Assert.IsFalse(list[1]._classes[0]._methods[16]._static);
            Assert.IsTrue(list[1]._classes[0]._properties[4]._public);
            Assert.IsTrue(list[1]._classes[0]._properties[4]._read);
            Assert.IsFalse (list[1]._classes[0]._properties[4]._write);

        }

        [TestMethod]
        public void TestFields()
        {
            Assert.IsFalse(list[0]._classes[0]._fields.Count == 0);
            Assert.IsTrue(list[0]._classes[0]._fields.Count > 4);
            Assert.IsTrue(list[1]._classes[0]._fields.Count == 0);
        }

        [TestMethod]
        public void TestMethodName()
        {
            Assert.AreEqual("GetType",list[7]._classes[0]._methods[3]._nameMethod);
            Assert.IsNotNull(list[3]._classes[0]._methods.Find(x => x._nameMethod == "TryGetMember"));
        }

        [TestMethod]
        public void TestMethodCount()
        {
            Assert.IsTrue(list[0]._classes[0]._methods.Count > 4);
            Assert.IsTrue(list[1]._classes[0]._methods.Count > 6);
            
        }
    }
}
