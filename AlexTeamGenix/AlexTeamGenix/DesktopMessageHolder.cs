
namespace AlexTeamGenix
{
    public class DesktopMessageHolder
    {
        //Message and ID linked together can be separated into 2 objects as well
        public string UserMessage { get; set; }


        //This will hold the default value as for the constructor but will never be used.
        public DesktopMessageHolder()
        {
            this.UserMessage = DesktopID.Get_DesktopID + "\t\t" + "test";
        }


        //Parameter being received from main program
        public DesktopMessageHolder(string a)
        {
            this.UserMessage = a;
        }
    }
}
