using System;
using System.Collections.Generic;

namespace CyberAwarenessChatbotGUI.Chatbot
{
    public class ResponseManager
    {
        public Dictionary<string, List<string>> keywordResponses = new Dictionary<string, List<string>>()
        {
            { "password", new List<string> {
                "Strong password tip: Use 12+ characters with upper, lower, numbers, symbols. e.g., C0ffee$ecure!2026",
                "Never reuse passwords! One breach = all accounts hacked. Use Bitwarden or 1Password.",
                "Enable 2FA everywhere. Even if password leaks, 2FA saves you."
            }},
            { "scam", new List<string> {
                "Scam alert: Urgency + money request = SCAM. Real companies give you time.",
                "Verify sender domain. support@amaz0n.com, paypaI.com are fake. Look closely!",
                "If too good to be true, it is. No prince is sending you millions."
            }},
            { "privacy", new List<string> {
                "Privacy check: Does your flashlight app need contacts? Review permissions monthly.",
                "Turn off ad personalization on Google/Facebook. Check privacy settings now.",
                "Use private browsing + VPN on public WiFi. Your ISP shouldn't see everything."
            }},
            { "phishing", new List<string> {
                "Phishing tip: Hover over links to see REAL URL before clicking. Don't trust display text.",
                "Legit banks NEVER ask for password via email. Report phishing immediately.",
                "Check for typos: G00gle, Microsft = phishing. Real domains are spelled correctly."
            }},
            { "malware", new List<string> {
                "Malware protection: Keep Windows Defender updated + scan weekly.",
                "Don't download cracked software - 70% contain malware."
            }}
        };

        private Random rnd = new Random();

        public string GetRandomResponse(string keyword)
        {
            if (keywordResponses.ContainsKey(keyword))
            {
                var list = keywordResponses[keyword];
                return list[rnd.Next(list.Count)];
            }
            return "";
        }

        public bool ContainsKeyword(string input, out string foundKeyword)
        {
            foreach (var key in keywordResponses.Keys)
            {
                if (input.ToLower().Contains(key))
                {
                    foundKeyword = key;
                    return true;
                }
            }
            foundKeyword = "";
            return false;
        }
    }
}
