using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrays : MonoBehaviour
{
    // Arrays made in class
    string[] array1 = new string[4];
    float[] array2 = new float[] { 1f, 2f, 3f, 4f };
    int[] array3 = new int[] { 1, 2, 3, 4 };


    // AUFGABE__________________________________________________________________
    // 4 Werte überall
    // 1) Durchlaufen ausgeben der Werte
    // 2) Länge des Arrays ausgeben als Debug
    // 3) 2 Werte Direkt ändern
    // 4) GameObjects Images anlegen, Tag vergeben, Zuweisen und Farbe ändern.


    public void Start()
    {
        OutputArray(array3);
        LengthArray(array3);
        ChangeTwoValues(array3);
        ColorArray();

    }

    //1.__________________________________________________________________

    void OutputArray(int[] intArray)
    {
        string tmp = "";
        for (int i = 0; i < intArray.Length; i++)
        {
            tmp += intArray[i].ToString() + " ";
      
        }
        print(tmp);
    }

    //2.__________________________________________________________________

    void LengthArray(int[] intArray)
    {
        print(intArray.Length.ToString());

    }

    //3.__________________________________________________________________

    void ChangeTwoValues(int[] intArray)
    {
        intArray[1] = 3;
        intArray[2] = 4;
    }

    //4.__________________________________________________________________

    void ColorArray()
    {
        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
        arrayColoredImagesRed[2].GetComponent<Image>().color = Color.red;
    }
   
}
