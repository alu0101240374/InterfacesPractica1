using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptContador : MonoBehaviour
{
    // Start is called before the first frame update
    List<(GameObject, int, int)> tuplesList = new List<(GameObject, int, int)>();
    (GameObject, int, int)[] tuplesArray;
    void Start()
    { 
      GameObject[] allGameObjects = SceneManager.GetActiveScene().GetRootGameObjects();
      int identifier = 0;
      foreach (var item in allGameObjects) {
        (GameObject gameObject_, int identifier_, int counter_) tmpTuple = (item, identifier, 0);
        tuplesList.Add(tmpTuple);
        Debug.LogFormat($"Item: {tmpTuple.gameObject_} has identifier: {tmpTuple.identifier_}");
        identifier++;
      }
      tuplesArray = tuplesList.ToArray();
    }

    // Update is called once per frame
    void Update()
    {
      for (int i = 0; i < tuplesArray.Length; i++) {
        Debug.Log($"Ident: {tuplesArray[i].Item2} Counter: {tuplesArray[i].Item3++}");
      }
    }
}
