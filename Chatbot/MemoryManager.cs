namespace CyberAwarenessChatbotGUI.Chatbot
{
    public class MemoryManager
    {
        public string UserName { get; set; } = "";
        public string FavouriteTopic { get; set; } = "";
        public string LastTopic { get; set; } = "";

        public void SetFavourite(string topic) => FavouriteTopic = topic;
    }
}
