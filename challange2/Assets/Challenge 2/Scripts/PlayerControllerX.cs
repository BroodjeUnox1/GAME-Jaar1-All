using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float currentTime;
    private float neededTime = 0;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
        	test();
        	if(neededTime < currentTime) {
            		Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            		neededTime = currentTime + 1;
        	} else {
        		print("wacht");
        	}
        }
    }


    void test() 
    {
    	currentTime = Time.time;
    	print(currentTime);
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerControllerX : MonoBehaviour
// {
//     private int width, height;
//     public GameObject dogPrefab;
//     private Rect rect;
//     private GUIStyle labelStyle;
//     private string currentTime;

//     void Awake()
//     {
//         width = Screen.width;
//         height = Screen.height;
//         rect = new Rect(10, 10, width - 20, height - 20);
//     }

//     void OnGUI()
//     {
//         // Display the label at the center of the window.
//         labelStyle = new GUIStyle(GUI.skin.GetStyle("label"));
//         labelStyle.alignment = TextAnchor.MiddleCenter;

//         // Modify the size of the font based on the window.
//         labelStyle.fontSize = 12 * (width / 200);

//         // Obtain the current time.
//         currentTime = Time.time.ToString("f6");
//         currentTime = "Time is: " + currentTime + " sec.";

//         // Display the current time.
//         GUI.Label(rect, currentTime, labelStyle);
//     }
// }