using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
    }

    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
