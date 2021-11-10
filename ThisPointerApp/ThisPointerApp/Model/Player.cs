using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisPointerApp.Model
{
    class Player
    {
        private string _name;
        private int _age;
        private GenderType _gender;

        public Player(string _name):this(_name,18,GenderType.Male)
        {
        }
        public Player(string _name,int _age, GenderType _gender)
        {
            this._name = _name;
            this._age = _age;
            this._gender = _gender;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
        }
        public GenderType Gender
        {
            get
            {
                return _gender;
            }
        }
        public Player WhoIsElder(Player player)
        {
            if (_age < player._age)
            {
                return player;
            }
            return this;
        }
    }
}
