using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUTischStudent : NYUStudent
{
    public string degree = "MFA";

    public NYUTischStudent(
        string name, string netID, float gpa, int credits, string degree
        ) : base(name, netID, gpa, credits)
    {
        this.degree = degree;
        
        type = "NYU Tisch Student";
    }
    
    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nDegree: " + degree;
    }
}
