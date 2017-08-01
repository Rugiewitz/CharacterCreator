using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class archetypeSwitcher : MonoBehaviour {

     public string choice = "";
     public GameObject describe;

     public void classDescription(string name) {

     }

     public void choiceClick(GameObject x) {

     }
     public string changeText(string x) {
          string y="";
          switch (x) {
               case "Barbarian":
                    y = "Pick a Primal Path";
                    break;
               case "Bard":
                    y = "Pick a Bard College";
                    break;
               case "Cleric":
                    y = "Pick a Divine Domain";
                    break;
               case "Druid":
                    y = "Pick a Druid Circle";
                    break;
               case "Fighter":
                    y = "Pick a Martial Archetype";
                    break;
               case "Monk":
                    y = "Pick a Monastic Tradition";
                    break;
               case "Paladin":
                    y = "Pick a Sacred Oath";
                    break;
               case "Ranger":
                    y = "Pick a Ranger Archetype";
                    break;
               case "Rouge":
                    y = "Pick a Roguish Archetype";
                    break;
               case "Sorcerer":
                    y = "Pick a Sorcerous Orgins";
                    break;
               case "Warlock":
                    y = "Pick a Otherworldly Pact";
                    break;
               case "Wizard":
                    y = "Pick a Arcane Tradition";
                    break;
          }
          return y;
     }

     public Boolean checkLevel(string classCombat, int level) {
          if ((classCombat == "Druid" || classCombat == "Wizard") && level >= 2)
               return true;
          else if((classCombat == "Warlock"|| classCombat == "Cleric"|| classCombat == "Sorcerer")) {
               return true;
          }
          else if(level >= 3) {
               return true;
          }
          return false;
     }
}
