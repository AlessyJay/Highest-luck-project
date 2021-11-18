using System;
using System.Collections.Generic;
using System.Text;

namespace Highest_Luck
{
    class PlayerRoundInfo
    {
        string name, picture;
        int point, round, bank;

        public PlayerRoundInfo(string name, string picture, int point, int round, int bank)
        {
            this.name = name;
            this.point = point;
            this.round = round;
            this.picture = picture;
            this.bank = bank;
        }

        public string getName()
        {
            return this.name;
        }

        public int getPoint()
        {
            return this.point;
        }

        public int getRound()
        {
            return this.round;
        }

        public string getPicture()
        {
            return this.picture;
        }

        public int getBank()
        {
            return this.bank;
        }
    }
}
