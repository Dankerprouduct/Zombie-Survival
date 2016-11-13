using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content; 

namespace Zombie_Survival
{
    public class Monster
    {
        private string name;
        private int health;
        private int speed;
        private float damage; 

        public Monster(ref MonsterSpawner monsterSpawner)
        {
            this.name = monsterSpawner.GetName();
        }

        public void LoadContent(ContentManager content)
        {
            MonsterProperties[] monsterProperties = content.Load<Zombie_Survival.MonsterProperties[]>("Monsters");
            for (int i = 0; i < monsterProperties.Length; i++)
            {
                if (monsterProperties[i].name == this.name)
                {
                    health = monsterProperties[i].health;
                    speed = monsterProperties[i].speed;
                    damage = monsterProperties[i].damage; 
                }
            }
        }

        public void Update()
        {

        }
    }
}
