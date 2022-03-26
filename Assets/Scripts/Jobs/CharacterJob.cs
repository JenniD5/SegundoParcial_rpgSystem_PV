using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;


public class CharacterJob : MonoBehaviour
{
    [SerializeField]
    protected string jobName;

    [SerializeField, TextArea(2,4)]
    protected string jobDescription;

    [SerializeField]
    List<MoveSet> moveSets;

    public virtual void Fire()
    {
        SecondariesEffects();
        UpdateStats();
    }


    public virtual void SecondariesEffects()
    {    }

    

    public virtual void UpdateStats()
    {   }
}
