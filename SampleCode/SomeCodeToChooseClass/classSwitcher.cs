using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class classSwitcher : MonoBehaviour {
     public string choice;
     public GameObject describe;
     public Sprite[] picture;
     
	void Start () {
          choice = "Barbarian";
          this.GetComponent<Image>().sprite = Array.Find(picture, element => element.name == choice);
          classDescription(choice);
     }
	
	public void change(Text text) {
          this.GetComponent<Image>().sprite = Array.Find(picture, element => element.name == text.text);
          choice = text.text;
          classDescription(choice);
     }
     private void classDescription(string name) {
          var classText = describe.GetComponent<Text>();
          switch (name) {
               case "Barbarian":
                    classText.text = choice+ "- \nWarriors that can use their rage to give them advantage in battles. They are able to have a chance to hit the hardest and have the highest health compared to any other character. Which means they are profiecnt with Strength and Constitution \n\n At the 3rd level, they can choose 2 different paths to follow.\n Path of the Berserker which is all about using your fury and rage to turn the tides of battle.\n Path of the Totem Warrior, one who chooses a spirit animal (Bear, Eagle or Wolf) for strength, protection and guidance.";
                    break;

               case "Bard":
                    classText.text = choice + "- \n Unlike normal magic users, bards use their magic through words and music to inspire allies, demoralize foes, minipulate minds, create illusions and even heal. They are proficient in Dexterity and Charisma \n\n At the 3rd level, they are able to choose a 'Bard College' that they attended to to delve into more advanced techniques. \n The College of Lore, with the wide selection of books avilable, you are able to get more skills and improve your knowledge of spells. \n College of Valor, it trains the bards to become hero's of the stories, making them more combat oriented.";
                    break;

               case "Cleric":
                    classText.text = choice + "- \n A mix of a magic user and combat user. They are great healers in time of need and possibly able to call forth divine magic from their gods. They are proficient when it comes to Wisdom and Charisma \n\n At level 1, you are able to pick a 'Divine Domain' relating towards your diety. The choices can be Knowledge, Life, Light, Nature, Tempest, Trickery, War or Death.";
                    break;

               case "Druid":
                    classText.text = choice + "- \n They are very dedicated when it comes to nature and the balance of life. They entune to nature to be able to perform nature related spells and even transform into animals. They are proficient in Intelligence and Wisdom \n\n At the 2nd level, the druid is able to choose a circle of Land or Moon, If they choose land, then they can choose Arctic, Coast, Desert, Forest, Grassland, Mountain, Swamp or Underdark druids.";
                    break;

               case "Fighter":
                    classText.text = choice + "- \n All skills are dedicated to combat, able to wear any type of armor and bare any sheild. They are proficient in Strength Constitution. \n\n At the first level, they are able to choose one of the 3 Martial Arhetypes, Champion, Battle Master and Eldritch Knight. Champions focus on raw physical power and precision to deal devastating blows in battle. A Battle Master dedicate knowledge of armor, weapons, and maneuvers while in combat to give them an edge. Eldritch Knights use magic to help aid them in battle which gives and edge in arcane power and knowledge.";
                    break;

               case "Monk":
                    classText.text = choice + "- \n Knowledge of quick weapons, precision, the magic of KI, and following a religious path, They are one of the fastest and deadliest warriors but generally the most peaceful. They are Proficient in Strength and Dexterity. \n\n At level 3 the monk is able to follow a 'Tradition', Way of Open Hand, Shadow or Four Elements. Open Hand will make you master of combat and use ki to minipulate your body regeneration and defenses. Way of Shadow will help you with stealth and subterfuge. Way of the four Elements will use the your ki to harness the power of elements as an extension of your body.";
                    break;

               case "Paladin":
                    classText.text =  choice + "- \n Similar to clerics, only that they focus more with combat then spells. They are able to user all armor and sheilds like fighters and must have a god they believe in. They are proficient in Wisdom and Charisma. \n\n At level 3 you can make a Sacred Oath, Devotion, Ancients, Vegence or Oath breaker. Each one gives you a unquie tenent to follow and breaking them gives the possability in losing your paladin abilities based on the oath. Oath of Devotion binds themselves to the loftiest ideals of justice, virtue and order. Oath of Ancients is more of the protection of people and nature. Oath of Vegeance is to punish those who committed sin. OathBreakers are generally evil but are labaled those that were unable to follow their oaths.  ";
                    break;

               case "Ranger":
                    classText.text = choice + "- \n Consider to be the warriors of the wilderness, they are consider to be expert hunters, trackers and survivalist of the wilderness.They are Proficient in Strength and Dexterity. \n\n At level 1, they are able to a artchetypes, Hunter or Beast Master. As a Hunter you learn skills to specialized in fighting and hunting the most dangerious threats such as colossual beings, giant beings or hordes. As a Beast master, you call forth a beast to help you on your adventures , train it to assist you and others in battle.";
                    break;

               case "Rouge":
                    classText.text = choice + "- \n Lurking in the shadows, making shady deals, you're able to use simple weapons, sneak attack enemies, and perform illegal actions in towns and farms. You're proficient in Dexterity and Intelligence. \n\n You have 3 Archetypes to choose from at level 3, Theif, Assasin or Arcane Trickster. Now that you're a Thief, you are now a bit better performing those illegal activities now. Assassins are experts in infiltration and murdering their targets. Arcane Strickers have the ability to fuse their natrual stealth and agility with new tricks and illusions from their magical spells.";
                    break;

               case "Sorcerer":
                    classText.text = choice + "- \n You are a spellcaster like a wizard but what makes your magical abilities unquie is that you obtain your powers through your bloodline. Your proficient in Constitution and Charisma. \n\n  Sorcerous have 2 possible orgins, Draconic Bloodline and Wild. Draconic Bloodline means your magic comes from a draconic being once mingled with your blood or that of your ancestors, you are able to choose the type of dragon that  has affected you. Wild Magic is really a mystery, your magic comes from raw chaotic magic that could have been caused by almost anything. ";
                    break;

               case "Warlock":
                    classText.text = choice + "- \n A Sorcerer is born with magic, Wizards learn their magic, Clerics gain some magic from a divine being, but a Warlock? They made a pact with a very powerful being to bestow a powerful magical being. They are proficient in Wisdom and Charisma. \n\n At level 1, you are able to strike a deal with a Patron, Archfey, Fiend or Great Old One. Archfey is a bing of so old that they are now legends, their magic and secrets have existed before the mortal race were ever born. The Fiend, from the lower planes of existance, you encountered a fiend/demonic being of pure evil and struct a deal with them. The Great Old One is a mysterious entity that are far out of your realm, space, and reality or even an 'Elder God' from legends.";
                    break;

               case "Wizard":
                    classText.text =  choice + "- \n Practicing the arts of magic, learning your spells from a school or a mentor ,collecting your spells in a book, you are a classical wizard from legends. You are proficient in Intelligence and Wisdom \n\n At 2nd level, you can choose an arcane tradition from one of the eight possible schools that speclized in: Abjuration(portection), Conjuration(summoning), Divination, Enchantment, Evocation(elemental effects), Illusion, Necromancy(raising the dead) or Transmutation(modify energy and matter) ";
                    break;

               default:
                    classText.text = "N/A BUG";
                    break;

          }
     }
}
