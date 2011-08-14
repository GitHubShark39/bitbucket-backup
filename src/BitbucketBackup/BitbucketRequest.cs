﻿using System;
using System.IO;
using System.Net;

namespace BitbucketBackup
{
    /// <summary>
    /// Helper class for making requests to the Bitbucket API
    /// </summary>
    internal class BitbucketRequest
    {
        /// <summary>
        /// Base URI for all API calls
        /// </summary>
        private Uri baseuri;

        /// <summary>
        /// login credentials (Base64 encoded string)
        /// </summary>
        private string credentials;

        /// <summary>
        /// Creates a new Bitbucket API request.
        /// </summary>
        /// <param name="Credentials">login credentials (Base64 encoded string)</param>
        public BitbucketRequest(string Credentials)
        {
            this.baseuri = new Uri("https://api.bitbucket.org/1.0/");
            this.credentials = Credentials;
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

            using (var response = request.GetResponse() as HttpWebResponse)
            {
                var reader = new StreamReader(response.GetResponseStream());
                return reader.ReadToEnd();
            }
        }
    }
}