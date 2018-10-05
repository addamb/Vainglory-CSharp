using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vainglory_CSharp.API;

namespace VaingloryCSharpTests
{
    [TestClass]
    public class VainGloryAPI_UnitTests
    {
        string token = "";
        [TestMethod]
        public void Test_VainGloryAPI_GetPlayersByIdsJson()
        {
            VainGloryAPI api = new VainGloryAPI(token);

            List<string> ids = new List<string>() { "8c67f3d4-18e9-11e5-b5eb-06eb725f8a76", "fdd0c2f2-6f07-11e5-aaca-06f4ee369f53" };

            var playersByIds = api.GetPlayersByIdsJson(ids);

            Assert.IsNotNull(playersByIds);
        }
    }
}
