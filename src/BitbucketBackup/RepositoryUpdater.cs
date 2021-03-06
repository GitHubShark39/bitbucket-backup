﻿using System;

namespace BitbucketBackup
{
    /// <summary>
    /// Clones or pulls/updates a given repository to the local disk.
    /// </summary>
    internal class RepositoryUpdater : IRepositoryUpdater
    {
        private IConfig config;
        private IRepositoryFactory factory;
        private readonly ILogger logger;

        /// <summary>
        /// Creates a new RepositoryUpdater instance
        /// </summary>
        /// <param name="config">configuration settings</param>
        public RepositoryUpdater(IConfig config, IRepositoryFactory factory, ILogger logger)
        {
            this.config = config;
            this.factory = factory;
            this.logger = logger;
        }

        /// <summary>
        /// Updates the local repository to the same revision as the remote one
        /// </summary>
        /// <param name="repoType">type of the repository (hg or git)</param>
        /// <param name="repoUri">URI to remote repository</param>
        /// <param name="localFolder">local destination for repository clone</param>
        public void Update(string repoType, Uri repoUri, string localFolder)
        {
            var uriWithAuth = this.BuildUriWithAuth(repoUri);

            var repo = this.factory.Create(repoType, uriWithAuth.ToString(), localFolder);
            
            if (repo.PullingMessage.Contains("{0}"))
            {
                logger.WriteLine(repo.PullingMessage, repoUri);
            }
            else
            {
                logger.WriteLine(repo.PullingMessage);
            }

            repo.Pull();
        }

        /// <summary>
        /// Inserts parameters for authentication into an URI
        /// </summary>
        /// <param name="uriWithoutAuth">Uri without authentification</param>
        /// <returns>Uri with authentification</returns>
        private Uri BuildUriWithAuth(Uri uriWithoutAuth)
        {
            return new Uri(uriWithoutAuth.ToString().Replace("://", string.Format("://{0}:{1}@", Uri.EscapeDataString(this.config.UserName), Uri.EscapeDataString(this.config.PassWord))));
        }
    }
}
