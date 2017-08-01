using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LoadDataDND : MonoBehaviour {
     public List<Race> Race = new List<Race>();
     public List<SubRace> SubRace = new List<SubRace>();
     public CombatClass combatClass = new CombatClass();
     bool finished = false;

     public int loadRace(){
          Race.Add(new Race {
               raceName = "Dwarf",
               abilityScoreName = new List<string> { "Constitution" },
               abilityScoreIncrease = new List<int> { 2 },
               ageMin = 50,
               ageMax = 350,
               alignment = "Lawful Any",
               minHeight = 4,
               maxHeight = 5,
               weight = 150,
               size = "Medium",
               speed = 25,
               feature = new List<Race.Speicals>{
                    new Race.Speicals{
                         Name= "DarkVision",
                         Description = "You can see in dim light withint 60 feet if it were bright light, and in darkness if it were dim light. No color in darkness, only shades of gray."
                    },
                    new Race.Speicals{
                         Name = "ArmorMobility",
                         Description ="Speed is not reduced by wearing heavy armor."
                    },
                    new Race.Speicals{
                         Name = "Stonecunning",
                         Description ="Proficent in history checks involving stonework.You will double your proficiency bonus when adding to the checks."
                    }

               },
               advantageRolls = new List<string> { "Posion" },
               resistance = new List<string> { "Posion" },
               itemProficiencies = new List<Race.Proficiency> {
                    new Race.Proficiency {
                         Name =  "Weapon",
                         List = new List<string>{"Battle Axe","Hand Axe","Light Hammer","War Hammer" }
                    },
                    new Race.Proficiency
                    {
                         Name = "Any",
                         List = new List<string> {"Smith's Tools", "Brewer's Supplies", "Mason's Tools"}
                    }
               },
               skillProficiencies = new List<Race.Speicals> { },
               languages = new List<string> { "Speak, Read and Write in Common", "Speak, Read and Write in Dwarvish" },
               subRaces = new List<string> { "Hill Dwarf", "Mountain Dwarf" },
               feat = new List<Race.Speicals> { },
               spellsKnown = new List<string> { }
          });
          //==========================================================================================================================//
          Race.Add(new Race{
               raceName = "Elf",
               abilityScoreName = new List<string> { "Dexterity" },
               abilityScoreIncrease = new List<int> { 2 },
               ageMin = 100,
               ageMax = 750,
               alignment = "Chaotic Any",
               minHeight = 5,
               maxHeight = 6,
               weight = 100,
               size = "Medium",
               speed = 30,
               feature = new List<Race.Speicals>{
                    new Race.Speicals{
                         Name= "DarkVision",
                         Description = "You can see in dim light withint 60 feet if it were bright light, and in darkness if it were dim light. No color in darkness, only shades of gray."
                    },
                    new Race.Speicals{
                         Name = "Fey Ancestry",
                         Description ="Cannot be put to sleep with magic."
                    },
                    new Race.Speicals{
                         Name ="Trance",
                         Description ="Don't need to sleep for 8 hours, instead they meditate deelpy for 4 hours."
                    }
               },
               advantageRolls = new List<string> { "Charmed" },
               resistance = new List<string> { },
               itemProficiencies = new List<Race.Proficiency> { },
               skillProficiencies = new List<Race.Speicals> {
                    new Race.Speicals{
                         Name = "Keen Sense",
                         Description = "You are naturally proficient in Perception",
                    }
               },
               languages = new List<string> { "Speak, Read and Write in Common", "Speak, Read and Write in Elvish" },
               subRaces = new List<string> { "High Elf", "Wood Elf", "Drow" },
               feat = new List<Race.Speicals> { },
               spellsKnown = new List<string> { }
          });
          //==========================================================================================================================//
          Race.Add(new Race{
               raceName = "Halfling",
               abilityScoreName = new List<string> { "Dexterity" },
               abilityScoreIncrease = new List<int> { 2 },
               ageMin = 20,
               ageMax = 100,
               alignment = "Lawful Good",
               minHeight = 2,
               maxHeight = 3,
               weight = 40,
               size = "Small",
               speed = 25,
               feature = new List<Race.Speicals>{
                    new Race.Speicals{
                         Name= "Lucky",
                         Description = "When you roll a 1 on a d20 for attack roll, ability check, or saving throw, you can reroll the die and must use the new roll."
                    },
                    new Race.Speicals{
                         Name = "Halfling Nimbleness",
                         Description ="You can move through the space of any creature larger then you."
                    }
               },
               advantageRolls = new List<string> { "Frightened" },
               resistance = new List<string> { },
               itemProficiencies = new List<Race.Proficiency> { },
               skillProficiencies = new List<Race.Speicals> { },
               languages = new List<string> { "Speak, Read and Write in Common", "Speak, Read and Write in Halfling" },
               subRaces = new List<string> { "Light Foot", "Stout" },
               feat = new List<Race.Speicals> { },
               spellsKnown = new List<string> { }
          });
          //==========================================================================================================================//
          Race.Add(new Race{
               raceName = "Human",
               abilityScoreName = new List<string> { "Each stat increase" },
               abilityScoreIncrease = new List<int> { 1},
               ageMin = 15,
               ageMax = 70,
               alignment = "Any",
               minHeight = 5,
               maxHeight = 6,
               weight = 125,
               size = "Medium",
               speed = 30,
               feature = new List<Race.Speicals>{ },
               advantageRolls = new List<string> { },
               resistance = new List<string> { },
               itemProficiencies = new List<Race.Proficiency> { },
               skillProficiencies = new List<Race.Speicals> {
                    new Race.Speicals{
                         Name = "Any",
                         Description = "Any",
                    }
               },
               languages = new List<string> { "Speak, Read and Write in Common", "Any" },
               subRaces = new List<string> { },
               feat = new List<Race.Speicals> {
                   new Race.Speicals {
                       Name="Any",
                       Description ="Any"
                   }
               },
               spellsKnown = new List<string> { }
          });
          //==========================================================================================================================//
          Race.Add(new Race{
               raceName = "Dragonborn",
               abilityScoreName = new List<string> { "Strength","Charisma" },
               abilityScoreIncrease = new List<int> { 2 , 1},
               ageMin = 15,
               ageMax = 80,
               alignment = "Any Good",
               minHeight = 6,
               maxHeight = 6,
               weight = 250,
               size = "Medium",
               speed = 30,
               feature = new List<Race.Speicals>{
                    new Race.Speicals{
                         Name= "Draconic Ancestry",
                         Description = "Chooseing the type of Dragon you are will give you a resistance to that element and elemental breath damage."
                    }
               },
               advantageRolls = new List<string> { },
               resistance = new List<string> { },
               itemProficiencies = new List<Race.Proficiency> { },
               skillProficiencies = new List<Race.Speicals> { },
               languages = new List<string> { "Speak, Read and Write in Common", "Speak, Read and Write in Draconic" },
               subRaces = new List<string> { "Black", "Blue" , "Brass", "Bronze", "Copper" , "Gold", "Green", "Red","Silver" ,"White"},
               feat = new List<Race.Speicals> { },
               spellsKnown = new List<string> { }
          });
          //==========================================================================================================================//
          Race.Add(new Race{
               raceName = "Gnome",
               abilityScoreName = new List<string> { "Intelligence" },
               abilityScoreIncrease = new List<int> { 2 },
               ageMin = 40,
               ageMax = 500,
               alignment = "Any Good",
               minHeight = 3,
               maxHeight = 4,
               weight = 40,
               size = "Small",
               speed = 25,
               feature = new List<Race.Speicals>{
                    new Race.Speicals{
                         Name= "Dark Vision",
                         Description = "You can see in dim light withint 60 feet if it were bright light, and in darkness if it were dim light. No color in darkness, only shades of gray."
                    }
               },
               advantageRolls = new List<string> { "Intelligence","Wisdom","Charisma"},
               resistance = new List<string> { },
               itemProficiencies = new List<Race.Proficiency> { },
               skillProficiencies = new List<Race.Speicals> { },
               languages = new List<string> { "Speak, Read and Write in Common", "Speak, Read and Write in Gnomish" },
               subRaces = new List<string> {"Forest Gnome","Rock Gnome"},
               feat = new List<Race.Speicals> { },
               spellsKnown = new List<string> { }
          });
          //==========================================================================================================================//
          Race.Add(new Race{
               raceName = "Half Elf",
               abilityScoreName = new List<string> { "Charisma", "Any","Any" },
               abilityScoreIncrease = new List<int> { 2,1,1 },
               ageMin = 20,
               ageMax = 180,
               alignment = "Chaotic Any",
               minHeight = 5,
               maxHeight = 6,
               weight = 100,
               size = "Medium",
               speed = 30,
               feature = new List<Race.Speicals>{
                    new Race.Speicals{
                         Name= "DarkVision",
                         Description = "You can see in dim light withint 60 feet if it were bright light, and in darkness if it were dim light. No color in darkness, only shades of gray."
                    },
                    new Race.Speicals{
                         Name = "Fey Ancestry",
                         Description ="Cannot be put to sleep with magic."
                    }
               },
               advantageRolls = new List<string> { "Charmed" },
               resistance = new List<string> { },
               itemProficiencies = new List<Race.Proficiency> { },
               skillProficiencies = new List<Race.Speicals> {
                    new Race.Speicals{
                         Name = "Any",
                         Description = "Any",
                    },
                    new Race.Speicals{
                         Name = "Any",
                         Description = "Any",
                    },
               },
               languages = new List<string> { "Speak, Read and Write in Common", "Speak, Read and Write in Elvish" },
               subRaces = new List<string> { },
               feat = new List<Race.Speicals> { },
               spellsKnown = new List<string> { }
          });
          //==========================================================================================================================//
          Race.Add(new Race{
               raceName = "Half Orc",
               abilityScoreName = new List<string> { "Charisma", "Constitution"},
               abilityScoreIncrease = new List<int> { 2, 1 },
               ageMin = 14,
               ageMax = 75,
               alignment = "Chaotic Any",
               minHeight = 5,
               maxHeight = 6,
               weight = 150,
               size = "Medium",
               speed = 30,
               feature = new List<Race.Speicals>{
                    new Race.Speicals{
                         Name= "DarkVision",
                         Description = "You can see in dim light withint 60 feet if it were bright light, and in darkness if it were dim light. No color in darkness, only shades of gray."
                    },
                    new Race.Speicals{
                         Name = "Relentless Endurance",
                         Description ="when your health drops to 0, you can drop to 1 hit point instead. Can't be used again until a long rest."
                    },
                    new Race.Speicals{
                         Name = "Savage Attacks",
                         Description ="When you roll a critical  hit, you can roll one of the weapon's damage dice an aditional time and add it to the critical hit."
                    }
               },
               advantageRolls = new List<string> { },
               resistance = new List<string> { },
               itemProficiencies = new List<Race.Proficiency> { },
               skillProficiencies = new List<Race.Speicals> {
                    new Race.Speicals {
                         Name="Menacing",
                         Description ="You are naturally proficient in Intimidation"
                    }
               },
               languages = new List<string> { "Speak, Read and Write in Common", "Speak, Read and Write in Orc" },
               subRaces = new List<string> { },
               feat = new List<Race.Speicals> { },
               spellsKnown = new List<string> { }
          });
          //===============================================================================================================
          Race.Add(new Race{
               raceName = "Tiefling",
               abilityScoreName = new List<string> { "Intelligence", "Charisma" },
               abilityScoreIncrease = new List<int> { 1, 2 },
               ageMin = 15,
               ageMax = 70,
               alignment = "Chaotic Evil",
               minHeight = 5,
               maxHeight = 6,
               weight = 125,
               size = "Medium",
               speed = 30,
               feature = new List<Race.Speicals>{
                    new Race.Speicals{
                         Name= "DarkVision",
                         Description = "You can see in dim light withint 60 feet if it were bright light, and in darkness if it were dim light. No color in darkness, only shades of gray."
                    },
                    new Race.Speicals{
                         Name = "Infernal Legacy",
                         Description ="know Thaumaturgy cantrip, at 3rd level you know Hellish Rebuke as a second level spell but need a long rest to use again, at 5th level you may cast darkness."
                    }
               },
               advantageRolls = new List<string> { },
               resistance = new List<string> { "fire" },
               itemProficiencies = new List<Race.Proficiency> { },
               skillProficiencies = new List<Race.Speicals> { },
               languages = new List<string> { "Speak, Read and Write in Common", "Speak, Read and Write in Infernal" },
               subRaces = new List<string> { },
               feat = new List<Race.Speicals> { },
               spellsKnown = new List<string> {"Thaumaturgy", "Hellish Rebuke", "Darkness" }
          });
          finished = true;
          return 0;
     }

     public int loadSubRace(string race){
          SubRace = new List<SubRace>();
          switch (race){
               case "Dwarf":
                    SubRace.Add(new SubRace {
                         subRaceName = "Hill Dwarf",
                         abilityScoreName = new List<string> { "Wisdom" },
                         abilityScoreIncrease = new List<int> { 1 },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name = "Dwarven Toughness",
                                   Description = "Your hit point increases by 1 and every time you level up by 1."
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { "HillDwarf"}
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Mountain Dwarf",
                         abilityScoreName = new List<string> { "Strength" },
                         abilityScoreIncrease = new List<int> { 2 },
                         speed = 0,
                         feature = new List<SubRace.Speicals> { },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> {
                              new SubRace.Proficiency{
                                   Name = "Armor",
                                   List = new List<string>{ "Light Armor", "Medium Armor"}
                              }
                         },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    break;
               case "Elf":
                    SubRace.Add(new SubRace{
                         subRaceName = "High Elf",
                         abilityScoreName = new List<string> { "Intelligence" },
                         abilityScoreIncrease = new List<int> { 1 },
                         speed = 0,
                         feature = new List<SubRace.Speicals> { },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> {
                              new SubRace.Proficiency{
                                   Name = "Weapon",
                                   List = new List<string>{ "Longsword", "Shortsword","ShortBow","Longbow"}
                              }
                         },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> {"Any"},
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> {"Any Cantrip"},
                         functionCall = new List<string> {}
                    });

                    SubRace.Add(new SubRace{
                         subRaceName = "Wood Elf",
                         abilityScoreName = new List<string> { "Wisdom" },
                         abilityScoreIncrease = new List<int> { 1 },
                         speed = 35,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name ="Mask of the Wild",
                                   Description ="May hide even when you are lightly obscured by foliage, heavy rain, falling snow, mist and other natural phenomena."
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> {
                              new SubRace.Proficiency{
                                   Name = "Weapon",
                                   List = new List<string>{ "Longsword", "Shortsword","ShortBow","Longbow"}
                              }
                         },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> {  },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Drow",
                         abilityScoreName = new List<string> { "Charisma" },
                         abilityScoreIncrease = new List<int> { 1 },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name ="Superior DarkVision",
                                   Description ="See 120 feet in the darkvision."
                              },
                              new SubRace.Speicals{
                                   Name ="Sunlight Sensitivity",
                                   Description ="Disadvantage on attack rolls and on Wisdom checks on your target in direct sunlight."
                              },
                              new SubRace.Speicals{
                                   Name ="Drow Magic",
                                   Description ="Learns cantrip Dancing Lights, 3rd level obtains Faerie Fire and 5th level you get Darkness which must have a long rest to regain these spells"
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> {
                              new SubRace.Proficiency{
                                   Name = "Weapon",
                                   List = new List<string>{ "Shortsword","Rapiers","Hand Crossbow"}
                              }
                         },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> {"Dancing Lights","Faerie Fire","Darkness" },
                         functionCall = new List<string> { }
                    });
                    break;
               case "Halfling":
                    SubRace.Add(new SubRace{
                         subRaceName = "Lightfoot",
                         abilityScoreName = new List<string> { "Charisma" },
                         abilityScoreIncrease = new List<int> { 1 },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name = "Natrually Stealthy",
                                   Description = "Able to hide behing a creature that is at least once size larger than you."
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Stout",
                         abilityScoreName = new List<string> { "Constitution" },
                         abilityScoreIncrease = new List<int> { 1 },
                         speed = 0,
                         feature = new List<SubRace.Speicals> { },
                         advantageRolls = new List<string> {"Posion" },
                         resistance = new List<string> { "Posion" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    break;
               case "Human":
                    SubRace.Add(new SubRace{
                         subRaceName = "N/A",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> { },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    break;
               case "Dragonborn":
                    SubRace.Add(new SubRace{
                         subRaceName = "Black Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 5 by 30ft line destructive energy.Enemy must succeed  your DC of (8 + dex modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 Acid Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> {"Acid"},
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Blue Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 5 by 30ft line destructive energy.Enemy must succeed  your DC of (8 + dex modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 Lightning Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Lightning" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Brass Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 5 by 30ft line destructive energy.Enemy must succeed  your DC of (8 + dex modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 Fire Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Fire" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Bronze Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 5 by 30ft line destructive energy.Enemy must succeed  your DC of (8 + dex modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 Lightning Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Lightning" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Copper Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 5 by 30ft line destructive energy.Enemy must succeed  your DC of (8 + dex modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 Acid Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Acid" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Gold Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 30ft cone destructive energy.Enemy must succeed  your DC of (8 + dex modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 fire Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Fire" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Green Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 30ft cone destructive energy.Enemy must succeed  your DC of (8 + con modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 Posion Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Posion" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Red Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 30ft cone destructive energy.Enemy must succeed  your DC of (8 + dex modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 fire Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Fire" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Silver Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 30ft cone destructive energy.Enemy must succeed  your DC of (8 + con modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 Cold Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Cold" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "White Dragon",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Breath Weapon",
                                   Description = @"Use an action to exhale a 30ft cone destructive energy.Enemy must succeed  your DC of (8 + con modifier + proficiency bonus). 
                                                  If enemy rolls higher, it takes half damage. 
                                                  You deal 2d6 Cold Damage. Damage increases to 3d6 at level 6, 4d6 at 11 and 5d6 at 16",
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { "Cold" },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    break;
               case "Gnome":
                    SubRace.Add(new SubRace{
                         subRaceName = "Forest Gnome",
                         abilityScoreName = new List<string> {"Dexterity"},
                         abilityScoreIncrease = new List<int> {1},
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Speak With Small Beasts",
                                   Description = "You are able to communicate with simple ideas to small or smaller beasts"
                              }
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { "Natural Illusionist"},
                         functionCall = new List<string> { }
                    });
                    SubRace.Add(new SubRace{
                         subRaceName = "Rock Gnome",
                         abilityScoreName = new List<string> { "Constitution" },
                         abilityScoreIncrease = new List<int> { 1 },
                         speed = 0,
                         feature = new List<SubRace.Speicals> {
                              new SubRace.Speicals{
                                   Name="Artificer's Lore",
                                   Description = @"when ever you do a Intellegence(history) checks involving magic items, achemical objects
                                                   or technological devices, you are able to add twice your proficiency bonus onto your roll"
                              },
                              new SubRace.Speicals{
                                   Name="Tinker",
                                   Description = @"Proficent in Artisan's tools. While using them, you can spen 1 hour and 10 gold worth of material
                                                   to construct a Tiny clockworck device (AC 5 HP1). The device cease function after 25 hours unless
                                                    spending 1 hour to repair) or when you use your action to dismantle it. at the time you can reclaim
                                                   the materials and recreate it. You can have up to 3 devices.
                                                   Possible choices are:  create clockwork Toy, fire Start and music box"
                              },
                         },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { "Natural Illusionist" },
                         functionCall = new List<string> { }
                    });
                    break;
               case "Half Elf":
                    SubRace.Add(new SubRace{
                         subRaceName = "N/A",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> { },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    break;
               case "Half Orc":
                    SubRace.Add(new SubRace{
                         subRaceName = "N/A",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> { },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    break;
               case "Tiefling":
                    SubRace.Add(new SubRace{
                         subRaceName = "N/A",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> { },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    break;
               default:
                    SubRace.Add(new SubRace{
                         subRaceName = "N/A",
                         abilityScoreName = new List<string> { },
                         abilityScoreIncrease = new List<int> { },
                         speed = 0,
                         feature = new List<SubRace.Speicals> { },
                         advantageRolls = new List<string> { },
                         resistance = new List<string> { },
                         itemProficiencies = new List<SubRace.Proficiency> { },
                         skillProficiencies = new List<SubRace.Speicals> { },
                         languages = new List<string> { },
                         feat = new List<SubRace.Speicals> { },
                         spellsKnown = new List<string> { },
                         functionCall = new List<string> { }
                    });
                    break;
          };
          return 0;
     }

     
     public void loadClass(string choice) {
          switch (choice) {
               case "Barbarian":
                    combatClass = new CombatClass {
                         className = "Barbarian",
                         hitPoints = 12,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"Light Armor","Medium Armor","Shield" }
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapons","Martial Weapons" }
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"None" }
                              }
                         },
                         savingThrows = new List<string> { "Strength", "Constitution"},
                         skillNumber = 2,
                         skillChoices = new List<string> { "Animal Handling", "Athletics", "Itimidation", "Nature", "Perception", "Survival"},
                         features = new List<CombatClass.SkillGain> {
                              //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rage",
                                   Level =1,
                                   Description ="On your turn, Go into a 'Rage' as a bonus action. You will gain benefits while not wearing armor. \n 1. Advantage on Strength Check and Throws. \n 2.When you attack using strength, you gain bonus to the damage based on rage damage. \n 3. You have resistance to bludgeonig, piercing, and slashing damage. \n  Can't cast spells when raging, last one's minute but earlier if knocked unconscious, turn ends without atacking a hostile creature, or taking damage. To regain your number of uses of rage, you need to take a long rest."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Defense",
                                   Level =1,
                                   Description ="While note wearing any armor, your armor class is 10+ your Dexterity modifier + your Constitution modifier. You can use a shield and still gain this benefit."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rages",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rage Damage",
                                   Level =1,
                                   Description ="2"
                              },
                              
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Reckless Attack",
                                   Level =2,
                                   Description ="First attack on your turn, gives you an advantage on atack rolls using strength but enemies get an advantage on attacks against you until next turn."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Danger Sense",
                                   Level =2,
                                   Description ="Advantage on Dexterity saving throws against effects you can see. This doesnt work if you're blinded, deafened or incapacitated."
                              },
                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =3,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rages",
                                   Level =3,
                                   Description ="3"
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Extra Attack",
                                   Level =5,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Fast Movement",
                                   Level =5,
                                   Description ="Increase movement by 10 while not wearing heavy armor."
                              },
                              
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Rages",
                                   Level =6,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype Features",
                                   Level =6,
                                   Description =""
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Feral Instinct",
                                   Level =7,
                                   Description ="You gain advantage on initiative rolls."
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Brutal Critical",
                                   Level =9,
                                   Description ="You can roll 1 aditional weapon damage die when determining the extra damage for critical hits with melee attacks."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rage Damage",
                                   Level =9,
                                   Description ="3"
                              },
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype Features",
                                   Level =10,
                                   Description =""
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Relentless Rage",
                                   Level =11,
                                   Description ="If you drop to 0 Health while raging, you can make a Constitution Saving Throw to roll higher than a DC of 10. You will be set to 1 health instead. \n Each time you use it after the first, the DC increases by 5. After a short or long rest, the DC resets to 10."
                              },
                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rages",
                                   Level =12,
                                   Description ="5"
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Brutal Critical",
                                   Level =13,
                                   Description ="You can roll 2 aditional weapon damage die when determining the extra damage for critical hits with melee attacks."
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype Features",
                                   Level =14,
                                   Description =""
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Presistent Rage",
                                   Level =15,
                                   Description ="Your rage can only end early if unconscious or you end it."
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rage Damage",
                                   Level =16,
                                   Description ="4"
                              },
                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Brutal Critical",
                                   Level =17,
                                   Description ="You can roll 3 aditional weapon damage die when determining the extra damage for critical hits with melee attacks."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rages",
                                   Level =17,
                                   Description ="6"
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Indomitable Might",
                                   Level =18,
                                   Description ="If your Strength Check is less than your Strength Score, you can use the score in place of the total."
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Primal Champion",
                                   Level =20,
                                   Description ="Your Strength and Constitution scores increase by 4, your max scores is now 24."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Rages",
                                   Level =20,
                                   Description ="Unlimited"
                              }
                         },
                         archetype = new List<string> { "Path of the Berserker", "Path of the Totem Warrior" }
                    };
                    break;
               case "Bard":
                    combatClass = new CombatClass {
                         className = "Bard",
                         hitPoints = 8,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"Light Armor"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapons","Hand Crossbows","Longswords","Rapiers","Shortswords"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{ }
                              }
                         },
                         savingThrows = new List<string> {"Dexterity","Charisma"},
                         skillNumber = 3,
                         skillChoices = new List<string> {"Acrobatics","Animal Handling","Arcana","Athletics","Deception","History","Insight","Intimidation","Investigation","Medicine","Nature","Perception","Performance", "Presuasion", "Religion", "Sleight of Hand", "Stealth", "Survival"},
                         features = new List<CombatClass.SkillGain> {
                              //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =1,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="SpellCasting",
                                   Level =1,
                                   Description ="Able to cast bard Spells"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Bardic Inspiration",
                                   Level =1,
                                   Description ="As a bonus action, you choose one creature other than yourself that's 60 feet and can hear you. That creature gains a D6. In the next 10 minutes, that creature can add the roll from the d6 onto an attack roll, ability check or saving throw. This is only after the d20 is rolled, once the roll is made, the die is lost, creatures can only hold 1 inspiration die at a time. You can use it depending on your Charisma Modifier (minimum 1) and you need a long rest to reset the uses. "
                              },
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =2,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =2,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Jack of All Trades",
                                   Level =2,
                                   Description ="You can add half of your proficiency bonus, rounded down, to any ability check you make that doesn't include your proficiency bonus."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Song of Rest",
                                   Level =2,
                                   Description ="Use music or oration to help revitalize your wounded allies during a short rest.You or friendly creatures who hear the performance and regain health at the end of a short rest can regain an extra 1D6 hitpoints."
                              },
                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =3,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =3,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =3,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =3,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Expertise",
                                   Level =3,
                                   Description ="Choose 2 of your proficiencies. Your proficiency bonus is doubled for any ability checks of those that are chosen."
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =4,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =4,
                                   Description ="7"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =4,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =5,
                                   Description ="8"
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =5,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Bardic Inspiration",
                                   Level =5,
                                   Description ="As a bonus action, you choose one creature other than yourself that's 60 feet and can hear you. That creature gains a D8. In the next 10 minutes, that creature can add the roll from the d6 onto an attack roll, ability check or saving throw. This is only after the d20 is rolled, once the roll is made, the die is lost, creatures can only hold 1 inspiration die at a time. You can use it depending on your Charisma Modifier (minimum 1) and you need a long rest to reset the uses. "
                              },
                              new CombatClass.SkillGain {
                                   Name ="Font of Inspiration",
                                   Level =5,
                                   Description ="You regain inspiration uses after a short or long rest."
                              },
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =6,
                                   Description ="9"
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =6,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =6,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Countercharm",
                                   Level =6,
                                   Description ="As an action, you can start a performance that last til the end of your turn. During this, friendly creatures gain advantage throws against being frightened or charmed. Creature must hear you to work, it ends early if you are incapacitated or silenced."
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =7,
                                   Description ="10"
                              },
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =7,
                                   Description ="1"
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =8,
                                   Description ="11"
                              },
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =8,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =9,
                                   Description ="12"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =9,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =9,
                                   Description ="1"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Song of Rest",
                                   Level =9,
                                   Description ="Use music or oration to help revitalize your wounded allies during a short rest.You or friendly creatures who hear the performance and regain health at the end of a short rest can regain an extra 1D8 hitpoints."
                              },
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =10,
                                   Description ="14"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =10,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =10,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Bardic Inspiration",
                                   Level =10,
                                   Description ="As a bonus action, you choose one creature other than yourself that's 60 feet and can hear you. That creature gains a D10. In the next 10 minutes, that creature can add the roll from the d6 onto an attack roll, ability check or saving throw. This is only after the d20 is rolled, once the roll is made, the die is lost, creatures can only hold 1 inspiration die at a time. You can use it depending on your Charisma Modifier (minimum 1) and you need a long rest to reset the uses. "
                              },
                              new CombatClass.SkillGain {
                                   Name ="Expertise",
                                   Level =10,
                                   Description ="Choose 4 of your proficiencies. Your proficiency bonus is doubled for any ability checks of those that are chosen."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Magical Secrets",
                                   Level =10,
                                   Description ="You choose 2 spells of any class including this one. Must be a level you can cast, these aren't new additional spells known."
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =11,
                                   Description ="15"
                              },
                              new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =11,
                                   Description ="1"
                              },
                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =14,
                                   Description ="16"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =13,
                                   Description ="1"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Song of Rest",
                                   Level =13,
                                   Description ="Use music or oration to help revitalize your wounded allies during a short rest.You or friendly creatures who hear the performance and regain health at the end of a short rest can regain an extra 1D10 hitpoints."
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =14,
                                   Description ="18"
                              },

                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =14,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Magical Secrets",
                                   Level =14,
                                   Description ="You choose 2 spells of any class including this one. Must be a level you can cast, these aren't new additional spells known."
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =15,
                                   Description ="19"
                              },
                              new CombatClass.SkillGain {
                                   Name ="8th Level Spell Slot",
                                   Level =15,
                                   Description ="1"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Bardic Inspiration",
                                   Level =15,
                                   Description ="As a bonus action, you choose one creature other than yourself that's 60 feet and can hear you. That creature gains a D12. In the next 10 minutes, that creature can add the roll from the d6 onto an attack roll, ability check or saving throw. This is only after the d20 is rolled, once the roll is made, the die is lost, creatures can only hold 1 inspiration die at a time. You can use it depending on your Charisma Modifier (minimum 1) and you need a long rest to reset the uses. "
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =17,
                                   Description ="20"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="9th Level Spell Slot",
                                   Level =17,
                                   Description ="1"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Song of Rest",
                                   Level =17,
                                   Description ="Use music or oration to help revitalize your wounded allies during a short rest.You or friendly creatures who hear the performance and regain health at the end of a short rest can regain an extra 1D12 hitpoints."
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =18,
                                   Description ="22"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =18,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Magical Secrets",
                                   Level =18,
                                   Description ="You choose 2 spells of any class including this one. Must be a level you can cast, these aren't new additional spells known."
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =19,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                             new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =20,
                                   Description ="2"
                              },
                             new CombatClass.SkillGain {
                                   Name ="Superior Inspiration",
                                   Level =20,
                                   Description ="on an initiative roll, if you have no bardic inspiration left, you regain one use."
                              }
                         },
                         archetype = new List<string> {"College of Lore","College of Valor"}
                    };
                    break;
               case "Cleric":
                    combatClass = new CombatClass {
                         className = "Cleric",
                         hitPoints = 8,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                         new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"Light Armor","Medium Armor", "Shields"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapons"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"None"}
                              }
                         },
                         savingThrows = new List<string> {"Wisdom","Charisma"},
                         skillNumber = 2,
                         skillChoices = new List<string> {"History","Insight","Medicine","Presuasion","Religion"},
                         features = new List<CombatClass.SkillGain> {       
                              //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =1,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =1,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spellcasting",
                                   Level =1,
                                   Description ="Through divine power, you can cast cleric spells only."
                              },
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =2,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Channel Divinity",
                                   Level =2,
                                   Description ="You gain the ability to channel your divine power from your deity, using the energy to do varius effects. You gain unquie Divinity abilities depending on the domain you choose. \n when you choose which divinity you use, you can only do it once before short or long rest to use another one."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =2,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Channel Divinity: Turn Undead",
                                   Level =2,
                                   Description ="as an action, you use your holy smybol and speak a prayer towards an undead within 30 feet that must be able to hear you. It then makes a wisdom saving throw, if fails the creature must try to spend it's actions dashing away from you for up to 1 minute. If it succeeds, nothing happens."
                              },
                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =3,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =3,
                                   Description ="2"
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Cantrips",
                                   Level =4,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =4,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =5,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Destroy Undead",
                                   Level =5,
                                   Description ="If an undead fails the throw while using 'Turn Undead' on it, it will be destroyed if it's 'Challenge rating' is 1/2 or lower."
                              },
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =6,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =6,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Channel Divinity",
                                   Level =6,
                                   Description ="You gain the ability to channel your divine power from your deity, using the energy to do varius effects. You gain unquie Divinity abilities depending on the domain you choose. \n You can only use 2 divinity before needing a short rest or long rest to recharge."
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =7,
                                   Description ="1"
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =8,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Destroy Undead",
                                   Level =5,
                                   Description ="If an undead fails the throw while using 'Turn Undead' on it, it will be destroyed if it's 'Challenge rating' is 1 or lower."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =8,
                                   Description =""
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =9,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =9,
                                   Description ="1"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                              
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Divine Intervention",
                                   Level =10,
                                   Description ="You use an action to require aid from your deity. You must roll a percential die, to succeed you need to roll lower than or equal to your level. Upon success, your Dungeon Master chooses the nature and effect of any cleric or cleric domiain spell would be appropriate. Success, you can't use this spell for 7 days. Upon failure, you need a long rest before using it again."
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =10,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Cantrips",
                                   Level =10,
                                   Description ="5"
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Destroy Undead",
                                   Level =11,
                                   Description ="If an undead fails the throw while using 'Turn Undead' on it, it will be destroyed if it's 'Challenge rating' is 2 or lower."
                              },
                              new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =11,
                                   Description ="1"
                              },

                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =18,
                                   Description ="1"
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Destroy Undead",
                                   Level =14,
                                   Description ="If an undead fails the throw while using 'Turn Undead' on it, it will be destroyed if it's 'Challenge rating' is 3 or lower."
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="8th Level Spell Slot",
                                   Level =15,
                                   Description ="1"
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =17,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Destroy Undead",
                                   Level =17,
                                   Description ="If an undead fails the throw while using 'Turn Undead' on it, it will be destroyed if it's 'Challenge rating' is 4 or lower."
                              },
                              new CombatClass.SkillGain {
                                   Name ="9th Level Spell Slot",
                                   Level =17,
                                   Description ="1"
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Channel Divinity",
                                   Level =18,
                                   Description ="You gain the ability to channel your divine power from your deity, using the energy to do varius effects. You gain unquie Divinity abilities depending on the domain you choose. \n You can only use 3 divinity before needing a short rest or long rest to recharge."
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =18,
                                   Description ="3"
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =19,
                                   Description ="2"
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Divine Intervention Improvement",
                                   Level =20,
                                   Description ="Your Divine Inervention auto succeeds with no roll required."
                              },
                              new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =20,
                                   Description ="2"
                              },
                         },
                         archetype = new List<string> {"Knowledge","Life","Light","Nature","Tempest","Trickery","War","Death"}
                    };
                    break;
               case "Druid":
                    combatClass = new CombatClass {
                         className = "Druid",
                         hitPoints = 8,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"Non-Metal Light Armor, Non-Metal Medium Armor, Non-Metal Sheilds"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Clubs","Daggers","Darts","Javelins","Maces","Quarterstaffs", "Scimitars","Sickles","Slings","Spears"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"Herbalism kit"}
                              }
                         },
                         savingThrows = new List<string> { "Intelligence", "Wisdom" },
                         skillNumber = 2,
                         skillChoices = new List<string> { "Arcana", "Animal", "Handling", "Insight", "Medicine", "Nature", "Perception", "Religion", "Survival" },
                         features = new List<CombatClass.SkillGain> {
                              //===1st level==========================================================//
                              new CombatClass.SkillGain { 
                                   Name ="Druidic",
                                   Level =1,
                                   Description ="You gain the knowledge of a secret language of druids. You can speak it and use it to leave hidden messages. Those who do not know druidic must succeed a Perception check of DC 15 to decipher it without magic."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spellcasting",
                                   Level =1,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Cantrips",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =1,
                                   Description ="2"
                              },
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =2,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =2,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Wild Shape",
                                   Level =2,
                                   Description ="You transform yourself into an animal with a 'challenge rating' of 1/4 or below (it cannot know how to fly or swim). You can only do this twice, you need to perform a short or long rest to regain uses. \n You stay in form for a few hours, your level halfed and rounded down. You lose form if you fall unconcious or die.\nYou retain alignment, personality, intellegences, wisdom, and charisma scores. Your saving throw perficiencies. The rest becames the creatures. You cannot do the creature's legendary actions \n You gain the creature's health points. When the health points drop to zero, you transform back with your current health before you transformed. Any excess damage will be carried over.  \n Can't cast spells, speak and are limited using your hands depending on beast form. \n You choose if your equipment falls off or if they merged with you."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =2,
                                   Description =""
                              },

                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =3,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =3,
                                   Description ="3"
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Cantrips",
                                   Level =4,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Wild Shape",
                                   Level =4,
                                   Description ="You transform yourself into an animal with a 'challenge rating' of 1/2 or below (it cannot know how to fly). You can only do this twice, you need to perform a short or long rest to regain uses. \n You stay in form for a few hours, your level halfed and rounded down. You lose form if you fall unconcious or die.\nYou retain alignment, personality, intellegences, wisdom, and charisma scores. Your saving throw perficiencies. The rest becames the creatures. You cannot do the creature's legendary actions \n You gain the creature's health points. When the health points drop to zero, you transform back with your current health before you transformed. Any excess damage will be carried over.  \n Can't cast spells, speak and are limited using your hands depending on beast form. \n You choose if your equipment falls off or if they merged with you."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =5,
                                   Description ="2"
                              },
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =6,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =6,
                                   Description =""
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =7,
                                   Description ="1"
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =8,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Wild Shape",
                                   Level =8,
                                   Description ="You transform yourself into an animal with a 'challenge rating' of 1 or below. You can only do this twice, you need to perform a short or long rest to regain uses. \n You stay in form for a few hours, your level halfed and rounded down. You lose form if you fall unconcious or die.\nYou retain alignment, personality, intellegences, wisdom, and charisma scores. Your saving throw perficiencies. The rest becames the creatures. You cannot do the creature's legendary actions \n You gain the creature's health points. When the health points drop to zero, you transform back with your current health before you transformed. Any excess damage will be carried over.  \n Can't cast spells, speak and are limited using your hands depending on beast form. \n You choose if your equipment falls off or if they merged with you."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =9,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =9,
                                   Description ="1"
                              },
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Cantrips",
                                   Level =10,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =10,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =10,
                                   Description =""
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =11,
                                   Description ="1"
                              },
                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =13,
                                   Description ="1"
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =14,
                                   Description =""
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="8th Level Spell Slot",
                                   Level =15,
                                   Description ="1"
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="9th Level Spell Slot",
                                   Level =17,
                                   Description ="1"
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =18,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Timless Body",
                                   Level =18,
                                   Description ="Every 10 years, your body only ages 1 year."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Beast Spells",
                                   Level =18,
                                   Description ="You can cast your druid spells in any shape you are in wildshape. You can cast most of the spells except the ones that except material components."
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =19,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =20,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archdruid",
                                   Level =20,
                                   Description ="You can use your wildshape an unlimited number of times."
                              },
                         },
                         archetype = new List<string> { "Circle of The Land-Arctic", "Circle of The Land-Coast", "Circle of The Land-Desert", "Circle of The Land-Forest", "Circle of The Land-Grassland", "Circle of The Land-Mountain", "Circle of The Land-Swamp", "Circle of The Land-Underdark", "Circle of The Moon" }
                    };
                    break;
               case "Fighter":
                    combatClass = new CombatClass {
                         className = "Fighter",
                         hitPoints = 10,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"All Armors", "Shields"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapons","Martial Weapons"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"None"}
                              }
                         },
                         savingThrows = new List<string> {"Strength","Constitution"},
                         skillNumber = 2,
                         skillChoices = new List<string> { "Acrobatics","Animal Handling","Athletics","History","Insight","Intimidation","Perception", "Survival"},
                         features = new List<CombatClass.SkillGain> {
                              //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Fighting Style",
                                   Level =1,
                                   Description ="Choose a fighting style to specilize in. Archery, Defense, Dueling, Great Weapon Fighting, Protection, Two Handed Fighting"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Second Wind",
                                   Level =1,
                                   Description ="On your turn, as a bonus action you can regain health points equal to 1d10 + current level. Once you use this, you must finish a short or long rest to regain the use of this ability."
                              },
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Action Surge",
                                   Level =2,
                                   Description ="On your turn, you can take one additional action on top of your regular action and a possible bonus action.You can only use this feature once and you need to finish a short or long rest before you use it again."
                              },
                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =3,
                                   Description =""
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Extra Attack",
                                   Level =5,
                                   Description ="You can attack twice, instead of once, whenever you take an attack action on your turn."
                              },
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =6,
                                   Description =""
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =7,
                                   Description =""
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Indomitable",
                                   Level =9,
                                   Description ="You can reroll a saving throw that you fail. If you do, you must use the new roll and you can only use this feature once. To regain the use, you need to do a long rest."
                              },
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =10,
                                   Description =""
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Extra Attack",
                                   Level =11,
                                   Description ="You can attack three times, instead of once, whenever you take an attack action on your turn."
                              },
                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Indomitable",
                                   Level =13,
                                   Description ="You can reroll a saving throw that you fail. If you do, you must use the new roll and you can only use this feature twice. To regain the use, you need to do a long rest."
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =14,
                                   Description =""
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =15,
                                   Description =""
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Action Surge",
                                   Level =17,
                                   Description ="On your turn, you can take one additional action on top of your regular action and a possible bonus action.You can only use this feature twice and you need to finish a short or long rest before you use it again."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Indomitable",
                                   Level =17,
                                   Description ="You can reroll a saving throw that you fail. If you do, you must use the new roll and you can only use this feature three times. To regain the use, you need to do a long rest."
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =18,
                                   Description =""
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Extra Attack",
                                   Level =20,
                                   Description ="You can attack four times, instead of once, whenever you take an attack action on your turn."
                              },
                         },
                         archetype = new List<string> {"Champion","Battle Master","Eldritch Knight"}
                    };
                    break;
               case "Monk":
                    combatClass = new CombatClass {
                         className = "Monk",
                         hitPoints = 8,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"None"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapon","Shortswords" }
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{ }
                              }
                         },
                         savingThrows = new List<string> {"Strength","Dexterity"},
                         skillNumber = 2,
                         skillChoices = new List<string> {"Acrobatics","Athletics","History","Insight","Religion","Stealth"},
                         features = new List<CombatClass.SkillGain> {
                              //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Martial Arts Damage",
                                   Level =1,
                                   Description ="1d4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =1,
                                   Description ="0"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Movement",
                                   Level =1,
                                   Description ="0"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Defense",
                                   Level =1,
                                   Description ="When you are wearing no armor and wield no sheild, your AC equals 10 + Dex Modifier + wisdom Modifier"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Martial Arts",
                                   Level =1,
                                   Description ="You can no do more damage with unarmed strikes and monk weapons which are shortswords and any simple melee weapon that isn't two-handed. \n You can use Dex instead of Strength for attack and damage rolls of your unarmed strikes and monk weapons. \n You can roll a d4 in place of normal damage of your unarmed strikes and monk weapons. This increases to d6 on 5th level, d8 on 11th level, d10 on 17th level \n When you attack with an unarmed strike or monk weapon, you may use a bonus action to perform an aditional unarmed strike. "
                              },
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =2,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Movement Bonus",
                                   Level =2,
                                   Description ="10"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ki",
                                   Level =2,
                                   Description ="You obtain mystic energy of Ki. You spend these points to use certain Ki Features, you start with Flurry of Blows, Patient Defense, and Step of the Wind. You regain ki points you must do at least 30 minute meditating then a short or long rest."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Movement",
                                   Level =2,
                                   Description ="Your movement speed increases while you are not wearing armor or wielding a shield. At 9th level, you gain the ability to move along vertical surfaces and across liquids on your turn without falling during the move."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Flurry of Blows",
                                   Level =2,
                                   Description ="Immediately after you take the attack action, you may spend 1 ki point to make 2 unarmed strikes as a bonus action."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Patient Defense",
                                   Level =2,
                                   Description ="You can spend 1 ki point to take the dodge action as a bonus action on your turn."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Step of the Wind",
                                   Level =2,
                                   Description ="1 ki point to take the disengage or dash action as a bonus action on your turn, and your jump distance is doubled for a turn."
                              },
                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =3,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =3,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Deflect Missiles",
                                   Level =3,
                                   Description ="Use your reaction to catch or deflect missles that you are hit by a ranged weapon attack. When you do so, the damage you take from the attack is reduce by 1d10+ Dex modifier + monk level. \n If you reduce the damage to 0, you have caught this weapon in your hand if you have a hand free. You may spend 1 ki point to make a ranged attack with it as the same reaction. You make this attack with proficiency, regardless of weapon proficiencies and the missile counts as a monk weapon for the attack."
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =4,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Slow Fall",
                                   Level =4,
                                   Description ="Use your reaction when you fall to reduce any fall damage you take by the equal amount of your monk level times 5"
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Martial Arts Damage",
                                   Level =5,
                                   Description ="1d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =5,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Extra Attack",
                                   Level =5,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Stunning Strike",
                                   Level =5,
                                   Description ="Hit another creature with a melee weapon attack, you may spend 1 ki point to attempt stunning strike. The target must succeed on a constitution saving throw or be stunned until the end of next turn."
                              },
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =6,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Movement Bonus",
                                   Level =6,
                                   Description ="15"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =6,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ki-Empowered Strikes",
                                   Level =6,
                                   Description ="You unarmed strikes count as magical for the purpose of overcoming resistances and immunity to non magical attacks and damage."
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =7,
                                   Description ="7"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Evasion",
                                   Level =7,
                                   Description ="Spells that make you do a Dexterity Saving Throw to take only half damage now do zero damage if you succeed on the saving throw and half damage if you fail."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Stillness of Mind",
                                   Level =7,
                                   Description ="Use your action to end one effect on yourself that is causing you to be charmed or frightened"
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =8,
                                   Description ="8"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =9,
                                   Description ="9"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Movement Improvement",
                                   Level =9,
                                   Description =" You gain the ability to move along vertical surfaces and across liquids on your turn without falling during the move."
                              },
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =10,
                                   Description ="10"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Movement Bonus",
                                   Level =10,
                                   Description ="20"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Purity of Body",
                                   Level =10,
                                   Description ="You are immune to disease and posion."
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Martial Arts Damage",
                                   Level =11,
                                   Description ="1d8"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =11,
                                   Description ="11"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =11,
                                   Description =""
                              },
                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =12,
                                   Description ="12"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =13,
                                   Description ="13"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Tongue of the Sun and Moon",
                                   Level =13,
                                   Description ="You learn to touch the ki of other minds so that you understand all spoken languages. All creatures that understand a language can understand what you say."
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =14,
                                   Description ="14"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Movement Bonus",
                                   Level =14,
                                   Description ="25"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Diamond Soul",
                                   Level =14,
                                   Description ="Gain Proficiency in all saving throws. If you fail a saving throw, you can use 1 ki to reroll it and take the second results."
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =15,
                                   Description ="15"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Timeless Body",
                                   Level =15,
                                   Description ="You suffer none of the frailty of old age, can't be aged magically. You may still die of old age, but you no longer need food or water to live."
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =16,
                                   Description ="16"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },

                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Martial Arts Damage",
                                   Level =17,
                                   Description ="1d10"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =17,
                                   Description ="17"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =17,
                                   Description =""
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =18,
                                   Description ="18"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Unarmored Movement Bonus",
                                   Level =18,
                                   Description ="30"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Empty Body",
                                   Level =18,
                                   Description ="as an action ,you can spend 4 ki points to become invisible for 1 minute, become resistant to all damage but force damage. Spen 8 ki points to cast astral projection spell without needing the material. You cannot take any other creatures with you."
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =19,
                                   Description ="19"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ki Points",
                                   Level =20,
                                   Description ="20"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Perfect Self",
                                   Level =20,
                                   Description ="When you roll for initiative and have no ki points, you regain 4 ki points."
                              },

                         },
                         archetype = new List<string> {"Way of The Open Hand","Way of Shadow","Way of Four Elements"}
                    };
                    break;
               case "Paladin":
                    combatClass = new CombatClass {
                         className = "Paladin",
                         hitPoints = 10,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"All Armors", "Shields"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapons","Martial Weapons"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"None"}
                              } },
                         savingThrows = new List<string> {"Wisdom","Charisma" },
                         skillNumber = 2,
                         skillChoices = new List<string> {"Athletics","Insight","Intimidation","Medicine","Persuasion","Religion" },
                         features = new List<CombatClass.SkillGain> {
                              //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Divine Sense",
                                   Level =1,
                                   Description ="Strong evil registers like a noxious odor, and powerful good rings like heavenly music.As an action, you can open your awareness to dectect. Until the end of your next turn, you know the location of any celestial, fiend, or undead within 60 feet. You know what type it is, but not it's identity. You can detect the presence of any place or object that has been consecrated or desercated, as with the hallow spell. You can use this equal to 1 + Charisma modifier. You regain it after a long rest."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Lay On Hands",
                                   Level =1,
                                   Description ="You have a pool of healing power that replenish after long rest. Your pool is your level x 5. As an action, you can touch a creature and draw power from the pool to restore a number of hit points. Max you can heal is the max amount remaining in that pool. You can use 5 hit points from the pool to cure the target of one disease or neutralize one posion affecting. You can heal multiple posion and disease if you use more by expanding hit points separately for each one."
                              },
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =2,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Fighting Style",
                                   Level =2,
                                   Description ="Choose one of the following fighting styles, Defense, Dueling, Great Weapon Fighting, Protection."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spellcasting",
                                   Level =2,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Divine Smite",
                                   Level =2,
                                   Description ="When you do a melee weapon attack, you may use a spell slot to deal extra radiant damage to a target. The extra damage is 2d8 for a 1st level spell, for each spell slot higher, it's additional 1d8. Max being 5d8. Damage increases 1d8 if target is undead or a fiend."
                              },
                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =3,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =3,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Divine Health",
                                   Level =3,
                                   Description ="Immune to disease"
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =5,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =5,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Extra Attack",
                                   Level =5,
                                   Description =""
                              },
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Aura of Protection",
                                   Level =6,
                                   Description ="When you or friendly creature within 10 feet of you must make a saving throw. The creature gains a bonous saving throw equal to your charisma modifier (with minimum bonus of +1). You must be conscious to grant this bonus. 18th level, it's 30 feet."
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =7,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =7,
                                   Description =""
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =9,
                                   Description ="2"
                              },
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Aura of Courage",
                                   Level =10,
                                   Description ="You and friendly creatues within 10 feet of you can't be frightened while you are concious. At 18th level, it's 30 feet."
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =11,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Improved Divine Smite",
                                   Level =11,
                                   Description ="All your melee weapon hit will deal an extra 1d8 radiant damage. If you use your Divine Smite, you can add an aditional 1d8 damage."
                              },
                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =13,
                                   Description ="1"
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Cleansing Touch",
                                   Level =11,
                                   Description ="You may use an action to end one spell on yourself or on one willing creature you touch. You can use this feature a number of times equal to your charisma modifier (minimum 1). To regain ses, you must finish a long rest."
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =15,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =15,
                                   Description =""
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =17,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =17,
                                   Description ="1"
                              },
                              //==18th level==========================================================//
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =19,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =20,
                                   Description =""
                              },
                         },
                         archetype = new List<string> {"Oath of Devotion", "Oath of Ancients", "Oath of Vegence","Oathbreaker" }
                    };
                    break;
               case "Ranger":
                    combatClass = new CombatClass {
                         className = "Ranger",
                         hitPoints = 10,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"Light Armor", "Medium Armor", "Shields"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapons","Martial Weapons"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"None"}
                              }},
                         savingThrows = new List<string> {"Strength","Dexterity"},
                         skillNumber = 3,
                         skillChoices = new List<string> {"Animal Handling","Athletics","Insight","Investigation","Nature","Perception","Stealth","Survival"},
                         features = new List<CombatClass.SkillGain> {
                              //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =1,
                                   Description ="0"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Favored Enemy",
                                   Level =1,
                                   Description ="Choose a favored enemy; Aberrations, beasts, celestials, constructs, dragons, elementals, fey, fiends, giants, monstrosities, oozes, plants, or undead. Alternatively, Select Two humanoid races. \n Gain advantage on wisdom (Survival) checks to track down favored enemies, as well as on Intelligence checks to recall information about them. \n Gain one language of your choice that is spoken by your favored enemy, if they speak one at all."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Natural Explorer",
                                   Level =1,
                                   Description =" You have one type of favored terrain: arctic, coast, desert, forest, grassland, mountain, swamp, or the Underdark. \n When you make an Intelligence or Wisdom check related to your favored terrain, your proficiency bonus is doubled if you are using a skill that you’re proficient in. While traveling for an hour or more in your favored terrain, you gain the following benefits: \n Difficul terrain doesn't slow your group's travel.\n your group can't become lost except by magical means. \n If engaged in another activity, you remain alert to danger. \n If you are traveling alone, you can move stealthily at normal pace. \n When you forage, you find twice as much food. \n While tracking other creatures, you also learn the exact number, size, and how long they passed."
                              },
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =2,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =2,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spellcasting",
                                   Level =2,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Fighting Style",
                                   Level =2,
                                   Description ="Choose one of the following fighting styles, Archery, Defense, Dueling, Two-Weapon Fighting."
                              },
                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =3,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =3,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =3,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Primeval Awareness",
                                   Level =3,
                                   Description ="You can use your action and expend one ranger spell slot, for 1 minute per level of the spell slot you expend, you can sense whether the following types of creatures are present within 1 mile of you (or within up to 6 miles if you are in your favored terrain). This feature doesn’t reveal the creatures’ location or number"
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =5,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =5,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =5,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Extra Attack",
                                   Level =5,
                                   Description =""
                              },
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Favored Enemy",
                                   Level =6,
                                   Description ="You have 2 favored enemies; They can be Aberrations, beasts, celestials, constructs, dragons, elementals, fey, fiends, giants, monstrosities, oozes, plants, or undead. Alternatively, Select Two humanoid races instead of one of the favored enemies. \n Gain advantage on wisdom (Survival) checks to track down favored enemies, as well as on Intelligence checks to recall information about them. \n Gain the knowledge of the language of your choice that is spoken by your favored enemy, if they speak one at all."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Natural Explorer",
                                   Level =6,
                                   Description =" You have two type of favored terrain: arctic, coast, desert, forest, grassland, mountain, swamp, or the Underdark. \n When you make an Intelligence or Wisdom check related to your favored terrain, your proficiency bonus is doubled if you are using a skill that you’re proficient in. While traveling for an hour or more in your favored terrain, you gain the following benefits: \n Difficul terrain doesn't slow your group's travel.\n your group can't become lost except by magical means. \n If engaged in another activity, you remain alert to danger. \n If you are traveling alone, you can move stealthily at normal pace. \n When you forage, you find twice as much food. \n While tracking other creatures, you also learn the exact number, size, and how long they passed."
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =7,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =7,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =7,
                                   Description =""
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Land's Stride",
                                   Level =8,
                                   Description ="Moving through nonmagical difficult terrain costs you no extra movement. You can also pass through nonmagical plants without being slowed by them and without taking damage from them if they have thorns, spines, or a similar hazard. In addition, you have advantage on saving throws against plants that are magically created or manipulated to impede movement."
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =9,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =9,
                                   Description ="2"
                              },
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Natural Explorer",
                                   Level =10,
                                   Description =" You have three type of favored terrain: arctic, coast, desert, forest, grassland, mountain, swamp, or the Underdark. \n When you make an Intelligence or Wisdom check related to your favored terrain, your proficiency bonus is doubled if you are using a skill that you’re proficient in. While traveling for an hour or more in your favored terrain, you gain the following benefits: \n Difficul terrain doesn't slow your group's travel.\n your group can't become lost except by magical means. \n If engaged in another activity, you remain alert to danger. \n If you are traveling alone, you can move stealthily at normal pace. \n When you forage, you find twice as much food. \n While tracking other creatures, you also learn the exact number, size, and how long they passed."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Hide in Plain Sight",
                                   Level =10,
                                   Description ="You spend 1 minute creating camouflage. You must have access to fresh mud, dirt, plants, soot and natrual occurring materials with which to create it. Once you are camouflaged in this way, you can try to hide by pressing yourself up against solid surface that is as tall and wide as you. You gain +10 bonus to Stealth Checks as long as you remain without moving or taking actions. If you move, you must reapply the camouflage."
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =11,
                                   Description ="7"
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =11,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =11,
                                   Description =""
                              },
                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =13,
                                   Description ="8"
                              },
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =13,
                                   Description ="1"
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Favored Enemy",
                                   Level =14,
                                   Description ="You have 3 favored enemies; They can be Aberrations, beasts, celestials, constructs, dragons, elementals, fey, fiends, giants, monstrosities, oozes, plants, or undead. Alternatively, Select Two humanoid races instead of one of the favored enemies. \n Gain advantage on wisdom (Survival) checks to track down favored enemies, as well as on Intelligence checks to recall information about them. \n Gain the knowledge of the language of your choice that is spoken by your favored enemy, if they speak one at all."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Vanish",
                                   Level =14,
                                   Description ="you can use the Hide action as a bonus action on your turn. You can’t be tracked by nonmagical means, unless you choose to leave a trail."
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =15,
                                   Description ="9"
                              },
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =15,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =15,
                                   Description =""
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =17,
                                   Description ="10"
                              },
                              new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =17,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =17,
                                   Description ="1"
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Feral Senses",
                                   Level =18,
                                   Description ="Gain preternatural senses that help you fight creatures you can’t see. When you attack a creature you can’t see, your inability to see it doesn’t im pose disadvantage on your attack rolls against it. You are aware of the location of any invisible creature within 30 feet of you, provided that the creature isn’t hidden from you and you aren’t blinded or deafened."
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =19,
                                   Description ="11"
                              },
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =19,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Foe Slayer",
                                   Level =20,
                                   Description ="Once on each of your turns, you can add your W isdom modifier to the attack roll or the damage roll of an attack you make against one of your favored enemies. You can choose to use this feature before or after the roll, but before any effects of the roll are applied."
                              },
                         },
                         archetype = new List<string> {"Hunter","Beast Master" }
                    };
                    break;
               case "Rouge":
                    combatClass = new CombatClass {
                         className = "Rouge",
                         hitPoints = 8,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"Light Armors"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapons","Hand Crossbows","Longswords","Rapiers","Shortswords"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"Thieves' Tools"}
                              }},
                         savingThrows = new List<string> {"Dexteroty","Intelligence"},
                         skillNumber = 4,
                         skillChoices = new List<string> {"Acrobatics","Athletics","Deception","Insight","Intimidation","Investifation","Perception","Performance","Persuasion","Sleight of Hand","Stealth"},
                         features = new List<CombatClass.SkillGain> {
                              //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =1,
                                   Description ="1d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Expertise",
                                   Level =1,
                                   Description ="Choose two of your skill proficiencies, or one of your skill proficiencies and your proficiency with thieves’ tools. Your proficiency bonus is doubled for any ability check you make that uses either of the chosen proficiencies"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack Skill",
                                   Level =1,
                                   Description ="Once per turn, you can deal an extra 1d6 damage to one creature you hit with an attack if you have advantage on the attack roll. The attack must use a finesse or a ranged weapon. You don’t need advantage on the attack roll if another enemy of the target is within 5 feet of it, that enemy isn’t incapacitated, and you don’t have disadvantage on the attack roll."
                              },
                              new CombatClass.SkillGain {
                                   Name ="Thieves' Cant",
                                   Level =1,
                                   Description ="A secret mix of dialect, jargon, and code that allows you to hide messages in seemingly normal conversation. Only another creature that knows thieves’ cant understands such messages. It takes four times longer to convey such a message than it does to speak the same idea plainly. You understand a set of secret signs and symbols used to convey short, simple messages, such as whether an area is dangerous or the territory of a thieves’ guild, whether loot is nearby, or people in an area are easy marks or will provide a safe house for thieves on the run."
                              },
                              //===2nd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Cunning Action",
                                   Level =2,
                                   Description ="You can take a bonus action on each of your turns in combat. This action can be used only to take the Dash, Disengage, or Hide action."
                              },
                              //===3rd level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =3,
                                   Description ="2d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =3,
                                   Description =""
                              },
                              //===4th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                              //===5th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =5,
                                   Description ="3d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Uncanny Dodge",
                                   Level =5,
                                   Description ="When an attacker that you can see hits you with an attack, you may use a reaction to halve the attack's damage against you."
                              },
                              //===6th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Expertise",
                                   Level =6,
                                   Description ="Choose four of your skill proficiencies, or three of your skill proficiencies and your proficiency with thieves’ tools. Your proficiency bonus is doubled for any ability check you make that uses either of the chosen proficiencies"
                              },
                              //===7th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =7,
                                   Description ="4d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Evasion",
                                   Level =7,
                                   Description ="You can dodge out of the way of certain area effects. When you are subjected to an effect that allows you to make a Dexterity saving throw to take only half damage, you instead take no damage if you succeed on the saving throw, and only half damage if you fail."
                              },
                              //===8th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                              //===9th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =9,
                                   Description ="5d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =9,
                                   Description =""
                              },
                              //==10th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =10,
                                   Description =""
                              },
                              //==11th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =11,
                                   Description ="6d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Reliable Talent",
                                   Level =11,
                                   Description ="Whenever you make an ability check that lets you add your proficiency bonus, you can treat a d20 roll of 9 or lower as a 10."
                              },
                              //==12th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                              //==13th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =15,
                                   Description ="5"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =15,
                                   Description ="7d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =13,
                                   Description =""
                              },
                              //==14th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Blindsense",
                                   Level =14,
                                   Description ="If you are able to hear, you are aware of the location of any hidden or invisible creature within 10 feet of you."
                              },
                              //==15th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =15,
                                   Description ="8d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Slippery Mind",
                                   Level =15,
                                   Description ="You gain proficiency in Wisdom saving throws."
                              },
                              //==16th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                              //==17th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =17,
                                   Description ="9d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =17,
                                   Description =""
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Elusive",
                                   Level =18,
                                   Description ="No attack roll has advantage against you while you aren’t incapacitated."
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Sneak Attack",
                                   Level =19,
                                   Description ="10d6"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Stroke of Luck",
                                   Level =20,
                                   Description =". If your attack m isses a target within range, you can turn the miss into a hit. If you fail an ability check, you can treat the d20 roll as a 20. Once you use this feature, you can’t use it again until you finish a short or long rest."
                              },
                         },
                         archetype = new List<string> {"Thief","Assassin", "Arcane Trickster"}
                    };
                    break;
               case "Sorcerer":
                    combatClass = new CombatClass {
                         className = "Sorcerer",
                         hitPoints = 6,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"None"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Daggers","Darts","Slings","Quarterstaffs","Light Crossbows"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"None"}
                              }},
                         savingThrows = new List<string> {"Constitution","Charisma"},
                         skillNumber = 2,
                         skillChoices = new List<string> {"Arcana","Deception","Insight","Intimidation","Persuasion","Religion" },
                         features = new List<CombatClass.SkillGain> {
                               //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =1,
                                   Description ="0"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =1,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spellcasting",
                                   Level =1,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =1,
                                   Description =""
                              },
                               //===2nd level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =2,
                                   Description ="2"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =2,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =2,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =2,
                                   Description ="2"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Font of Magic",
                                   Level =2,
                                   Description ="You now have access to your Sorcery Points. You regain points after finishing a long rest, and your max amount is equal to your level. You can sacerfice Sorcery Points for additional Spell Slots or sacerfice Spell Slots for Sorcery Points (this can be done as bonus actions). \n To Create a Spell Slot, you can sacerfice 2 points for 1st level, 3 for 2nd, 5 for 3rd, 6 for 4th, and 5th for 7th. When you convert a Spell Slot to Sorcery Points, you gain equal to the slot's level."
                              },
                               //===3rd level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =3,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =3,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =3,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =3,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Meta Magic",
                                   Level =3,
                                   Description ="Gain the ability to twist your own magic, you can choose 2 of the options, and one at 10th and 17th level: Careful Spell, Distant Spell, Empowered Spell, Extended Spell, Heightened Spell, Quickened Spell, Subtle Spell, Twinned Spell"
                              },
                               //===4th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =4,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =4,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =4,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                               //===5th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =5,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =5,
                                   Description ="6"
                              },
                               new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =5,
                                   Description ="2"
                              },
                               //===6th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =6,
                                   Description ="6"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =6,
                                   Description ="7"
                              },
                               new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =6,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =6,
                                   Description =""
                              },
                               //===7th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =7,
                                   Description ="7"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =7,
                                   Description ="8"
                              },
                               new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =7,
                                   Description ="1"
                              },
                               //===8th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =8,
                                   Description ="8"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =8,
                                   Description ="9"
                              },
                               new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =8,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                               //===9th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =9,
                                   Description ="9"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =9,
                                   Description ="10"
                              },
                               new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =9,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =9,
                                   Description ="1"
                              },
                               //==10th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =10,
                                   Description ="10"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =10,
                                   Description ="6"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =10,
                                   Description ="11"
                              },
                               new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =10,
                                   Description ="2"
                              },
                               //==11th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =11,
                                   Description ="11"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =11,
                                   Description ="12"
                              },
                               new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =11,
                                   Description ="1"
                              },
                               //==12th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =12,
                                   Description ="12"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                               //==13th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =13,
                                   Description ="13"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =13,
                                   Description ="13"
                              },
                               new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =13,
                                   Description ="1"
                              },
                               //==14th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =14,
                                   Description ="14"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =14,
                                   Description =""
                              },
                               //==15th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =15,
                                   Description ="15"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =15,
                                   Description ="14"
                              },
                               new CombatClass.SkillGain {
                                   Name ="8th Level Spell Slot",
                                   Level =15,
                                   Description ="1"
                              },
                               //==16th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =16,
                                   Description ="16"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                               //==17th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =17,
                                   Description ="17"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =17,
                                   Description ="15"
                              },
                               new CombatClass.SkillGain {
                                   Name ="9th Level Spell Slot",
                                   Level =17,
                                   Description ="1"
                              },
                               //==18th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =18,
                                   Description ="18"
                              },
                               new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =18,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =18,
                                   Description =""
                              },
                               //==19th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =19,
                                   Description ="19"
                              },
                               new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =19,
                                   Description ="2"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                               //==20th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Sorcery Points",
                                   Level =20,
                                   Description ="20"
                              },
                               new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =20,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Sorcerous Restoration",
                                   Level =20,
                                   Description ="Regain 4 sorcery points whenever you finish a short rest"
                              },
                         },
                         archetype = new List<string> {"Draconic Bloodline","Wild Magic"}
                    };
                    break;
               case "Warlock":
                    combatClass = new CombatClass {
                         className = "Warlock",
                         hitPoints = 8,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"Light Armors"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Simple Weapons"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"None"}
                              }},
                         savingThrows = new List<string> { "Wisdom","Charisma"},
                         skillNumber = 2,
                         skillChoices = new List<string> {"Arcana","Deception","History","Intimidation","Investigation","Nature","Religion" },
                         features = new List<CombatClass.SkillGain> {
                               //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spell Slots",
                                   Level =1,
                                   Description ="1"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Slot Level",
                                   Level =1,
                                   Description ="1"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =1,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Pact Magic",
                                   Level =1,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Invocations Known",
                                   Level =1,
                                   Description ="0"
                              },
                               //===2nd level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Spell Slots",
                                   Level =2,
                                   Description ="2"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Invocations Known",
                                   Level =2,
                                   Description ="2"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =2,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Eldritch Invocation",
                                   Level =2,
                                   Description ="You gain 2 eldritch Invocations of your choice. Your options are detailed at the end of the class description. When you gain certain warlock levels, you gain additional invocations of your choice, as shown in the Invocation Known COlumn on the table. When you level, you may replace an invocation with another one."
                              },
                               //===3rd level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Slot Level",
                                   Level =3,
                                   Description ="2"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =3,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Pact Boon",
                                   Level =3,
                                   Description ="With your loyal service, you may obtain a gift, Pact of CHain, Blade or Pact of Tome"
                              },
                               //===4th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =4,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =4,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                               //===5th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Slot Level",
                                   Level =5,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =5,
                                   Description ="6"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Invocations Known",
                                   Level =5,
                                   Description ="3"
                              },
                               //===6th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =6,
                                   Description ="7"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =6,
                                   Description =""
                              },
                               //===7th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Slot Level",
                                   Level =7,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Invocations Known",
                                   Level =7,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =7,
                                   Description ="8"
                              },
                               //===8th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =8,
                                   Description ="9"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                               //===9th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Slot Level",
                                   Level =9,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Invocations Known",
                                   Level =9,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =9,
                                   Description ="10"
                              },
                               //==10th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =10,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =10,
                                   Description =""
                              },
                               //==11th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Spell Slots",
                                   Level =11,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =11,
                                   Description ="11"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Mystic Arcanum",
                                   Level =11,
                                   Description ="You have a 6th level spell from the warlock spell list. You can use it once without using a spell slot. you must finish a long rest to regain."
                              },
                               //==12th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Invocations Known",
                                   Level =12,
                                   Description ="6"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                               //==13th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =13,
                                   Description ="12"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Mystic Arcanum",
                                   Level =11,
                                   Description ="You have a 6th and 7th level spell from the warlock spell list. You can use it once without using a spell slot. you must finish a long rest to regain."
                              },
                               //==14th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =1,
                                   Description =""
                              },
                               //==15th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Invocations Known",
                                   Level =15,
                                   Description ="7"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =15,
                                   Description ="13"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Mystic Arcanum",
                                   Level =15,
                                   Description ="You have a 6th,7th, and 8th level spell from the warlock spell list. You can use it once without using a spell slot. you must finish a long rest to regain."
                              },
                               //==16th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                               //==17th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spell Slots",
                                   Level =17,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =17,
                                   Description ="14"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Mystic Arcanum",
                                   Level =17,
                                   Description ="You have a 6th, 7th, 8th , and 9th level spell from the warlock spell list. You can use it once without using a spell slot. you must finish a long rest to regain."
                              },
                               //==18th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Invocations Known",
                                   Level =18,
                                   Description ="8"
                              },
                               //==19th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Spells Known",
                                   Level =19,
                                   Description ="15"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                               //==20th level==========================================================//
                             new CombatClass.SkillGain {
                                   Name ="Eldritch Master",
                                   Level =11,
                                   Description ="Spending 1 minute, you may regain all your expened spell slots from your pact magic feature. After regaining, you cannot use this feature again only til after long rest."
                              },
                         },
                         archetype = new List<string> { "The Archfey Patron","The Fiend Patron","The Great Old One Patron"}
                    };
                    break;
               case "Wizard":
                    combatClass = new CombatClass {
                         className = "Wizard",
                         hitPoints = 6,
                         itemProficiencies = new List<CombatClass.Proficiency> {
                              new CombatClass.Proficiency{
                                   Name= "Armor",
                                   List = new List<string>{"None"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Weapon",
                                   List = new List<string>{"Daggers","Darts","Slings","Quarterstaffs","Liht Crossbows"}
                              },
                              new CombatClass.Proficiency{
                                   Name= "Tools",
                                   List = new List<string>{"None"}
                              } },
                         savingThrows = new List<string> {"Intelligence","Wisdom"},
                         skillNumber = 2,
                         skillChoices = new List<string> { "Arcana","History","Insight","Investigation","Medicine","Religion"},
                         features = new List<CombatClass.SkillGain> {
                          //===1st level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =1,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =1,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spellcasting",
                                   Level =1,
                                   Description =""
                              },
                              new CombatClass.SkillGain {
                                   Name ="Arcane Recovery",
                                   Level =1,
                                   Description ="Once per day when you finish a short rest, you can choose expended spell slots to recover. The spell slots can have a combined level that is equal to or less than half your wizard's level. (rounded up) and non can be 6th level or higher."
                              },
                               //===2nd level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =2,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =2,
                                   Description =""
                              },
                               //===3rd level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="1st Level Spell Slot",
                                   Level =3,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =3,
                                   Description ="2"
                              },
                               //===4th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =4,
                                   Description ="4"
                              },
                              new CombatClass.SkillGain {
                                   Name ="2nd Level Spell Slot",
                                   Level =4,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =4,
                                   Description =""
                              },
                               //===5th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =5,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =5,
                                   Description ="2"
                              },
                               //===6th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="3rd Level Spell Slot",
                                   Level =6,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =6,
                                   Description =""
                              },
                               //===7th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =7,
                                   Description ="1"
                              },
                               //===8th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =8,
                                   Description ="2"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =8,
                                   Description =""
                              },
                               //===9th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =9,
                                   Description ="4"
                              },
                               new CombatClass.SkillGain {
                                   Name ="4th Level Spell Slot",
                                   Level =9,
                                   Description ="3"
                              },
                               new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =9,
                                   Description ="1"
                              },
                               //==10th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Cantrips Known",
                                   Level =10,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =10,
                                   Description ="2"
                              },
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =10,
                                   Description =""
                              },
                               //==11th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =11,
                                   Description ="1"
                              },
                               //==12th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =12,
                                   Description =""
                              },
                               //==13th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =13,
                                   Description ="5"
                              },
                               new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =13,
                                   Description ="1"
                              },
                               //==14th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Archetype",
                                   Level =14,
                                   Description =""
                              },
                               //==15th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="8th Level Spell Slot",
                                   Level =15,
                                   Description ="1"
                              },
                               //==16th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =16,
                                   Description =""
                              },
                               //==17th level==========================================================//
                               new CombatClass.SkillGain {
                                   Name ="Proficiency Bonus",
                                   Level =17,
                                   Description ="6"
                              },
                               new CombatClass.SkillGain {
                                   Name ="9th Level Spell Slot",
                                   Level =17,
                                   Description ="1"
                              },
                              //==18th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="5th Level Spell Slot",
                                   Level =18,
                                   Description ="3"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Spell Mastery",
                                   Level =18,
                                   Description ="Choose a 1st-level wizard spell and a 2nd-level wizard spell that are in your spellbook. You can cast those spells at their lowest level without expending a spell slot when you have them prepared. If you want to cast either spell at a higher level, you must expend a spell slot as normal. By spending 8 hours in study, you can exchange one or both of the spells you chose for different spells of the same levels."
                              },
                              //==19th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="6th Level Spell Slot",
                                   Level =19,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Ability Score Improvement",
                                   Level =19,
                                   Description =""
                              },
                              //==20th level==========================================================//
                              new CombatClass.SkillGain {
                                   Name ="7th Level Spell Slot",
                                   Level =20,
                                   Description ="2"
                              },
                              new CombatClass.SkillGain {
                                   Name ="Signature Spells",
                                   Level =20,
                                   Description ="Choose two 3rd-level wizard spells in your spellbook as your signature spells. You always have these spells prepared, they don’t count against the number of spells you have prepared, and you can cast each of them once at 3rd level without expending a spell slot. W hen you do so, you can’t do so again until you finish a short or long rest. If you want to cast either spell at a higher level, you must expend a spell slot as normal."
                              },
                         },
                         archetype = new List<string> { "School of Abjuration", "School of Conjuration", "School of Divination", "School of Echantment", "School of Evocation", "School of Illusion", "School of Necromancy", "School of Transmutation" }
                    };
                    break;
          }

     }

    public Race getRace(string race) {
        Race chosen = new Race();
        foreach (var x in Race) {
            if (x.raceName == race) {
                chosen = x;
                break;
            }
        }
        return chosen;
    }

     public SubRace getSubRace(string subrace) {
          SubRace chosen = new SubRace();
          foreach (var x in SubRace) {
               if (x.subRaceName == subrace) {
                    chosen = x;
                    break;
               }
          }
          return chosen;
     }

     public CombatClass getClass(string className){
          combatClass = new CombatClass();
          loadClass(className);
          return combatClass;
     }
}
