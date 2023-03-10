using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Runtime.ExceptionServices;

namespace TestTextGame
{
    [DataContract]
    public class Actor 
    {
        private string name { get; set; }

        private double str, sta, agi, ac, hp, wealth, experince;
        [DataMember(Name ="name")]
        public string Name { get { return name; } set { name = value; } }
        [DataMember(Name = "str")]
        public double Str { get { return str; } set { str = value; } }
        [DataMember(Name = "sta")]
        public double Sta { get { return sta; } set { sta = value; } }
        [DataMember(Name = "agi")]
        public double Agi { get { return agi; } set { agi = value; } }
        [DataMember(Name = "ac")]
        public double Ac { get { ac += agi * .5; return ac; } set { ac = value; } }
        [DataMember(Name = "hp")]
        public double Hp { get { hp += sta * 2; return hp; } set { hp = value; } }
        [DataMember(Name = "wealth")]
        public double Wealth { get { return wealth; } set { wealth = value; } }
        [DataMember(Name = "experince")]
        public double Experince { get { return experince; } set { experince = value; } }


        //public float getHp() { hp = sta * 2; return hp; }

        //Stats ActorStats { get; set; }
        public Actor()
        {
            name = "Missing Name";
            str = 0;
            sta = 0;
            agi = 0;
            ac = 0;
            hp = 0;
            wealth = 0;
            experince = 0;
        //  ActorStats = new Stats();
        }

        public void modifyStr(double amount)
        {
            str = str + amount;
        }
        public void modifySta(double amount)
        {
            sta = sta + amount;
        }
        public void modifyAgi(double amount)
        {
            agi = agi + amount;
        }
        public void modifyAc(double amount)
        {
            ac = ac + amount;
        }
        public void modifyHp(double amount)
        {
            hp = hp + amount;
        }

        
        public string showStats()
        {
            string toStr = string.Format("hp: {0} str: {1} sta: {2} agi: {3} ac: {4} wealth: {5} experince: {6}", 
                Convert.ToString(hp),
                Convert.ToString(str),
                Convert.ToString(sta),
                Convert.ToString(agi),
                Convert.ToString(ac), 
                Convert.ToString(wealth),
                Convert.ToString(experince));
            return toStr;
        
        }

        }
}