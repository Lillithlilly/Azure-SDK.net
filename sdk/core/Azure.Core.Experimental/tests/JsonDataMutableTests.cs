// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class JsonDataMutableTests
    {
        [Test]
        public void ArrayItemsCanBeAssigned()
        {
            var json = JsonData.FromString("[0, 1, 2, 3]");
            json[1] = 2;
            json[2] = null;
            json[3] = "string";

            Assert.AreEqual(json.ToString(), "[0,2,null,\"string\"]");
        }

        [Test]
        public void ExistingObjectPropertiesCanBeAssigned()
        {
            var json = JsonData.FromString("{\"a\":1}");
            json["a"] = "2";

            Assert.AreEqual(json.ToString(), "{\"a\":\"2\"}");
        }
    }
}
