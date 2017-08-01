using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class pictureSwitcher : MonoBehaviour {
    public string choice = "Dwarf";
    public Sprite[] picture;
    void Start(){
        this.GetComponent<Image>().sprite = Array.Find(picture, element => element.name == "Dwarf");
    }
    public void dawrfChoice(){
        this.GetComponent<Image>().sprite = picture[0];
        choice = "Dwarf";
    }
    public void elfChoice() {
          this.GetComponent<Image>().sprite = picture[4];
          choice = "Elf";
    }
    public void halfElfChoice() {
        this.GetComponent<Image>().sprite = picture[6];
        choice = "Half Elf";
    }
    public void halfOrcChoice() {
        this.GetComponent<Image>().sprite = picture[1];
        choice = "Half Orc";
    }
    public void halflingChoice() {
        this.GetComponent<Image>().sprite = picture[7];
        choice = "Halfling";
    }
    public void tieflingChoice() {
        this.GetComponent<Image>().sprite = picture[3];
        choice = "Tiefling";
    }
    public void gnomeChoice() {
        this.GetComponent<Image>().sprite = picture[5];
        choice = "Gnome";
    }
    public void dragonbornChoice() {
        this.GetComponent<Image>().sprite = picture[2];
        choice = "Dragonborn";
    }
    public void humanChoice() {
        this.GetComponent<Image>().sprite = picture[8];
        choice = "Human";
    }

}
