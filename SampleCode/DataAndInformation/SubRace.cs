using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SubRace {
     public class Speicals
     {
          public string Name { get; set; }
          public string Description { get; set; }
     }

     public class Proficiency
     {
          public string Name { get; set; }
          public List<string> List { get; set; }
     }

     public string subRaceName { get; set; }
     public List<string> abilityScoreName { get; set; }
     public List<int> abilityScoreIncrease { get; set; }
     public int speed { get; set; }
     public List<Speicals> feature { get; set; }
     public List<string> advantageRolls { get; set; }
     public List<string> resistance { get; set; }
     public List<Proficiency> itemProficiencies { get; set; }
     public List<Speicals> skillProficiencies { get; set; }
     public List<string> languages { get; set; }
     public List<Speicals> feat { get; set; }
     public List<string> spellsKnown { get; set; }
     public List<string> functionCall { get; set; }
}
