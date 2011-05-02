using System;
using System.Collections.Generic;

namespace trackgit.ViewModels
{
    public class GitUser
    {
        public string email { get; set; } 
        public string name { get; set; }
    }

    public class GitRepository
    {
        public string url { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int watchers { get; set; }
        public int forks { get; set; }
        // public int private { get; set; }
        public GitUser owner { get; set; }
    }

    public class GitCommit
    {
        public string id { get; set; }
        public string url { get; set; }
        public GitUser author { get; set; }
        public string message { get; set; }
        public DateTime timestamp { get; set; }
        public IEnumerable<string> added { get; set; }
    }

    public class GitCheckinInfo
    {
        public string before { get; set; }
        public GitRepository repository { get; set; }
        public IEnumerable<GitCommit> commits { get; set; }
        public string after { get; set; }
        // public string ref { get; set; }
    }
}