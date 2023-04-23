using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Directory : MonoBehaviour
{
    public Text text; //variable for component that displays the text

    //NOTE: notice that this is a list of NYUPerson, but can still hold all subclasses. THAT'S POLYMORPHISM, BABY!
    public List<NYUPerson> nyuPeopleList; //list of people at nyu

    int recordNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        nyuPeopleList = new List<NYUPerson>();

        //make a new NYUFaculty 
        // NYUPerson mattParker = new NYUPerson("Matt Parker",
        //                                       "mp612");
        NYUPerson mattParker = new NYUStaff("Matt Parker", "mp612", 10000);

        nyuPeopleList.Add(mattParker); //add mattParker to the nyuPeopleList
        
        NYUPerson somebody = new NYUStudent("Jane Doe", "jd123", 4.0f, 36);
        nyuPeopleList.Add(somebody);
        
        // NYUPerson somebodyelse = new NYUPerson();
        // nyuPeopleList.Add(somebodyelse);

        NYUPerson yeseulSong = new NYUFaculty("Yeseul Song", "ys123", 100000,
            false);
        nyuPeopleList.Add(yeseulSong);

        NYUPerson Amy = new NYUTischStudent("Amy", "ab123", 3.9f, 32, "MFA");
        nyuPeopleList.Add(Amy);
        
        NYUPerson Bruce = new NYUTandonStudent("Bruce", "bc123", 3.8f, 36, "MS");
        nyuPeopleList.Add(Bruce);
        
        UpdateRecord(); //update the text display to show the the info from the first person in the list
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){ //if space is pressed
            UpdateRecord(); //change the record to display the next person in the list
        }
    }

    void UpdateRecord(){
        NYUPerson person = nyuPeopleList[recordNum % nyuPeopleList.Count]; //grab the object a person in the list (use % to wrap around)

        text.text = person.ShowRecord(); //display the info for this object

        recordNum++; //increase the recordNum so we show the next person next time through
    }
}
