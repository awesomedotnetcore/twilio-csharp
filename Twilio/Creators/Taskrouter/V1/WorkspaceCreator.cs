using System;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Creators;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Taskrouter.V1;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Creators.Taskrouter.V1 {

    public class WorkspaceCreator : Creator<WorkspaceResource> {
        private string friendlyName;
        private Uri eventCallbackUrl;
        private string template;
    
        /**
         * Construct a new WorkspaceCreator
         * 
         * @param friendlyName The friendly_name
         */
        public WorkspaceCreator(string friendlyName) {
            this.friendlyName = friendlyName;
        }
    
        /**
         * The event_callback_url
         * 
         * @param eventCallbackUrl The event_callback_url
         * @return this
         */
        public WorkspaceCreator setEventCallbackUrl(Uri eventCallbackUrl) {
            this.eventCallbackUrl = eventCallbackUrl;
            return this;
        }
    
        /**
         * The event_callback_url
         * 
         * @param eventCallbackUrl The event_callback_url
         * @return this
         */
        public WorkspaceCreator setEventCallbackUrl(string eventCallbackUrl) {
            return setEventCallbackUrl(Promoter.UriFromString(eventCallbackUrl));
        }
    
        /**
         * The template
         * 
         * @param template The template
         * @return this
         */
        public WorkspaceCreator setTemplate(string template) {
            this.template = template;
            return this;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created WorkspaceResource
         */
        public override async Task<WorkspaceResource> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.TASKROUTER,
                "/v1/Workspaces"
            );
            
            addPostParams(request);
            Response response = await client.RequestAsync(request);
            
            if (response == null) {
                throw new ApiConnectionException("WorkspaceResource creation failed: Unable to connect to server");
            } else if (response.GetStatusCode() < System.Net.HttpStatusCode.OK || response.GetStatusCode() > System.Net.HttpStatusCode.NoContent) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    (restException.GetMessage() != null ? restException.GetMessage() : "Unable to create record, " + response.GetStatusCode()),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    (int)response.GetStatusCode(),
                    null
                );
            }
            
            return WorkspaceResource.FromJson(response.GetContent());
        }
        #endif
    
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created WorkspaceResource
         */
        public override WorkspaceResource Execute(ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.TASKROUTER,
                "/v1/Workspaces"
            );
            
            addPostParams(request);
            Response response = client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("WorkspaceResource creation failed: Unable to connect to server");
            } else if (response.GetStatusCode() < System.Net.HttpStatusCode.OK || response.GetStatusCode() > System.Net.HttpStatusCode.NoContent) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    (restException.GetMessage() != null ? restException.GetMessage() : "Unable to create record, " + response.GetStatusCode()),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    (int)response.GetStatusCode(),
                    null
                );
            }
            
            return WorkspaceResource.FromJson(response.GetContent());
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (friendlyName != null) {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (eventCallbackUrl != null) {
                request.AddPostParam("EventCallbackUrl", eventCallbackUrl.ToString());
            }
            
            if (template != null) {
                request.AddPostParam("Template", template);
            }
        }
    }
}