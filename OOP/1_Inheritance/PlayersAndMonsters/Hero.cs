using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public abstract class Hero   //abstract allows us to use the class for inheretence but not to use it direclty by the client
    {
		private string username;
		private int level;

		public Hero(string username , int level)
		{
			Username = username;
			Level = level;

		}
		public int Level
		{
			get { return level; }
			set { level = value; }
		}

		public string Username
		{
			get { return username; }
			set { username = value; }
		}


		public override string ToString()
		{
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
	}
}
