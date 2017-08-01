using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubRaceDescription : MonoBehaviour {
     private string hillDwarf = "\n Hill Dwarves- \n\n As a hill dwarf, you have keen senses, deep intuition, and remarkable resilience. They will come in with an aditional increase in wisdom by 1 and increase max health by and every level you gain.";
     private string mountainDwarf = "\n Mountain Dwarves- \n\n As a mountain dwarf, you're strong and hardy who is accustomed to a difficult life in rugged terrain.  You are generally taller for a dwarf then most.  You have an increase in strength by 2 and proficient in light and medium armor.";
     private string highElf = "\n High Elves- \n\n As a high elf, you have a keen mind and a mastery of at least the basics of magic. There are two kind of high elves, one group that consider themselves superior to non-elves and other eleves. The other group are more common,  friendly and often encounter towards other races. You will get an increase in Intelligence by 1, profiecent with swords and bows, know a single cantrip of your choice and an extra language.";
     private string woodElf = "\n Wood Elves- \n\n As a wood elf, you have keen senses and intuition, and your fleet feet carry you quickly and stealthily through your native forests.  They have an increase in wisdom score by 1, proficient with swords and bows, can have a base speed 35 feet and can hide in lightly obscured by foliage, rain, falling snow, mist and other natural phenomena.";
     private string drowElf = "\n Drow / Dark Elves- \n\n Descended from an earlier subrace of elves, the drow were banished from the surface world for following an evil goddess,Lolth. Now they built their civilization in the Underdark. They have a Charisma score increase by 1, have 120 feet of dark vision, Sensitive to sunlight, Know the spells dancing lights, faerie fire and darkness, and profiecent with shortswords,rapiers and crossbows.";
     private string lightFoot = "\n Light Foot Halfling- \n\n As a lightfoot, you can easily hide from notice, even using ohter people as cover. You're inclined to be affable and get along well with others.  They have an increase in Charisma score and can attempt to hide because objects and creatures one size larger than you.";
     private string stout = "\n Stout Halfling- \n\n As a stout halfling, you're hardier than average and have resistance to posion. They have an increase of constitution score by 1 and have an advantage against poison and resistant to poison damage.";
     private string forestGnome = "\n Forest Gnome- \n\n Forest Gnomes have a natrual knack for illusions and inherent quickness and stealth.  In the world of D&D, forest gnomes are secretive and rare. They gather in hidden communities in their forests, using their illusions and trickery to conceal themselves from threats or to mask their espace if detected. They are good-spirited woodland folks and friendly to other woodland folks. They have an increase of Dexterity by 1, know minor illusions and can speak with small animals";
     private string rockGnome = "\n Rock Gnome - \n\n Rock Gnomes have a natural inventiveness and hardiness beyond that of other gnomes. Most gnomes are commonly rock gnomes. They have an increase in constitution score by 1, proficent in any checks relating with magical items, alchemical objects or technological devices. They are also able to produce Tinkers objects such as Clockwork Toy, Firestarter and a MusicBox.";
     private string dragon = "";
     public string chosen = "";

     public void hillChoice() {
          this.GetComponent<Text>().text = hillDwarf;
          chosen = "Hill Dwarf";
     }

     public void mountainChoice() {
          this.GetComponent<Text>().text = mountainDwarf;
          chosen = "Mountain Dwarf";
     }

     public void highChoice() {
          this.GetComponent<Text>().text = highElf;
          chosen = "High Elf";
     }

     public void woodChoice() {
          this.GetComponent<Text>().text = woodElf;
          chosen = "Wood Elf";
     }

     public void drowChoice() {
          this.GetComponent<Text>().text = drowElf;
          chosen = "Drow";
     }

     public void lightfootChoice() {
          this.GetComponent<Text>().text = lightFoot;
          chosen = "Lightfoot";
     }

     public void stoutChoice() {
          this.GetComponent<Text>().text = stout;
          chosen = "Stout";
     }

     public void forestChoice() {
          this.GetComponent<Text>().text = forestGnome;
          chosen = "Forest Gnome";
     }

     public void rockChoice() {
          this.GetComponent<Text>().text = rockGnome;
          chosen = "Rock Gnome";
     }

     public void dragonChoice(Text word) {
          string choice = "\n "+ word.GetComponent<Text>().text + " - \n\n";
          string current = word.GetComponent<Text>().text;
          choice += "Dragon born are generally good but it isn't uncommon that Chromatic colored and metalic colored Dragonborn follow traits of actual same colored dragons when it comes to their alignment. (generally colored are evil while metalic are good) ";
          choice += "as a " + current + "born you are able to harness your breath to deal"; 
          switch (current) {
               case "Black Dragon":
                    choice += " Acid Damage in a 5 by 30 ft line where the enemy must overcome a Dex Save else. They also gain resistance to Acid Damage";
                    break;
               case "Blue Dragon":
                    choice += " Lightning Damage in a 5 by 30 ft line where the enemy must overcome a Dex Save else. They also gain resistance to Lightning Damage";
                    break;
               case "Brass Dragon":
                    choice += " Fire Damage in a 5 by 30 ft line where the enemy must overcome a Dex Save else. They also gain resistance to Fire Damage";
                    break;
               case "Bronze Dragon":
                    choice += " Lightning Damage in a 5 by 30 ft line where the enemy must overcome a Dex Save else. They also gain resistance to Lightning Damage";
                    break;
               case "Copper Dragon":
                    choice += " Acid Damage in a 5 by 30 ft line where the enemy must overcome a Dex Save else. They also gain resistance to Acid Damage";
                    break;
               case "Gold Dragon":
                    choice += " Fire Damage in a 15 ft cone where the enemy must overcome a Dex Save else. They also gain resistance to Fire Damage";
                    break;
               case "Green Dragon":
                    choice += " Poison Damage in a 15 ft cone where the enemy must overcome a Con Save else. They also gain resistance to Poison Damage";
                    break;
               case "Red Dragon":
                    choice += " Fire Damage in a 15 ft cone where the enemy must overcome a Dex Save else. They also gain resistance to Fire Damage";
                    break;
               case "Silver Dragon":
                    choice += " Cold Damage in a 15 ft cone where the enemy must overcome a Con Save else. They also gain resistance to Cold Damage";
                    break;
               case "White Dragon":
                    choice += " Cold Damage in a 15 ft cone where the enemy must overcome a Con Save else. They also gain resistance to Cold Damage";
                    break;
          }
          chosen = current;
          this.GetComponent<Text>().text = dragon+ choice;
     }
}
