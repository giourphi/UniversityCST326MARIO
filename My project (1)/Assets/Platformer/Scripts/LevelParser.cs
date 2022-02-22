using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Serialization;

public class LevelParser : MonoBehaviour
{
    public string filename;
    public GameObject rockPrefab;
    public GameObject brickPrefab;
    public GameObject questionBoxPrefab;
    [FormerlySerializedAs("stonePrefab")]
    public GameObject StonePrefab;
    public Transform environmentRoot;

    // --------------------------------------------------------------------------
    void Start()
    {
        LoadLevel();
    }

    // --------------------------------------------------------------------------
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadLevel();
        }
        
    }

    // --------------------------------------------------------------------------
    private void LoadLevel()
    {
        string fileToParse = $"{Application.dataPath}{"/Resources/"}{filename}.txt";
        Debug.Log($"Loading level file: {fileToParse}");

        Stack<string> levelRows = new Stack<string>();

        // Get each line of text representing blocks in our level
        using (StreamReader sr = new StreamReader(fileToParse))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                levelRows.Push(line);
            }

            sr.Close();
        }


        int counter = 0; 

        // Go through the rows from bottom to top
        int row = 0;
        while (levelRows.Count > 0)
        {
            string currentLine = levelRows.Pop();

            int column = 0;
            char[] letters = currentLine.ToCharArray();
            foreach (var letter in letters)
            {
                // Todo - Instantiate a new GameObject that matches the type specified by letter
                var testObject = Instantiate(rockPrefab);
                var stoneObject = Instantiate(StonePrefab);
                if (letter == 'x')
                {
                    testObject.transform.position = new Vector3(column-2f, row-6.55f, 0f);
                   

                }
                // Todo - Position the new GameObject at the appropriate location by using row and column
               // if (stoneObject)
               // {
                  //  float xvalue = 135.8925f;
                   // float yvalue = -4.551449f;
                    
                   // if()
                   // stoneObject.transform.position = new Vector3(row+xvalue, column+yvalue, 0f);
               // }

                // Todo - Parent the new GameObject under levelRoot
                //testObject.transform.SetParent(environmentRoot);
                //stoneObject.transform.SetParent(environmentRoot);
                column++;
            }
            row++;
          //  counter++;
        }
    }

    // --------------------------------------------------------------------------
    private void ReloadLevel()
    {
        foreach (Transform child in environmentRoot)
        {
           Destroy(child.gameObject);
        }
        LoadLevel();
    }
}
