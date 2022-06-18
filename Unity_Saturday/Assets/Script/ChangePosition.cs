using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Transform TargetTransform = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Position:"+ TargetTransform.localPosition.ToString()+"\n" + 
            "Rotation:" + TargetTransform.localRotation.ToString() + "\n" +
            "Scale:" + TargetTransform.localScale.ToString());

        TargetTransform.localPosition = new Vector3(2,2,2);
        TargetTransform.localScale = new Vector3(3, 3, 3);
        TargetTransform.localRotation = Quaternion.Euler(0,0,45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
