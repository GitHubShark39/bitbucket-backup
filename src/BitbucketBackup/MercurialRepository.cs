﻿using System;
using System.IO;
using Mercurial;

namespace BitbucketBackup
{
    /// <summary>
    /// Creates and pulls from Mercurial repositories.
    /// </summary>
    internal class MercurialRepository : RepositoryBase
    {
        private Repository repo;

        public MercurialRepository(string remoteUri, string folder) : base(remoteUri, folder) { }

        public override string PullingMessage
        {
            get { return Resources.PullingMercurial; }
        }

        protected override void Init()
        {
            this.repo = new Repository(this.folder);

            if (!Directory.Exists(Path.Combine(this.folder, ".hg")))
            {
                repo.Init();
            }
        }

        public override void Pull()
        {
            if (this.repo == null)
            {
                throw new InvalidOperationException("You need to call Init() first!");
            }

            this.repo.Pull(this.remoteuri, new PullCommand().WithUpdate(false));
        }
    }
}
