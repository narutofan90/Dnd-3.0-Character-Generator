using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenDnD
{
    class Program
    {
        static void Main(string[] args)
        {
            //defult starting int's
            int Character_SkillPoints = 0;
            int Character_HP = 0;
            int counter = 0;
            int Skill_Fix = 0;

            //Main script
            Console.WriteLine("How many character do you wish to create?");
            int number_Characters = Convert.ToInt32(Console.ReadLine());
            Character[] New_character = new Character[number_Characters];
            for (int i = 0; i < number_Characters; i++)
            {
                Console.WriteLine("Input Characters Name");
                string character_name = (Console.ReadLine());
                Console.WriteLine("Choose a race: [1]Human, [2]Elf, [3]Dwarf, [4]Gnome, [5]Half-Elf, [6]Half-Orc, [7]Halfling");
                Character.Race new_race = (Character.Race)Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Choose a Class: [1]Barbarian, [2]Bard, [3]Cleric, [4]Druid, [5]Fighter, [6]Monk, [7]Paladin, [8]Ranger, [9]Rogue ,[10]Sorcerer, [11]Wizard");
                Character.Class new_class = (Character.Class)Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Input Characters Strength score -");
                int Strength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Characters Dexterity score -");
                int Dexterity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Characters Constitution score -");
                int Constitution = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Characters Intelligence score -");
                int Intelligence = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Characters Wisdom score -");
                int Wisdom = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Characters Charisma score -");
                int Charisma = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Character Level");
                int Level = Convert.ToInt32(Console.ReadLine());
                
            //Abilities changeing due to level up
                for (int j = 0; j < Level / 4; j++)
                {
                    Console.WriteLine("You gained an ability point at level "+ (j + 1)* 4 + Environment.NewLine + "(1)Str, (2)Dex, (3)Con, (4)Int, (5)Wis, (6)Chr");
                    int input_key = Convert.ToInt32(Console.ReadLine());
                    switch (input_key)
                    {
                        case 1:
                            Strength = Strength + 1;
                            counter = counter + 1;
                            break;
                        case 2:
                            Dexterity = Dexterity + 1;
                            counter = counter + 1;
                            break;
                        case 3:
                            Constitution = Constitution + 1;
                            counter = counter + 1;
                            break;
                        case 4:
                            Intelligence = Intelligence + 1;
                            counter = counter + 1;
                            if (Intelligence % 2 == 0)
                            {
                                Skill_Fix = Skill_Fix + (counter * 4 - 1);
                            }
                            break;
                        case 5:
                            Wisdom = Wisdom + 1;
                            counter = counter + 1;
                            break;
                        case 6:
                            Charisma = Charisma + 1;
                            counter = counter + 1;
                            break;
                    }
                }

            //Class Ability adjuster
                switch (new_race)
                {
                    case Character.Race.HUMAN:
                        Character_SkillPoints = Character_SkillPoints + 4;
                        break;
                    case Character.Race.DWARF:
                        Constitution = Constitution + 2;
                        Charisma = Charisma - 2;
                        break;
                    case Character.Race.ELF:
                        Dexterity = Dexterity + 2;
                        Constitution = Constitution - 2;
                        break;
                    case Character.Race.GNOME:
                        Constitution = Constitution + 2;
                        Strength = Strength - 2;
                        break;
                    case Character.Race.HALF_ORC:
                        Strength = Strength + 2;
                        Intelligence = Intelligence - 2;
                        Charisma = Charisma - 2;
                        break;
                    case Character.Race.HALFLING:
                        Dexterity = Dexterity + 2;
                        Strength = Strength - 2;
                        break;
                    case Character.Race.HALF_ELF:
                        break;
                }

            //Ability Mod Calulator
                int Strength_mod = (Strength - 10) / 2;
                int Dexterity_mod = (Dexterity - 10) / 2;
                int Constitution_mod = (Constitution - 10) / 2;
                int Intelligence_mod = (Intelligence - 10) / 2;
                int Wisdom_mod = (Wisdom - 10) / 2;
                int Charisma_mod = (Charisma - 10) / 2;

            //HP Calulator
                if (new_class == Character.Class.BARBARIAN)
                {
                    Character_HP = (Character_HP + 12 + Constitution_mod) *Level;
                }
                if (new_class == Character.Class.FIGHTER || new_class == Character.Class.PALADIN)
                {
                    Character_HP = (Character_HP + 10 + Constitution_mod) *Level;
                }
                if (new_class == Character.Class.CLERIC || new_class == Character.Class.DRUID || new_class == Character.Class.MONK || new_class == Character.Class.RANGER)
                {
                    Character_HP = (Character_HP + 8 + Constitution_mod) *Level;
                }
                if (new_class == Character.Class.BARD || new_class == Character.Class.ROGUE)
                {
                    Character_HP = (Character_HP + 6 + Constitution_mod) *Level;
                }
                if (new_class == Character.Class.SORCERER || new_class == Character.Class.WIZARD)
                {
                    Character_HP = (Character_HP + 4 + Constitution_mod) *Level;
                }

            //Skill Points Calulator
                if (new_class == Character.Class.CLERIC || new_class == Character.Class.FIGHTER || new_class == Character.Class.PALADIN || new_class == Character.Class.SORCERER || new_class == Character.Class.WIZARD)
                {
                    Character_SkillPoints = Character_SkillPoints + ((2 + Intelligence_mod) * 4) + ((2 + Intelligence_mod) * Level) - Skill_Fix; 
                }
                if (new_class == Character.Class.BARBARIAN || new_class == Character.Class.DRUID || new_class == Character.Class.MONK)
                {
                    Character_SkillPoints = Character_SkillPoints + ((4 + Intelligence_mod) * 4) + ((4 + Intelligence_mod) * Level) - Skill_Fix;
                }
                if (new_class == Character.Class.BARD || new_class == Character.Class.RANGER)
                {
                    Character_SkillPoints = Character_SkillPoints + ((6 + Intelligence_mod) * 4) + ((6 + Intelligence_mod) * Level) - Skill_Fix;
                }

            //Code for printing the intro
                New_character[i] = new Character(character_name,Level,new_race,new_class,Character_HP , Dexterity, Dexterity_mod, Strength, Strength_mod, Charisma, Charisma_mod, Wisdom, Wisdom_mod, Intelligence, Intelligence_mod, Constitution, Constitution_mod,Character_SkillPoints);
            }
            for (int i = 0; i < number_Characters; i++)
            {
                Console.WriteLine(New_character[i].Introduce());

            }
            Console.ReadKey(true);
        }
    }
}
