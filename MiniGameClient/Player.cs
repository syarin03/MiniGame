using System.Collections.Generic;

namespace MiniGameClient
{
    public class Player
    {
        public int Num { get; set; }
        public string ID { get; set; }
        public string PW { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }

        public Player(List<object> list)
        {
            Num = (int)list[0];
            ID = list[1].ToString();
            PW = list[2].ToString();
            Name = list[3].ToString();
            Phone = list[4].ToString();
            Nickname = list[5].ToString();
        }
    }
}
