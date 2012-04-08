﻿using System;
using System.IO;
using System.Net;
using System.Text;

namespace BitbucketBackup
{
    /// <summary>
    /// Helper class for making requests to the Bitbucket API
    /// </summary>
    internal class BitbucketRequest : IBitbucketRequest
    {
        /// <summary>
        /// Base URI for all API calls
        /// </summary>
        private Uri baseuri;
        
        /// <summary>
        /// login credentials (Base64 encoded string)
        /// </summary>
        private string credentials;

        private IConfig config;

        /// <summary>
        /// Creates a new Bitbucket API request.
        /// </summary>
        /// <param name="config">Config object (for login credentials)</param>
        public BitbucketRequest(IConfig config)
        {
            this.baseuri = new Uri("https://api.bitbucket.org/1.0/");
            this.credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(config.UserName + ":" + config.PassWord));
            this.config = config;
        }

        /// <summary>
        /// Executes the request.
        /// </summary>
        /// <param name="requestUri">relative path of the </param>
        /// <returns>Response (as JSON string)</returns>
        public string Execute(string requestUri)
        {
            var uri = new Uri(baseuri, requestUri);
            var request = WebRequest.Create(uri.ToString()) as HttpWebRequest;
            request.Headers.Add("Authorization", "Basic " + this.credentials);

            try
            {
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    var reader = new StreamReader(response.GetResponseStream());
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                using (HttpWebResponse resp = (HttpWebResponse)ex.Response)
                {
                    if (resp.StatusCode == HttpStatusCode.NotFound)
                    {
                        // if the Uri returns a 404, the username probably doesn't exist
                        // (there could be other reasons, but this one is the most likely)
                        throw new ClientException(string.Format(Resources.InvalidUsername, config.UserName), ex);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
    }
}
