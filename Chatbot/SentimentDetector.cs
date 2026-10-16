namespace CyberAwarenessChatbotGUI.Chatbot
{
    public class SentimentDetector
    {
        public string Detect(string input)
        {
            string lower = input.ToLower();
            if (lower.Contains("worried") || lower.Contains("scared") || lower.Contains("anxious") || lower.Contains("afraid") || lower.Contains("nervous"))
                return "worried";
            if (lower.Contains("frustrated") || lower.Contains("angry") || lower.Contains("annoyed") || lower.Contains("overwhelmed") || lower.Contains("tired"))
                return "frustrated";
            if (lower.Contains("curious") || lower.Contains("confused") || lower.Contains("not sure") || lower.Contains("don't understand"))
                return "curious";
            return "neutral";
        }

        public string GetEmpatheticResponse(string sentiment)
        {
            if (sentiment == "worried")
                return "It's completely understandable to feel that way. Scammers can be very convincing these days. You're doing the right thing by asking. ";
            if (sentiment == "frustrated")
                return "I hear you, cybersecurity can be overwhelming. You're not alone — let's take it one step at a time. ";
            if (sentiment == "curious")
                return "Great question! Curiosity is your best defense online. ";
            return "";
        }
    }
}
