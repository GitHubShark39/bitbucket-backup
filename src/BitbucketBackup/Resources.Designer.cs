﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BitbucketBackup {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BitbucketBackup.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication failed.
        ///Please check if the password is valid!.
        /// </summary>
        internal static string AuthenticationFailed {
            get {
                return ResourceManager.GetString("AuthenticationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backup completed!.
        /// </summary>
        internal static string BackupCompleted {
            get {
                return ResourceManager.GetString("BackupCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backup failed!.
        /// </summary>
        internal static string ClientExceptionHeadline {
            get {
                return ResourceManager.GetString("ClientExceptionHeadline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local backup folder (must already exist):.
        /// </summary>
        internal static string InputBackupFolder {
            get {
                return ResourceManager.GetString("InputBackupFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You didn&apos;t enter a backup folder (or an invalid one)!.
        /// </summary>
        internal static string InputBackupFolderInvalid {
            get {
                return ResourceManager.GetString("InputBackupFolderInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Bitbucket password:.
        /// </summary>
        internal static string InputPassword {
            get {
                return ResourceManager.GetString("InputPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You didn&apos;t enter a password!.
        /// </summary>
        internal static string InputPasswordInvalid {
            get {
                return ResourceManager.GetString("InputPasswordInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout for pulling, in seconds:
        ///(Mercurial only, leave blank to use default [{0}]).
        /// </summary>
        internal static string InputPullTimeout {
            get {
                return ResourceManager.GetString("InputPullTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout for pulling must be an integer value greater than zero!.
        /// </summary>
        internal static string InputPullTimeoutInvalid {
            get {
                return ResourceManager.GetString("InputPullTimeoutInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Bitbucket team name (leave blank for no team):.
        /// </summary>
        internal static string InputTeam {
            get {
                return ResourceManager.GetString("InputTeam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Bitbucket username:.
        /// </summary>
        internal static string InputUser {
            get {
                return ResourceManager.GetString("InputUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You didn&apos;t enter a username!.
        /// </summary>
        internal static string InputUserInvalid {
            get {
                return ResourceManager.GetString("InputUserInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local backup folder: {0}.
        /// </summary>
        internal static string IntroFolder {
            get {
                return ResourceManager.GetString("IntroFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bitbucket Backup {0}.
        /// </summary>
        internal static string IntroHeadline {
            get {
                return ResourceManager.GetString("IntroHeadline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bitbucket team: {0}.
        /// </summary>
        internal static string IntroTeam {
            get {
                return ResourceManager.GetString("IntroTeam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bitbucket user: {0}.
        /// </summary>
        internal static string IntroUser {
            get {
                return ResourceManager.GetString("IntroUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t load information for user: {0}
        ///Please check if the user name is valid!.
        /// </summary>
        internal static string InvalidUsername {
            get {
                return ResourceManager.GetString("InvalidUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bitbucket API didn&apos;t return a response: {0}.
        /// </summary>
        internal static string NoResponse {
            get {
                return ResourceManager.GetString("NoResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press &lt;ENTER&gt; to quit!.
        /// </summary>
        internal static string PressEnter {
            get {
                return ResourceManager.GetString("PressEnter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to git pull: {0}.
        /// </summary>
        internal static string PullingGit {
            get {
                return ResourceManager.GetString("PullingGit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  hg pull: {0}.
        /// </summary>
        internal static string PullingMercurial {
            get {
                return ResourceManager.GetString("PullingMercurial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout for pulling exceeded! ({0} seconds) .
        /// </summary>
        internal static string PullTimeoutExceeded {
            get {
                return ResourceManager.GetString("PullTimeoutExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press &lt;SPACE&gt; in the next {0} seconds to re-enter your settings!.
        /// </summary>
        internal static string SettingsPrompt {
            get {
                return ResourceManager.GetString("SettingsPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://christianspecht.de/bitbucket-backup/.
        /// </summary>
        internal static string WebLink {
            get {
                return ResourceManager.GetString("WebLink", resourceCulture);
            }
        }
    }
}
