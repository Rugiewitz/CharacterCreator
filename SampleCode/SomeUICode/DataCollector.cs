using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class DataCollector : MonoBehaviour {
    public CharacterTemplate Save = new CharacterTemplate();
    //so they don't keep on adding blacks, it'll overwrite the chosen one if they go back
    private string skill;
    private string skill2;
    private CharacterTemplate.Proficiency item;
     private List<string> languageKnown = new List<string> { "Choose Language", "Abyssal", "Aquan", "Auran","Celestial","Deep Speech","Draconic","Dwarvish","Elvish","Giant","Gnomish","Goblin","Gnoll","Halfling","Ignan","Infernal","Orc","Primordial","Sylvan","Terran","Undercommon"};
     private List<string> skillsKnown = new List<string> { "Choose Skill","Acrobatic","Animal Handling","Arcana","Athletics","Deception","History","Insight","Intimidation","Investigation","Medicine","Nature","Perception","Performance","Persuasion","Religion","Sleight of Hand","Stealth","Survival"};
    public GameObject Langbox;
    public GameObject itembox;
    public GameObject skillbox;
    public GameObject skillbox2;
    public GameObject characterNameBox;
    public GameObject levelBox;
    public GameObject alignmentBox;
    public GameObject ageBox;
    public GameObject weightBox;
    public GameObject heightBox;
    public GameObject eyeBox;
    public GameObject skinBox;
    public GameObject hairBox;


    private string language;

     void Start() {
          Langbox.GetComponent<Dropdown>().options.Clear();
          skillbox.GetComponent<Dropdown>().options.Clear();
          skillbox2.GetComponent<Dropdown>().options.Clear();

          foreach (var x in skillsKnown) {
               skillbox.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData() { text = x });
               skillbox2.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData() { text = x });
          }

     }

     public void updateLanguage(bool caseBol) {
          foreach(var x in languageKnown) {
               if (!(x == "Elvish" && caseBol == true))
                    Langbox.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData() { text = x });
          }
     }

 
    public void refresh() {
        characterNameBox.GetComponent<InputField>().text = "";
        levelBox.GetComponent<InputField>().text = "";
        alignmentBox.GetComponent<Dropdown>().value = 0;
        ageBox.GetComponent<InputField>().text = "";
        weightBox.GetComponent<InputField>().text = "";
        heightBox.GetComponent<InputField>().text = "";
        eyeBox.GetComponent<InputField>().text = "";
        skinBox.GetComponent<InputField>().text = "";
        hairBox.GetComponent<InputField>().text = "";
        Langbox.GetComponent<Dropdown>().value = 0;
        itembox.GetComponent<Dropdown>().value = 0;
        skillbox.GetComponent<Dropdown>().value = 0;
        skillbox2.GetComponent<Dropdown>().value = 0;

        Langbox.SetActive(false);
        itembox.SetActive(false);
        skillbox.SetActive(false);
        skillbox2.SetActive(false);

        Save = new CharacterTemplate();
        language = "";
          skill = "";
          skill2 = "";
          item = new CharacterTemplate.Proficiency();

    }

    public void characterName(InputField x) {
        Save.characterName = x.text;
    }
    public void level(InputField x) {
        Save.level = x.text;
    }
    public void alignment(Dropdown x) {
        Save.Alignment = x.options[x.value].text;
    }
    public void age(InputField x) {
        Save.age = x.text;
    }
    public void weight(InputField x) {
        Save.weight = x.text;
    }
    public void height(InputField x) {
        Save.height = x.text;
    }
    public void eye(InputField x) {
        Save.eye = x.text;
    }
    public void skin(InputField x) {
        Save.skin = x.text;
    }
    public void hair(InputField x) {
        Save.hair = x.text;
    }
    public void languages(Dropdown x) {
        language = x.options[x.value].text;
    }


     public void skillChange(Dropdown x) {
          skillbox2.GetComponent<Dropdown>().options.Clear();
          foreach (var y in skillsKnown) {
               if(x.options[x.value].text != y)
                    skillbox2.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData() { text = y });
          }
     }

     public void skillChange2(Dropdown x) {
          skillbox.GetComponent<Dropdown>().options.Clear();
          foreach (var y in skillsKnown) {
               if (x.options[x.value].text != y)
                    skillbox.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData() { text = y });
          }
     }



     public void skills(Dropdown x) {
          skill = x.options[x.value].text;
          skillChange(x);
    }
    public void skills2(Dropdown x) {
        skill2 =  x.options[x.value].text ;
          skillChange2(x);
     }
    public void ItemProf(Dropdown x) {
        item = new CharacterTemplate.Proficiency() { Name = "Tool Proficiency", List = new List<string>() { x.options[x.value].text } };
    }

    public void ShowLang(bool x) {
        if (x == true) {
            Langbox.SetActive(true);
        }
    }
    public void ShowItem(bool x) {
        if (x == true) {
            itembox.SetActive(true);
        }
    }
    public void showSkill1(bool x) {
        if (x == true) {
            skillbox.SetActive(true);
        }
    }
    public void showSkill2(bool x) {
        if (x == true) {
            skillbox2.SetActive(true);
        }
    }




     public void SaveRace(Race chosenRace, SubRace chosenSubRace) {//fix save data properly
        Save.raceName = chosenRace.raceName;
          /*Save.size = chosenRace.size;
          Save.speed = chosenRace.speed;
          if (chosenRace.feature.Count != 0) {
              foreach (var x in chosenRace.feature) {
                  Save.feature.Add(new CharacterTemplate.Speicals() { Name = x.Name, Description = x.Description });
              }
          }
          if (chosenRace.advantageRolls.Count != 0) {
              foreach (var x in chosenRace.advantageRolls) {
                  Save.advantageRolls.Add(x);
              }
          }
          if (chosenRace.resistance.Count != 0) {
              foreach (var x in chosenRace.resistance) {
                  Save.resistance.Add(x);
              }
          }
          if (chosenRace.itemProficiencies.Count != 0) {
              foreach (var x in chosenRace.itemProficiencies) {
                  if (x.Name != "Any") {
                      Save.itemProficiencies.Add(new CharacterTemplate.Proficiency() { Name = x.Name, List = x.List });
                  }
              }
          }
          if (chosenRace.skillProficiencies.Count != 0) {
              foreach (var x in chosenRace.skillProficiencies) {
                  if (x.Name != "Any") {
                      Save.skillProficiencies.Add(new CharacterTemplate.Speicals() { Name = x.Name, Description = x.Description });
                  }
              }

          }
          foreach (var x in chosenRace.languages) {
              if (x != "Any") {
                  Save.languages.Add(x);
              }
          }

          if (chosenRace.feat.Count != 0) {
              foreach (var x in chosenRace.feat) {
                  if (x.Name != "Any") {
                      Save.feat.Add(new CharacterTemplate.Speicals() { Name = x.Name, Description = x.Description });
                  }
              }

          }
          */

          Save.skillsknown = new List<string>();
          if (skill != "") {
               Save.skillsknown.Add(skill);
          }
          if(skill2 != "") {
               Save.skillsknown.Add(skill2);
          }
          if(chosenRace.raceName == "Elf") {
               Save.skillsknown.Add("Perception");
          }
          if (chosenRace.raceName == "Half Orc") {
               Save.skillsknown.Add("Intimidation");
          }

     }

     public bool checkInputs() {
          if(characterNameBox.GetComponent<InputField>().text == "") {
               return false;
          }
          if(levelBox.GetComponent<InputField>().text == "" ) {
               return false;
          }
          if(alignmentBox.GetComponent<Dropdown>().value == 0) {
               return false;
          }
          if(ageBox.GetComponent<InputField>().text == "") {
               return false;
          }
          if(weightBox.GetComponent<InputField>().text == "") {
               return false;
          }
          if (heightBox.GetComponent<InputField>().text == "") {
               return false;
          }
          if (eyeBox.GetComponent<InputField>().text == "") {
               return false;
          }
          if (skinBox.GetComponent<InputField>().text == "") {
               return false;
          }
          if (hairBox.GetComponent<InputField>().text == "") {
               return false;
          }

          if (Langbox.GetComponent<Dropdown>().value == 0 && Langbox.activeSelf == true) {
               return false;
          }
          if (itembox.GetComponent<Dropdown>().value == 0 && itembox.activeSelf == true) {
               return false;
          }
          if (skillbox.GetComponent<Dropdown>().value == 0 && skillbox.activeSelf == true) {
               return false;
          }
          if (skillbox2.GetComponent<Dropdown>().value == 0 && skillbox2.activeSelf==true) {
               return false;
          }
          return true;
     }
}