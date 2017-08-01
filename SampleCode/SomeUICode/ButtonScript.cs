using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//when clicking the button left, right, it will call this script changing the template of the page for the user.
public class ButtonScript : MonoBehaviour {
    public int current = 1;
    private LoadDataDND data;
    private Race chosenRace;//holds your race that was chosen
    private SubRace chosenSubRace;// holds your subrace chosen
     private CombatClass chosenClass;//holds your class chosen

    public GameObject FirstTemplate;//a main template, dealing with Race
    public GameObject SecondTemplate;// a second main template, deaing with Class
    public GameObject RaceChooseTemplate;//choose your race, first page
    public GameObject RaceFillTemplate;//choose fill any details needed, second race
    public GameObject SubRaceChooseTemplate;//choose your subrace, secondpage template
     public GameObject classChooseTemplate;// choose your class template
     public GameObject classArchetypeTemplate;//choose your archetype template
     public GameObject classFillTemplate;// fill in the class data template

    public GameObject SaveData;//data collector holds allinfo and save from input users to race and stuff I NEED TO CALL THE SAVE AT THE END
    public GameObject chooseRace;// holds the image that saves the current race chosen
     public GameObject chooseClass;//holds the image that saves the current class chosen and holds archetype
    public GameObject displayRaceBonus;

    public GameObject Text;
    public GameObject SubraceScriptTextReset;
     public GameObject MissingText;
     public GameObject chooseSubRace;
     public GameObject RacialBonusBox;

    private bool back = false, forward = true;

    void Start() {
        data = new LoadDataDND();
        data.loadRace();
          updatePage();
    }
     public void exitProgram() {
          Application.Quit();
     }
    public void BackPage() {//use this to refresh page inputs when gonig back
          if (current != 1) {//can't go less then page 1
               current--;
               MissingText.GetComponent<Text>().text = "";
               if (current == 2 && SaveRaceCheckSubRace()) {//if there is no subrace, skip.
                    current--;
               }
               if (current == 2) {//if you're on the subrace page, clear the previous chosen
                    chosenSubRace = null;
               }
               if (current <= 2) {// anypoint if the page is back to choose subrace, choose race, it will refresh inputs that was entered by the user to empty
                    SaveData.GetComponent<DataCollector>().refresh();
                    chooseSubRace.GetComponent<SubRaceDescription>().chosen = "";
               }
               if(current==5 && !chooseClass.GetComponent<archetypeSwitcher>().checkLevel(chosenClass.className, int.Parse(SaveData.GetComponent<DataCollector>().Save.level))) {
                    current--;
               }
               updatePage();
        }

    }
    public void FrontPage() {//use this to save inputs when gonig forward
        if (current != 10) {
            current++;
            if (current == 2 && SaveRaceCheckSubRace()) {//going to the second page, if no subrace then skip
                current++;
            }
            if(current == 3 && SaveSubRace()) {//going to fill template, if no subrace was chosen
                    if (chosenSubRace.subRaceName == null) {

                         MissingText.GetComponent<Text>().text = "Choose a SubRace";
                         current--;
                    }else {
                         MissingText.GetComponent<Text>().text = "";
                    }

                    if (chosenRace.raceName=="Half Elf" || chosenSubRace.subRaceName=="High Elf") {//show language depending on situation
                         SaveData.GetComponent<DataCollector>().updateLanguage(true);
                    }else {
                         SaveData.GetComponent<DataCollector>().updateLanguage(false);
                    }
                    if(chosenSubRace.subRaceName=="High Elf") {
                         RacialBonusBox.GetComponent<RacialBonus>().highElf = true;
                    }
                    else {
                         RacialBonusBox.GetComponent<RacialBonus>().highElf = false;
                    }
               }
            if(current == 4) {//going to choose class, if no fields were inputed
                    if (SaveData.GetComponent<DataCollector>().checkInputs()==false) {
                         MissingText.GetComponent<Text>().text = "Missing Inputs";
                         current--;
                    }
                    else {
                         MissingText.GetComponent<Text>().text = "";
                    }
               }
               if(current == 5) {
                    saveAndLoadChosenClass();
                    if (!chooseClass.GetComponent<archetypeSwitcher>().checkLevel(chosenClass.className, int.Parse(SaveData.GetComponent<DataCollector>().Save.level))) {
                         current++;
                    }
               }

               /*if (current == 6) {
                    saveAndLoadChosenClass();
               }*/
               updatePage();
        }
    }
    private void updatePage() {
        switch (current) {
            case 1: //choose Race
                    //current Set
                    //====================================================================================
                    FirstTemplate.SetActive(true);//First main template must be shown
                    RaceChooseTemplate.SetActive(true);//allows you to choose a race
                    Text.GetComponent<Text>().text = "Race";//make the text = race

                    //Set Next Prev 
                    //====================================================================================
                    try {
                         SubRaceChooseTemplate.transform.Find(chosenRace.raceName).gameObject.SetActive(false);//closes from the children all the way to the parents
                    }
                    catch {
                         Debug.Log("No SubRace previously chosen");
                    }
                    SubRaceChooseTemplate.SetActive(false);//When going back, it must set next page to false
                    RaceFillTemplate.SetActive(false);// possibly going back from filling template to this because of specific race skipping subraces;
                    break;
               
            case 2://choose SubRace
                    //current Set
                    //====================================================================================
                    SubRaceChooseTemplate.SetActive(true);//Allows you to choose subrace
                    Text.GetComponent<Text>().text = "SubRace";
                    
                    SubRaceChooseTemplate.transform.Find(chosenRace.raceName).gameObject.SetActive(true);//make the buttons appear for that race
                    SubraceScriptTextReset.GetComponent<Text>().text = "";
                    //Set Next Prev and Afterpages
                    //====================================================================================
                    RaceChooseTemplate.SetActive(false);
                    RaceFillTemplate.SetActive(false);
                    break;
                    
           case 3://User Input for Details
                    //current Set
                    //====================================================================================
                    RaceFillTemplate.SetActive(true);
                    Text.GetComponent<Text>().text = "Enter Details";
                    //Load the racialBonus based on race and subrace
                    //===================================================================================
                    displayRaceBonus.GetComponent<RacialBonus>().LoadRacial(chosenRace);
                    // Set Next Prev
                    //====================================================================================
                    RaceChooseTemplate.SetActive(false);//possibility that the first page is before this because of certain races skiping subracepage.
                    SubRaceChooseTemplate.SetActive(false);
                    SecondTemplate.SetActive(false);
                    FirstTemplate.SetActive(true);//when comnig from second template back to first
                    break;

               case 4://Choose class;
                    //current Set
                    //====================================================================================
                    FirstTemplate.SetActive(false);//all race choosing template is now false
                    SecondTemplate.SetActive(true);// picking a class template is now free;
                    Text.GetComponent<Text>().text = "Pick a Class";
                    classChooseTemplate.SetActive(true);//lets you choose the pick class
                    //===================================================================================
                    //displayRaceBonus.GetComponent<RacialBonus>().LoadRacial(chosenRace);
                    // Set Next Prev
                    //====================================================================================
                    classFillTemplate.SetActive(false);
                    break;
               case 5://Choose choose Archetype;
                    //current Set
                    //====================================================================================
                    Text.GetComponent<Text>().text = chooseClass.GetComponent<archetypeSwitcher>().changeText(chosenClass.className) ;
                    classArchetypeTemplate.SetActive(true);

                    //===================================================================================
                    //displayRaceBonus.GetComponent<RacialBonus>().LoadRacial(chosenRace);
                    // Set Next Prev
                    classChooseTemplate.SetActive(false);
                    classFillTemplate.SetActive(false);
                    //====================================================================================

                    break;
              /* case 6://fill info required;
                    //current Set
                    //====================================================================================
                    Text.GetComponent<Text>().text = "Fill Option";
                    classFillTemplate.SetActive(true);

                    //===================================================================================
                    //displayRaceBonus.GetComponent<RacialBonus>().LoadRacial(chosenRace);
                    // Set Next Prev
                    classChooseTemplate.SetActive(false);
                    //====================================================================================

                    break;*/
               default:/*
                    Text.GetComponent<Text>().text = "N/A";
                    FirstTemplate.SetActive(false);
                    RaceFillTemplate.SetActive(false);
                    RaceChooseTemplate.SetActive(false);*/
                    break;
        }
        forward = false;
        back = false;
    }

    private bool SaveRaceCheckSubRace() {
          chosenRace = data.getRace(chooseRace.GetComponent<pictureSwitcher>().choice);//race chosen by the player
          data.loadSubRace(chosenRace.raceName);
          if (chosenRace.raceName == "Human" || chosenRace.raceName == "Half Elf" || chosenRace.raceName == "Half Orc" || chosenRace.raceName == "Tiefling") {
               return true;
          }
          else
               return false;

    }
    private bool SaveSubRace() {
          if (chosenRace.raceName == "Human" || chosenRace.raceName == "Half Elf" || chosenRace.raceName == "Half Orc" || chosenRace.raceName == "Tiefling") {
               chosenSubRace = data.getSubRace("N/A");
          }
          else
               chosenSubRace = data.getSubRace(chooseSubRace.GetComponent<SubRaceDescription>().chosen);
          return true;
     }
     private void saveAndLoadChosenClass() {
          SaveData.GetComponent<DataCollector>().SaveRace(chosenRace,chosenSubRace);
          chosenClass = data.getClass(chooseClass.GetComponent<classSwitcher>().choice);
          SaveData.GetComponent<DataCollectClass>().setUpClass(chosenClass, int.Parse(SaveData.GetComponent<DataCollector>().Save.level), SaveData.GetComponent<DataCollector>().Save.skillsknown);

     }

}
