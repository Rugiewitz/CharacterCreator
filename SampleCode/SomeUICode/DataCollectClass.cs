using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DataCollectClass : MonoBehaviour {
     public GameObject skills;
     public GameObject skills2;
     public GameObject skills3;
     public GameObject skills4;
     private List<string> skillKnown;
     private List<string> skillListExclude = new List<string>();
     private string[] chosen = new string[3];

     public void refresh() {

     }

     public void refreshAll() {
          skills.GetComponent<Dropdown>().options.Clear();
          skills2.GetComponent<Dropdown>().options.Clear();
          skills3.GetComponent<Dropdown>().options.Clear();
          skills4.GetComponent<Dropdown>().options.Clear();
          chosen = new string[3];
     }


     public void setSkillBox(int choices) {
          chosen[0] = skillKnown[0];
          chosen[1] = skillKnown[1];
          skillListExclude.Add(skillKnown[0]);
          skillListExclude.Add(skillKnown[1]);
          if (choices >= 3) {
               chosen[2] = skillKnown[2];
               skillListExclude.Add(skillKnown[3]);
          }
          if (choices == 4) {
               chosen[3] = skillKnown[3];
               skillListExclude.Add(skillKnown[4]);
          }
          skills.GetComponent<Dropdown>().AddOptions(skillKnown.Except(skillListExclude.Except(new List<string> { chosen[0] }).ToList()).ToList());
          skills2.GetComponent<Dropdown>().AddOptions(skillKnown.Except(skillListExclude.Except(new List<string> { chosen[1] }).ToList()).ToList());

          if (choices >= 3) {
               skills3.SetActive(true);
               skills3.GetComponent<Dropdown>().AddOptions(skillKnown.Except(skillListExclude.Except(new List<string> { chosen[2] }).ToList()).ToList());
          }
          else {
               skills3.SetActive(false);
          }
          if (choices == 4) {
               skills4.SetActive(true);
               skills4.GetComponent<Dropdown>().AddOptions(skillKnown.Except(skillListExclude.Except(new List<string> { chosen[3] }).ToList()).ToList());
          }
          else {
               skills4.SetActive(false);
          }
     }

     public void onChangeSkillBox(Dropdown y) {
          int x = 0;
          changeSkillBox(x,y);
     }
     public void onChangeSkillBox1(Dropdown y) {
          int x = 1;
          changeSkillBox(x,y);
     }
     public void onChangeSkillBox2(Dropdown y) {
          int x = 2;
          changeSkillBox(x,y);
     }
     public void onChangeSkillBox3(Dropdown y) {
          int x = 3;
          changeSkillBox(x,y);
     }
     public void changeSkillBox(int x, Dropdown y) {
          int choices = skillListExclude.Count();
          skillListExclude.Remove(chosen[x]);
          skillListExclude.Add(y.options[y.value].text);
          chosen[x] = y.options[y.value].text;

          if (x != 0) {
               skills.GetComponent<Dropdown>().ClearOptions();
               skills.GetComponent<Dropdown>().AddOptions(skillKnown.Except(skillListExclude.Except(new List<string> { chosen[0] }).ToList()).ToList());
          }
          if (x != 1) {
               skills2.GetComponent<Dropdown>().ClearOptions();
               skills2.GetComponent<Dropdown>().AddOptions(skillKnown.Except(skillListExclude.Except(new List<string> { chosen[1] }).ToList()).ToList());
          }
          if(x != 3 && choices >= 3) {
               skills3.GetComponent<Dropdown>().ClearOptions();
               skills3.GetComponent<Dropdown>().AddOptions(skillKnown.Except(skillListExclude.Except(new List<string> { chosen[2] }).ToList()).ToList());
          }
          if (x != 4 && choices == 4) {
               skills4.GetComponent<Dropdown>().ClearOptions();
               skills4.GetComponent<Dropdown>().AddOptions(skillKnown.Except(skillListExclude.Except(new List<string> { chosen[3] }).ToList()).ToList());
          }
     }

     


     public void setUpClass(CombatClass classChosen, int level , List<string> skillsAlreadyKnown) {
          refreshAll();
          int choices = classChosen.skillNumber;
          if (skillsAlreadyKnown.Count != 0) {
               skillListExclude.AddRange(skillsAlreadyKnown);
               skillKnown = (classChosen.skillChoices).Except(skillListExclude).ToList();
          }
          else {
               skillKnown = classChosen.skillChoices;
          }
          switch (classChosen.className) {
               case "Barbarian":
                    break;
               case "Bard":
                    break;
               case "Cleric":
                    break;
               case "Druid":
                    break;
               case "Fighter":
                    break;
               case "Monk":
                    break;
               case "Paladin":
                    break;
               case "Ranger":
                    break;
               case "Rouge":
                    break;
               case "Sorcerer":
                    break;
               case "Warlock":
                    break;
               case "Wizard":
                    break;
          }
          setSkillBox(choices);
     }
}
