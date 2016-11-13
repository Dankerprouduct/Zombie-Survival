using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content; 

namespace Zombie_Survival
{
    public class MonsterSpawner
    {

        private string name;
        
        public MonsterSpawner(string name)
        {
            this.name = name;
        }

        public Monster SpawnMonster()
        {
            MonsterSpawner monsterSpawner = this;
            return new Monster(ref monsterSpawner); 
        }

        public string GetName()
        {
            return name; 
        }
    }
}
