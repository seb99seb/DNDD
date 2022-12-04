using API_DNDD.Classes;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Claims;

namespace API_DNDD.Managers
{
    public class CreaturesManager
    {
        private static List<Creature> _creatures = new List<Creature>()
        {
            new Creature(1, "Cat", "Tiny Beast", 12, 2, "40 ft., climb 30 ft.", 3, 15, 10,
                "Perception +3, Stealth +4",
                "Passive Perception 13",
                0,
                2,
                "<b><i>Keen Smell.</b></i> The cat has advantage on Wisdom (Perception) checks that rely on smell.",
                "<b><i>Claws.</b> Melee Weapon Attack:</i> +0 to hit, reach 5 ft., one target. Hit: 1 slashing damage."
                ),
            new Creature(2, "Rabbit", "Tiny Beast", 11, 1, "35 ft., burrow 5 ft.", 1, 13, 7,
                "Perception +2, Stealth +3",
                "Passive Perception 12",
                0,
                2,
                "",
                "<b><i>Bite.</b> Melee Weapon Attack:</b> +3 to hit, reach 5 ft., one target. Hit: 1 piercing damage."
                ),
            new Creature(3, "Stirge", "Tiny Beast", 14, 2, "10 ft., fly 40 ft.", 4, 16, 11,
                "",
                "Darkvision 60 ft., Passive Perception 9",
                0.125,
                2,
                "",
                "<i><b>Blood Drain.</b> Melee Weapon Attack:</i> +5 to hit, reach 5 ft., one creature. Hit: 5 (1d4 + 3) piercing damage, and the stirge attaches to the target. While attached, the stirge doesn't attack. Instead, at the start of each of the stirge's turns, the target loses 5 (1d4 + 3) hit points due to blood loss.\r\n\r\nThe stirge can detach itself by spending 5 feet of its movement. It does so after it drains 10 hit points of blood from the target or the target dies. A creature, including the target, can use its action to detach the stirge."
                ),
            new Creature(4, "Giant Wolf Spider", "Medium Beast", 13, 11, "40 ft., climb 40 ft.", 12, 16, 13,
                "Perception +3, Stealth +7",
                "Blindsight 10 Ft., Darkvision 60 Ft., Passive Perception 13",
                0.25,
                2,
                "<b><i>Spider Climb.</b></i> The spider can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check.\n" +
                "<b><i>Web Sense.</b></i> While in contact with a web, the spider knows the exact location of any other creature in contact with the same web.\n" +
                "<b><i>Web Walker.</b></i> The spider ignores movement restrictions caused by webbing.",
                "<i><b>Bite.</b> Melee Weapon Attack:</i> +4 to hit, reach 5 ft., one creature. Hit: (1d10 + 2) piercing damage plus (4d8)poison damage. The target must make a DC 11 Constitution saving throw. On a failed save the target takes the poison damage, or half as much damage on a successful one. If the poison damage reduces the target to 0 hit points, the target is stable but poisoned for 1 hour, even after regaining hit points, and is paralyzed while poisoned in this way."
                ),
            new Creature(5, "Dire Wolf", "Large Beast", 14, 37, "50 ft.", 17, 15, 15,
                "Perception +3, Stealth +4",
                "Passive Perception 13",
                1,
                2,
                "<b><i>Keen Hearing and Smell.</b></i> The wolf has advantage on Wisdom (Perception) checks that rely on hearing or smell.\n" +
                "<b><i>Pack Tactics.</b></i> The wolf has advantage on an attack roll against a creature if at least one of the wolf's allies is within 5 feet of the creature and the ally isn't incapacitated.",
                "<b><i>Bite.</b> Melee Weapon Attack:</i> +5 to hit, reach 5 ft., one target. Hit: 10 (2d6 + 3) piercing damage. If the target is a creature, it must succeed on a DC 13 Strength saving throw or be knocked prone."),
            new Creature(6, "Giant Eagle", "Large Beast", 13, 26, "10 ft., fly 80 ft.", 16, 17, 13,
                "Perception +4",
                "Passive Perception 14",
                1,
                2,
                "<b><i>Keen Sight.</b></i> The eagle has advantage on Wisdom (Perception) checks that rely on sight.\n",
                "<i><b>Multiattack.</b></i> The eagle makes two attacks: one with its beak and one with its talons.\n" +
                "<i><b>Beak.</b> Melee Weapon Attack</i> +5 to hit, reach 5 ft., one target. Hit: 6 (1d6 + 3) piercing damage." +
                "<i><b>Talons.</b> Melee Weapon Attack:</i> +5 to hit, reach 5 ft., one target. Hit: 10 (2d6 + 3) slashing damage."
                ),
            new Creature(7, "Giant Octopus", "Large Beast", 11, 52, "10 ft., swim 60 ft.", 17, 13, 13,
                "Perception +4, Stealth +5",
                "Darkvision 60 ft., Passive Perception 14",
                1,
                2,
                "<b><i>Hold Breath.</b></i> While out of water, the octopus can hold its breath for 1 hour.\n" +
                "<b><i>Underwater Camouflage.</b></i> The octopus has advantage on Dexterity (Stealth) checks made while underwater.\n" +
                "<b><i>Water Breathing.</b></i> The octopus can breathe only underwater.",
                "<b><i>Tentacles.</b> Melee Weapon Attack:</i> +5 to hit, reach 15 ft., one target. Hit: 10 (2d6 + 3) bludgeoning damage. If the target is a creature, it is grappled (escape DC 16). Until this grapple ends, the target is restrained, and the octopus can't use its tentacles on another target.\n" +
                "<b><i>Ink Cloud (Recharges after a Short or Long Rest).</b></i> A 20-foot-radius cloud of ink extends all around the octopus if it is underwater. The area is heavily obscured for 1 minute, although a significant current can disperse the ink. After releasing the ink, the octopus can use the Dash action as a bonus action."),
            new Creature(8, "Giant Spider", "Large Beast", 14, 26, "30 ft., climb 30 ft.", 14, 16, 12,
                "Stealth +7",
                "Blindsight 10 ft., Darkvision 60 ft., Passive Perception 10",
                1,
                2,
                "<b><i>Spider Climb.</b></i> The spider can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check.\n" +
                "<b><i>Web Sense.</b></i> While in contact with a web, the spider knows the exact location of any other creature in contact with the same web.\n" +
                "<b><i>Web Walker.</b></i> The spider ignores movement restrictions caused by webbing.",
                "<b><i>Bite.</b> Melee Weapon Attack:</i> +5 to hit, reach 5 ft., one creature. Hit: 7 (1d8 + 3) piercing damage, and the target must make a DC 11 Constitution saving throw, taking 9 (2d8) poison damage on a failed save, or half as much damage on a successful one. If the poison damage reduces the target to 0 hit points, the target is stable but poisoned for 1 hour, even after regaining hit points, and is paralyzed while poisoned in this way.\n" +
                "<b><i>Web (Recharge 5–6).</b> Ranged Weapon Attack:</i> +5 to hit, range 30/60 ft., one creature. Hit: The target is restrained by webbing. As an action, the restrained target can make a DC 12 Strength check, bursting the webbing on a success. The webbing can also be attacked and destroyed (AC 10; hp 5; vulnerability to fire damage; immunity to bludgeoning, poison, and psychic damage)."),
            new Creature(9, "Polar Bear", "Large Beast", 12, 42, "40 ft., swim 30 ft.", 20, 10, 16,
                "Perception +3",
                "Passive Perception 13",
                2,
                2,
                "<b><i>Keen Smell.</b></i> The bear has advantage on Wisdom (Perception) checks that rely on smell.",
                "<b><i>Multiattack.</b></i> The bear makes two attacks: one with its bite and one with its claws.\n" +
                "<b><i>Bite.</b> Melee Weapon Attack:</i> +7 to hit, reach 5 ft., one target. Hit: 9 (1d8 + 5) piercing damage.\n" +
                "<b><i>Claws.</b> Melee Weapon Attack:</i> +7 to hit, reach 5 ft., one target. Hit: 12 (2d6 + 5) slashing damage.")
        };
        public CreaturesManager()
        {
            #region old
            /*
            //giant wolf spider
            _creatures[0].Skills = "Perception +3, Stealth +7";
            _creatures[0].Senses = "Blindsight 10 Ft., Darkvision 60 Ft., Passive Perception 13";
            _creatures[0].Traits = "<b><i>Spider Climb.</b></i> The spider can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check.\n" +
                "<b><i>Web Sense.</b></i> While in contact with a web, the spider knows the exact location of any other creature in contact with the same web.\n" +
                "<b><i>Web Walker.</b></i> The spider ignores movement restrictions caused by webbing.";
            _creatures[0].Actions = "<b><i>Bite.</b></i> <i>Melee Weapon Attack:</i> +3 to hit, reach 5 ft., one creature. Hit: (1d6 + 1) piercing damage plus (2d6)poison damage. The target must make a DC 11 Constitution saving throw, taking the poison damage on a failed save, or half as much damage on a successful one. If the poison damage reduces the target to 0 hit points, the target is stable but poisoned for 1 hour, even after regaining hit points, and is paralyzed while poisoned in this way.";
            //phase spider
            _creatures[1].Skills = "Stealth +6";
            _creatures[1].Senses = "Senses Darkvision 60 Ft., passive Perception 10";
            _creatures[1].Traits = "<b><i>Ethereal Jaunt.</b></i> As a bonus action, the spider can magically shift from the Material Plane to the Ethereal Plane, or vice versa.\n" +
                "<b><i>Spider Climb.</b></i> The spider can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check.\n" +
                "<b><i>Web Walker.</b></i> The spider ignores movement restrictions caused by webbing.";
            _creatures[1].Actions = "<b>Bite.</b> <i>Melee Weapon Attack:</i> +4 to hit, reach 5 ft., one creature. Hit: (1d10 + 2) piercing damage plus (4d8)poison damage. The target must make a DC 11 Constitution saving throw. On a failed save the target takes the poison damage, or half as much damage on a successful one. If the poison damage reduces the target to 0 hit points, the target is stable but poisoned for 1 hour, even after regaining hit points, and is paralyzed while poisoned in this way.";
            //eagle
            _creatures[2].Skills = "Perception +4";
            _creatures[2].Senses = "Passive Perception 14";
            _creatures[2].Traits = "<b><i>Keen Sight.</b></i> The eagle has advantage on Wisdom (Perception) checks that rely on sight.";
            _creatures[2].Actions = "<i><b>Talons.</b></i> <i>Melee Weapon Attack:</i> +4 to hit, reach 5 ft., one target. Hit: (1d4 + 2) slashing damage.";
            */
            #endregion
        }
        public Creature GetById(int id)
        {
            return _creatures.Find(b => b.Id == id);
        }
        public List<Creature> GetAll()
        {
            return _creatures;
        }
    }
}