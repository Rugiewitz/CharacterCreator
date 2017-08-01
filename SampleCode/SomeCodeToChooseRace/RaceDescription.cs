using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RaceDescription : MonoBehaviour {
    private string dwarf = " \n Dwarves- \n\n Known as skilled warriors, miners and workers of stone and metal. Though they stand under 5 feet tall , dwarves are so broad and compact that they can weight as much as a human standing nearly two feet taller.  Their courage and endurance are easily a match for any of the larger folks. \n\n They mature at the same rate as humans but consider young until 50 and live up to anaverage of 350 years. They have darkvision, resistance to posion and  knowledge of orgins of stonework.  ";
    private string elf = "\n Elves- \n\n  Magical people of otherworldy grace, living in the world but entirely part of it. They love nature, magic , art, music, poetry and the good things of the world. With their unearthly grace and fine feature, elves appear hauntingly beautiful  to humans and members of other races.  They are slightly shorter then humans on average and height is between 5 to alittle over 6 feet tall.They are more selnder, weighting around 100 to 145 pounds \n\n They mature at the age of 100 and can live up to 750 years old. They have dark vision, proficiency in perception, can't be put to sleep by magic and only require to meditate instead of sleeping. ";
    private string halfling = "\n Halflings- \n\n living in the comforts of home or to settle in a peaceful and quiet area, far from monsters and armings are usually the goals of most halflings. Halflings are affable and cheerful people, cherishing the bonds of family and friendship with an adventurous spirit and a strong sense of curiosity. They are very small humanoid beings only standing 3 feet tall and weighting between 40 to 50 pounds. \n\n  They reach adulthood at 20 and generally lives into the middle of his or her second century. They have less movement speed but are very nimble, able to be brave against frightening situations and able to pull some luck when attacking against enemies";
    private string human = "\n Humans - \n\n The youngest of the common races and very short-lived in comparison to dwarves, elves and other races. Because of their short lives, they strive harder to achieve as much as they can with hte years given. They are the most physically diverse than other races. Their average height is from 5 feet to alittle over 6 feet and weighting betwen 125 to 250 pounds. \n\n Humans reach adult hood in their late teens and live for on average to a century. They have no racial bonuses but are able to pick skills and feats that they're profiecent with instead of natrually assigned.";
    private string dragonborn = "\n Dragonborns - \n\n They walk proudly through a world that greets them with fearful incomprehension. Said to be shaped by draconic godsor dragons themselves, they are the only race to be hatched from dragon eggs.They have no clear calling inlife, usually are faithful servants to true dragons or ranks of soldiers in battle. They are strong built, standing over 6 feet tall and weighting 250 pounds with talon like hands and scales through out their body. They have no wings or tails. \n\n They reach adult hood at 15 and live up to 80. They are strong creatures of multiple color representing an element or metal. Depending on the dragons color, they are able to breath an elemental breath of flame.";
    private string gnome = "\n Gnomes - \n\n They enjoy all delights of life, with all moments of invention, exploration, investigation , creation and play. Their body shines with energy and enthusiasm, and are seen as prankseters by some. They have a height over 3 feet and weighting only 40 to 45 pounds. \n\n They reach adult hood at 40 and can live up to 500 years of age. They have dark vision, cunning when it comes to intelligence, wisdom and chrismatic situations.";
    private string halfElf = "\n Half Elves - \n\n Beings that truly belonging neither, half elves or humans. They are said to have some best qualities of the elf and human parents. The human's  curiosity inventivness, and ambition tempered with elves love of nature and love of elvish art. They range the same height and weight as humans and elves. \n\n They reach adulthood at the age of 20 and can live up to 180 years. They have darkvision, and the ability to not be put to sleep by magic like elves. They have the possability of choosing their own skills like humans do. ";
    private string halfOrc = "\n Half Orcs - \n\n Sometimes alliences are formed between orc and human tribes. Those alliences result in a seal of marriages and half orcs are born. Gray pigmented with skin color, jutting jaws and towering builds make the orcish heritage plain to see for all. Tower with a height of 5 to 7 feet tall and weighting between 180 to 250 pounds. \n\n They reach adulthood at the gae of 14 and rarely live longer than 75 years due to their life style.  They have darkvision, proficent in intimidation, a relentless endurance and able to supply savage attacks against opponents.";
    private string teifling = "\n Teiflings - \n\n Derived from human bloodlines in the broadest possible sense, they still look human but because of their infernal heritage they have a clear imprent of demon like features. Possessing horns, a thick tail, sharp teeth ,solid color skin, and no visble sclera or pupils. They are commonly the height and weight of a average human.\n\n They mature and age the same rate as humans but live a few years less. They have darkvision and a resistance to fire and are able to natrually possess a few spells at certain levels.";
    void Start() {
        this.GetComponent<Text>().text = dwarf;
    }
    public void dawrfChoice() {
        this.GetComponent<Text>().text = dwarf;
    }
    public void elfChoice() {
        this.GetComponent<Text>().text = elf;
    }
    public void halfElfChoice() {
        this.GetComponent<Text>().text = halfElf;
    }
    public void halfOrcChoice() {
        this.GetComponent<Text>().text = halfOrc;
    }
    public void halflingChoice() {
        this.GetComponent<Text>().text = halfling;
    }
    public void tieflingChoice() {
        this.GetComponent<Text>().text = teifling;
    }
    public void gnomeChoice() {
        this.GetComponent<Text>().text = gnome;
    }
    public void dragonbornChoice() {
        this.GetComponent<Text>().text = dragonborn;
    }
    public void humanChoice() {
        this.GetComponent<Text>().text = human;
    }
}
