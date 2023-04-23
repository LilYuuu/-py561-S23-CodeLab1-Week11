using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUTandonStudent : NYUStudent
{
    public string degree = "MS";

    public NYUTandonStudent(
        string name, string netID, float gpa, int credits, string degree
        ) : base(name, netID, gpa, credits)
    {
        this.degree = degree;
        
        type = "NYU Tandon Student";
    }
    
    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nDegree: " + degree;
    }
}
