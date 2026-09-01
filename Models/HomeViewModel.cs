using System.Collections.Generic;

namespace THEOCOMPROG.Models
{
    public class MemberModel
    {
        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string ImageFileName { get; set; } = string.Empty;
    }

    public class HomeViewModel
    {
        public string GroupTitle { get; set; } = "ACAD A 07 - Group no.2 presents";
        public string MainTitle { get; set; } = "The Pentecostal Rendition";
        public string ScriptureQuote { get; set; } = "\"If we confess our sins, He is faithful and just to forgive us our sins and to cleanse us from all unrighteousness.\" — 1 John 1:9";
        public List<MemberModel> Members { get; set; } = new List<MemberModel>();
    }
}