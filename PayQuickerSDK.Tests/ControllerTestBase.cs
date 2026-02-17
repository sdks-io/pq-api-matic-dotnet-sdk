// <copyright file="ControllerTestBase.cs" company="APIMatic">
// PayQuickerSDK.Tests
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PayQuicker.API;
using PayQuicker.API.Authentication;
using PayQuicker.API.Exceptions;
using PayQuicker.API.Http.Client;
using PayQuicker.API.Models;
using PayQuicker.API.Models.Containers;

namespace PayQuicker.API
{
    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallback HttpCallBack { get; private set; } = new HttpCallback();

        /// <summary>
        /// Gets PayQuickerSDKClient Client.
        /// </summary>
        protected PayQuickerSDKClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            PayQuickerSDKClient config = PayQuickerSDKClient.CreateFromEnvironment();
            this.Client = config.ToBuilder()
                .HttpCallback(HttpCallBack)
                .Build();

        }
    }
}