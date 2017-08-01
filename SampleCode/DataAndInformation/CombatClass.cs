using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatClass : MonoBehaviour {

     public class Speicals {
          public string Name { get; set; }
          public string Description { get; set; }
     }

     public class Proficiency {
          public string Name { get; set; }
          public List<string> List { get; set; }
     }

     public class SkillGain {
          public string Name { get; set; }
          public int Level { get; set; }
          public string Description { get; set; }
     }

     public string className { get; set; }
     public int hitPoints { get; set; }
     public List<Proficiency> itemProficiencies { get; set; }
     public List<string> savingThrows { get; set; }
     public int skillNumber { get; set; }
     public List<string> skillChoices { get; set; }
     public List<SkillGain> features { get; set; }
     public List<string> archetype { get; set; }
}
