/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Conference 
{

    /// <summary>
    /// Fetch an instance of a participant
    /// </summary>
    public class FetchParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The string that uniquely identifies this conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Fetch by unique participant Call SID
        /// </summary>
        public string PathCallSid { get; }

        /// <summary>
        /// Construct a new FetchParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="pathCallSid"> Fetch by unique participant Call SID </param>
        public FetchParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Update the properties of this participant
    /// </summary>
    public class UpdateParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The string that uniquely identifies this conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Update a participant by their Call SID
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// Indicates if the participant should be muted
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// Specifying true will hold the participant, while false will un-hold.
        /// </summary>
        public bool? Hold { get; set; }
        /// <summary>
        /// The 'HoldUrl' attribute lets you specify a URL for music that plays when a participant is held.
        /// </summary>
        public Uri HoldUrl { get; set; }
        /// <summary>
        /// Specify GET or POST, defaults to GET
        /// </summary>
        public Twilio.Http.HttpMethod HoldMethod { get; set; }
        /// <summary>
        /// The 'AnnounceUrl' attribute lets you specify a URL for announcing something to the participant.
        /// </summary>
        public Uri AnnounceUrl { get; set; }
        /// <summary>
        /// Specify GET or POST, defaults to POST
        /// </summary>
        public Twilio.Http.HttpMethod AnnounceMethod { get; set; }

        /// <summary>
        /// Construct a new UpdateParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="pathCallSid"> Update a participant by their Call SID </param>
        public UpdateParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Hold != null)
            {
                p.Add(new KeyValuePair<string, string>("Hold", Hold.Value.ToString().ToLower()));
            }

            if (HoldUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("HoldUrl", Serializers.Url(HoldUrl)));
            }

            if (HoldMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("HoldMethod", HoldMethod.ToString()));
            }

            if (AnnounceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AnnounceUrl", Serializers.Url(AnnounceUrl)));
            }

            if (AnnounceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("AnnounceMethod", AnnounceMethod.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateParticipantOptions
    /// </summary>
    public class CreateParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The conference_sid
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The `from` phone number used to invite a participant.
        /// </summary>
        public Types.PhoneNumber From { get; }
        /// <summary>
        /// The number, client id, or sip address of the new participant.
        /// </summary>
        public Types.PhoneNumber To { get; }
        /// <summary>
        /// URL for conference event callback.
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Method Twilio should use to reach the status callback URL.
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Set state change events that will trigger a callback.
        /// </summary>
        public List<string> StatusCallbackEvent { get; set; }
        /// <summary>
        /// Number of seconds Twilio will wait for an answer.
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Record the agent and their conferences.
        /// </summary>
        public bool? Record { get; set; }
        /// <summary>
        /// Mute the agent.
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// Play a beep when the participant joins the conference.
        /// </summary>
        public string Beep { get; set; }
        /// <summary>
        /// Begin the conference when the participant joins.
        /// </summary>
        public bool? StartConferenceOnEnter { get; set; }
        /// <summary>
        /// End the conference when the participant leaves.
        /// </summary>
        public bool? EndConferenceOnExit { get; set; }
        /// <summary>
        /// URL that hosts pre-conference hold music
        /// </summary>
        public Uri WaitUrl { get; set; }
        /// <summary>
        /// The method Twilio should use to request `WaitUrl`.
        /// </summary>
        public Twilio.Http.HttpMethod WaitMethod { get; set; }
        /// <summary>
        /// Agents can hear the state of the outbound call.
        /// </summary>
        public bool? EarlyMedia { get; set; }
        /// <summary>
        /// Maximum number of agent conference participants.
        /// </summary>
        public int? MaxParticipants { get; set; }
        /// <summary>
        /// Record the conference.
        /// </summary>
        public string ConferenceRecord { get; set; }
        /// <summary>
        /// Trim silence from audio files.
        /// </summary>
        public string ConferenceTrim { get; set; }
        /// <summary>
        /// Callback URL for conference events.
        /// </summary>
        public Uri ConferenceStatusCallback { get; set; }
        /// <summary>
        /// HTTP method for requesting `ConferenceStatusCallback` URL.
        /// </summary>
        public Twilio.Http.HttpMethod ConferenceStatusCallbackMethod { get; set; }
        /// <summary>
        /// Set which conference state changes should webhook to the `ConferenceStatusCallback`
        /// </summary>
        public List<string> ConferenceStatusCallbackEvent { get; set; }
        /// <summary>
        /// Specify `mono` or `dual` recording channels.
        /// </summary>
        public string RecordingChannels { get; set; }
        /// <summary>
        /// The absolute URL for Twilio's webhook with recording status information.
        /// </summary>
        public Uri RecordingStatusCallback { get; set; }
        /// <summary>
        /// HTTP method for `RecordingStatusCallback`
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// SIP username used for authenticating.
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// SIP password for authentication.
        /// </summary>
        public string SipAuthPassword { get; set; }
        /// <summary>
        /// The region where Twilio should mix the conference audio.
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// Conference recording callback URL.
        /// </summary>
        public Uri ConferenceRecordingStatusCallback { get; set; }
        /// <summary>
        /// Method Twilio should use to request the `ConferenceRecordingStatusCallback` URL.
        /// </summary>
        public Twilio.Http.HttpMethod ConferenceRecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The recording_status_callback_event
        /// </summary>
        public List<string> RecordingStatusCallbackEvent { get; set; }
        /// <summary>
        /// The conference_recording_status_callback_event
        /// </summary>
        public List<string> ConferenceRecordingStatusCallbackEvent { get; set; }

        /// <summary>
        /// Construct a new CreateParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The conference_sid </param>
        /// <param name="from"> The `from` phone number used to invite a participant. </param>
        /// <param name="to"> The number, client id, or sip address of the new participant. </param>
        public CreateParticipantOptions(string pathConferenceSid, Types.PhoneNumber from, Types.PhoneNumber to)
        {
            PathConferenceSid = pathConferenceSid;
            From = from;
            To = to;
            StatusCallbackEvent = new List<string>();
            ConferenceStatusCallbackEvent = new List<string>();
            RecordingStatusCallbackEvent = new List<string>();
            ConferenceRecordingStatusCallbackEvent = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("StatusCallbackEvent", prop)));
            }

            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.Value.ToString()));
            }

            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString().ToLower()));
            }

            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Beep != null)
            {
                p.Add(new KeyValuePair<string, string>("Beep", Beep));
            }

            if (StartConferenceOnEnter != null)
            {
                p.Add(new KeyValuePair<string, string>("StartConferenceOnEnter", StartConferenceOnEnter.Value.ToString().ToLower()));
            }

            if (EndConferenceOnExit != null)
            {
                p.Add(new KeyValuePair<string, string>("EndConferenceOnExit", EndConferenceOnExit.Value.ToString().ToLower()));
            }

            if (WaitUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitUrl", Serializers.Url(WaitUrl)));
            }

            if (WaitMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitMethod", WaitMethod.ToString()));
            }

            if (EarlyMedia != null)
            {
                p.Add(new KeyValuePair<string, string>("EarlyMedia", EarlyMedia.Value.ToString().ToLower()));
            }

            if (MaxParticipants != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxParticipants", MaxParticipants.Value.ToString()));
            }

            if (ConferenceRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecord", ConferenceRecord));
            }

            if (ConferenceTrim != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceTrim", ConferenceTrim));
            }

            if (ConferenceStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallback", Serializers.Url(ConferenceStatusCallback)));
            }

            if (ConferenceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallbackMethod", ConferenceStatusCallbackMethod.ToString()));
            }

            if (ConferenceStatusCallbackEvent != null)
            {
                p.AddRange(ConferenceStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("ConferenceStatusCallbackEvent", prop)));
            }

            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }

            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", Serializers.Url(RecordingStatusCallback)));
            }

            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }

            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }

            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }

            if (Region != null)
            {
                p.Add(new KeyValuePair<string, string>("Region", Region));
            }

            if (ConferenceRecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallback", Serializers.Url(ConferenceRecordingStatusCallback)));
            }

            if (ConferenceRecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallbackMethod", ConferenceRecordingStatusCallbackMethod.ToString()));
            }

            if (RecordingStatusCallbackEvent != null)
            {
                p.AddRange(RecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("RecordingStatusCallbackEvent", prop)));
            }

            if (ConferenceRecordingStatusCallbackEvent != null)
            {
                p.AddRange(ConferenceRecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("ConferenceRecordingStatusCallbackEvent", prop)));
            }

            return p;
        }
    }

    /// <summary>
    /// Kick a participant from a given conference
    /// </summary>
    public class DeleteParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The string that uniquely identifies this conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Delete by unique participant Call Sid
        /// </summary>
        public string PathCallSid { get; }

        /// <summary>
        /// Construct a new DeleteParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="pathCallSid"> Delete by unique participant Call Sid </param>
        public DeleteParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of participants belonging to the account used to make the request
    /// </summary>
    public class ReadParticipantOptions : ReadOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The string that uniquely identifies this conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Filter by muted participants
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// Only show participants that are held or unheld.
        /// </summary>
        public bool? Hold { get; set; }

        /// <summary>
        /// Construct a new ReadParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The string that uniquely identifies this conference </param>
        public ReadParticipantOptions(string pathConferenceSid)
        {
            PathConferenceSid = pathConferenceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Hold != null)
            {
                p.Add(new KeyValuePair<string, string>("Hold", Hold.Value.ToString().ToLower()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}