using System.Collections.Generic;

namespace AlexTeamGenix
{
    /*
     * Message handler class (the store class ) stores the messages in two separate
     * lists, one list for the recent messages (up to 10 elements)
     * and one for all the message history
     */
    public class MessageHandler
    {
        public List<DesktopMessageHolder> MsgList { get; set; }
        public List<DesktopMessageHolder> MsgHistory { get; set; }


        public MessageHandler()
        {
            MsgList = new List<DesktopMessageHolder>();
            MsgHistory = new List<DesktopMessageHolder>();
        }
    }
}
