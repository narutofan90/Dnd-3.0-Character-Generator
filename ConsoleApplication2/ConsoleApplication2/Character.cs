using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenDnD
{
    class Character
    {
        String name;
        int Character_Level;
        public enum Class {BARBARIAN, BARD, CLERIC, DRUID, FIGHTER, MONK, PALADIN, RANGER, ROGUE, SORCERER, WIZARD, TOTAL }
        Class Character_Class;
        public enum Race {HUMAN, ELF, DWARF, GNOME, HALF_ELF, HALF_ORC, HALFLING, TOTAL}
        Race race;
        int Dex;
        int Dex_mod;
        int Str;
        int Str_mod;
        int Chr;
        int Chr_mod;
        int Wis;
        int Wis_mod;
        int Int;
        int Int_mod;
        int Con;
        int Con_mod;
        string[] Print_class = new string[(int)Class.TOTAL];
        string[] Print_race = new string[(int)Race.TOTAL];
        int Skill_Points;
        int HP;

        public Character(string Input_Name, int Input_Level, Race Input_Race, Class Input_Class, int Input_HP,
            int Input_Dex, int Input_Dex_mod, 
            int Input_Str, int input_Str_mod, 
            int input_Chr, int input_Chr_mod, 
            int input_Wis, int input_Wis_mod, 
            int input_Int, int input_Int_mod, 
            int input_Con, int input_Con_mod,
            int Input_SkillPoints)
        {
            name = Input_Name;
            Character_Level = Input_Level;
            Character_Class = Input_Class;
            race = Input_Race;
            HP = Input_HP;
            Dex = Input_Dex;
            Dex_mod = Input_Dex_mod;
            Str = Input_Str;
            Str_mod = input_Str_mod;
            Chr = input_Chr;
            Chr_mod = input_Chr_mod;
            Wis = input_Wis;
            Wis_mod = input_Wis_mod;
            Int = input_Int;
            Int_mod = input_Int_mod;
            Con = input_Con;
            Con_mod = input_Con_mod;
            Skill_Points = Input_SkillPoints;

            //Class converter to make readable
            Print_class[0] = "Barbarian";
            Print_class[1] = "Bard";
            Print_class[2] = "Cleric";
            Print_class[3] = "Druid";
            Print_class[4] = "Figter";
            Print_class[5] = "Monk";
            Print_class[6] = "Paladin";
            Print_class[7] = "Ranger";
            Print_class[8] = "Rogue";
            Print_class[9] = "Sorcerer";
            Print_class[10] = "Wizard";
            //Race converter to make readable
            Print_race[0] = "Human";
            Print_race[1] = "Elf";
            Print_race[2] = "Dwarf";
            Print_race[3] = "Gnome";
            Print_race[4] = "Half-Elf";
            Print_race[5] = "Half-Orc";
            Print_race[6] = "Halfling";

        }
   
        public string Introduce()
        {
            var Character_Stats = string.Join(
            Environment.NewLine,
            " ",
            "Character name: " + name,
            "Level: " + Character_Level,
            "Race: " + (Print_race[(int)race]),
            "Class: " +(Print_class[(int)Character_Class]),
            "Hit Points: " + HP,
            "Str: " + Str + " Mod: " + Str_mod,
            "Dex: " + Dex + " Mod: " + Dex_mod,
            "Con: " + Con + " Mod: " + Con_mod,
            "Int: " + Int + " Mod: " + Int_mod,
            "Wis: " + Wis + " Mod: " + Wis_mod,
            "Chr: " + Chr + " Mod: " + Chr_mod,
            "Starting Skill Points: " + Skill_Points,
            " ");
            return Character_Stats;
        }
    }
}
