using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class RacialBonus : MonoBehaviour {
    public GameObject dataCollector;
     public bool highElf = false;

    public void LoadRacial(Race race) {
        dataCollector.GetComponent<DataCollector>().refresh();

        string raceText = "";
        string StatBonus = "StatBonus: \n";
        string size = "Size: " + race.size + "\n";
        string Speed = "Speed: "+race.speed+"ft\n";
        string FeatureBonus = "Features: \n";
        string AdvantageRolls = "Advantage Rolls Against: \n";
        string resistance = "Resistance :\n";
        string itemProficiencies = "Proficient with :\n";
        string skillProficiencies = "Skills Proficient: \n";
        string languages = "Languages Known: \n";
        string possibleSubRaces = "SubRace to Choose: \n";
        string spellKnown = "Spells Possible to Learn: \n";

        var statName = race.abilityScoreName.GetEnumerator();
        var statIncrease = race.abilityScoreIncrease.GetEnumerator();
        bool Dwarf = false;
        bool Human = false;
        bool HalfElf = false;
        int skillIncreaseCounter = 0;
        int languageIncreaseCounter = 0;

        if (race.raceName == "Dwarf") {
            Dwarf = true;
        }
        if(race.raceName == "Human"){
            Human = true;
        }
        if (race.raceName == "Half Elf"){
            HalfElf = true;
        }

        //============================================================================
        while (statName.MoveNext() && statIncrease.MoveNext()) {
            if (statName.Current!="Any") {
                StatBonus = StatBonus + statName.Current + " : +" + statIncrease.Current;
            }
        }
        if(race.raceName=="Half Elf") {
            StatBonus += "\n You will recieve two +1 to add to any stat Later.";
        }
        StatBonus += "\n";
        //============================================================================
        if (race.feature.Count!=0) {
            foreach (var x in race.feature) {
                FeatureBonus = FeatureBonus + x.Name + " - " + x.Description + "\n";
            }
        }else {
            FeatureBonus = "";
        }
        //============================================================================

        if (race.advantageRolls.Count != 0) {
            foreach (var x in race.advantageRolls) {
                AdvantageRolls = AdvantageRolls + x + " , ";
            }
            AdvantageRolls += "\n";
        }else {
            AdvantageRolls = "";
        }

        //============================================================================
        if (race.resistance.Count != 0) {
            foreach (var x in race.resistance) {
                resistance += x + " , ";
            }
            resistance += "\n";
        }else {
            resistance = "";
        }
        //============================================================================
        if (race.itemProficiencies.Count!=0) {
            foreach (var x in race.itemProficiencies) {
                if (x.Name.Substring(0) != "Any") {
                    itemProficiencies += x.Name + " : ";
                    foreach (var y in x.List) {
                        itemProficiencies += y + " , ";
                    }
                    itemProficiencies += "\n";
                }
            }
        }else {
            itemProficiencies = "";
        }
        //============================================================================
        if (race.skillProficiencies.Count!=0) {
            foreach (var x in race.skillProficiencies) {
                if (x.Name != "Any") {
                    skillProficiencies = skillProficiencies + x.Name + " : " + x.Description + " , ";
                }
                else {
                    skillIncreaseCounter++;
                }
            }
            skillProficiencies += "\n";
        }else {
            skillProficiencies = "";
        }
        if (race.raceName=="Human"|| race.raceName == "Half Elf") {
            skillProficiencies = "";
        }


        //============================================================================

        foreach (var x in race.languages) {
            if (x !="Any") {
                languages += x + " , ";
            }else {
                languageIncreaseCounter++;
            }
        }
        languages += "\n";
        ///============================================================================
        if (race.subRaces.Count!=0) {
            foreach (var x in race.subRaces) {
                possibleSubRaces += x + " , ";
            }
            possibleSubRaces += "\n";
        }else {
            possibleSubRaces ="";
        }

        ///============================================================================
        if (race.spellsKnown.Count!=0) {
            foreach (var x in race.spellsKnown) {
                spellKnown += x + " , ";
            }
            spellKnown += "\n";
        }else{
            spellKnown = "";
        }
        raceText += StatBonus + size + Speed + FeatureBonus + AdvantageRolls + resistance + itemProficiencies + skillProficiencies + languages + possibleSubRaces + spellKnown;
        this.GetComponent<Text>().text = raceText;
        dataCollector.GetComponent<DataCollector>().ShowItem(Dwarf);
          showBoxes(race.raceName);


          if (HalfElf || Human) {
            dataCollector.GetComponent<DataCollector>().ShowLang(true);
            dataCollector.GetComponent<DataCollector>().showSkill1(true);
        }
        dataCollector.GetComponent<DataCollector>().showSkill2(HalfElf);

    }
    
     public void showBoxes(string name) {
          Debug.Log(name);
          if (name == "Dwarf") {
               dataCollector.GetComponent<DataCollector>().ShowItem(true);
          }
          if (name == "Half Elf" || name == "Human") {
               dataCollector.GetComponent<DataCollector>().ShowLang(true);
               dataCollector.GetComponent<DataCollector>().showSkill1(true);
          }else {
               dataCollector.GetComponent<DataCollector>().ShowLang(false);
               dataCollector.GetComponent<DataCollector>().showSkill1(false);
          }
          if (name == "Half Elf") {
               dataCollector.GetComponent<DataCollector>().showSkill2(true);
          }else {
               dataCollector.GetComponent<DataCollector>().showSkill2(false);
          }
          if (highElf && name == "Elf") {
               dataCollector.GetComponent<DataCollector>().ShowLang(true);
          }
     }

}
