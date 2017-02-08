/* 
 * Square Connect API
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Square.Connect.Client;
using Square.Connect.Api;
using Square.Connect.Model;

namespace Square.Connect.Test
{
    /// <summary>
    ///  Class for testing RefundApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RefundApiTests
    {
        private RefundApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RefundApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RefundApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' RefundApi
            Assert.IsInstanceOf<RefundApi>( instance, "instance is a RefundApi");
        }

        
        /// <summary>
        /// Test CreateRefund
        /// </summary>
        [Test]
        public void CreateRefundTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string locationId = null;
            //string transactionId = null;
            //CreateRefundRequest body = null;
            //var response = instance.CreateRefund(authorization, locationId, transactionId, body);
            //Assert.IsInstanceOf<CreateRefundResponse> (response, "response is CreateRefundResponse");
        }
        
        /// <summary>
        /// Test ListRefunds
        /// </summary>
        [Test]
        public void ListRefundsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string locationId = null;
            //string beginTime = null;
            //string endTime = null;
            //string sortOrder = null;
            //string cursor = null;
            //var response = instance.ListRefunds(authorization, locationId, beginTime, endTime, sortOrder, cursor);
            //Assert.IsInstanceOf<ListRefundsResponse> (response, "response is ListRefundsResponse");
        }
        
    }

}
