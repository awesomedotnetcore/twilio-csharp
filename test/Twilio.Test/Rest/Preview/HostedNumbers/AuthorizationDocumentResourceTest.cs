/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Preview.HostedNumbers;

namespace Twilio.Tests.Rest.Preview.HostedNumbers 
{

    [TestFixture]
    public class AuthorizationDocumentTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/AuthorizationDocuments/PXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                AuthorizationDocumentResource.Fetch("PXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"address_sid\": \"AD11111111111111111111111111111111\",\"cc_emails\": [\"aaa@twilio.com\",\"bbb@twilio.com\"],\"date_created\": \"2017-03-28T20:06:39Z\",\"date_updated\": \"2017-03-28T20:06:39Z\",\"email\": \"test@twilio.com\",\"links\": {\"dependent_hosted_number_orders\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments/PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/DependentHostedNumberOrders\"},\"sid\": \"PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"signing\",\"url\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments/PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = AuthorizationDocumentResource.Fetch("PXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/AuthorizationDocuments/PXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                AuthorizationDocumentResource.Update("PXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"address_sid\": \"ADaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"cc_emails\": [\"test1@twilio.com\",\"test2@twilio.com\"],\"date_created\": \"2017-03-28T20:06:39Z\",\"date_updated\": \"2017-03-28T20:06:39Z\",\"email\": \"test+hosted@twilio.com\",\"links\": {\"dependent_hosted_number_orders\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments/PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/DependentHostedNumberOrders\"},\"sid\": \"PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"signing\",\"url\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments/PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = AuthorizationDocumentResource.Update("PXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/AuthorizationDocuments",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                AuthorizationDocumentResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"first_page_url\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments?PageSize=50&Page=0\",\"key\": \"items\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments?PageSize=50&Page=0\"},\"items\": []}"
                                     ));

            var response = AuthorizationDocumentResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"first_page_url\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments?PageSize=50&Page=0\",\"key\": \"items\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments?PageSize=50&Page=0\"},\"items\": [{\"address_sid\": \"ADaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"cc_emails\": [\"test1@twilio.com\",\"test2@twilio.com\"],\"date_created\": \"2017-03-28T20:06:39Z\",\"date_updated\": \"2017-03-28T20:06:39Z\",\"email\": \"test+hosted@twilio.com\",\"links\": {\"dependent_hosted_number_orders\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments/PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/DependentHostedNumberOrders\"},\"sid\": \"PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"signing\",\"url\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments/PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = AuthorizationDocumentResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/AuthorizationDocuments",
                ""
            );
            request.AddPostParam("HostedNumberOrderSids", Serialize("HostedNumberOrderSids"));
            request.AddPostParam("AddressSid", Serialize("ADXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            request.AddPostParam("Email", Serialize("Email"));
            request.AddPostParam("ContactTitle", Serialize("ContactTitle"));
            request.AddPostParam("ContactPhoneNumber", Serialize("ContactPhoneNumber"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                AuthorizationDocumentResource.Create(Promoter.ListOfOne("HostedNumberOrderSids"), "ADXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "Email", "ContactTitle", "ContactPhoneNumber", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"address_sid\": \"ADaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"cc_emails\": [\"test1@twilio.com\",\"test2@twilio.com\"],\"date_created\": \"2017-03-28T20:06:39Z\",\"date_updated\": \"2017-03-28T20:06:39Z\",\"email\": \"test+hosted@twilio.com\",\"links\": {\"dependent_hosted_number_orders\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments/PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/DependentHostedNumberOrders\"},\"sid\": \"PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"signing\",\"url\": \"https://preview.twilio.com/HostedNumbers/AuthorizationDocuments/PXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = AuthorizationDocumentResource.Create(Promoter.ListOfOne("HostedNumberOrderSids"), "ADXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "Email", "ContactTitle", "ContactPhoneNumber", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}