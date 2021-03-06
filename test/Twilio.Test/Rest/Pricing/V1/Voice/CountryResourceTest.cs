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
using Twilio.Rest.Pricing.V1.Voice;

namespace Twilio.Tests.Rest.Pricing.V1.Voice 
{

    [TestFixture]
    public class CountryTest : TwilioTest 
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Pricing,
                "/v1/Voice/Countries",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CountryResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"countries\": [{\"country\": \"Andorra\",\"iso_country\": \"AD\",\"url\": \"https://pricing.twilio.com/v1/Voice/Countries/AD\"}],\"meta\": {\"first_page_url\": \"https://pricing.twilio.com/v1/Voice/Countries?PageSize=50&Page=0\",\"key\": \"countries\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://pricing.twilio.com/v1/Voice/Countries?PageSize=50&Page=0\"}}"
                                     ));

            var response = CountryResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"countries\": [],\"meta\": {\"first_page_url\": \"https://pricing.twilio.com/v1/Voice/Countries?PageSize=50&Page=0\",\"key\": \"countries\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://pricing.twilio.com/v1/Voice/Countries?PageSize=50&Page=0\"}}"
                                     ));

            var response = CountryResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Pricing,
                "/v1/Voice/Countries/US",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CountryResource.Fetch("US", client: twilioRestClient);
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
                                         "{\"country\": \"United States\",\"inbound_call_prices\": [{\"current_price\": \"0.0085\",\"number_type\": \"local\",\"base_price\": \"0.0085\"},{\"current_price\": \"0.022\",\"number_type\": \"toll free\",\"base_price\": \"0.022\"}],\"iso_country\": \"US\",\"outbound_prefix_prices\": [{\"prefixes\": [\"1907\"],\"current_price\": \"0.090\",\"friendly_name\": \"Programmable Outbound Minute - United States - Alaska\",\"base_price\": \"0.090\"}],\"price_unit\": \"USD\",\"url\": \"https://pricing.twilio.com/v1/Voice/Countries/US\"}"
                                     ));

            var response = CountryResource.Fetch("US", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}