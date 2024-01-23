using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum CharacterType
{
    Penguin,
    Knight
}

[Serializable]

public class Character
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;

}



public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Character> CharaterList = new List<Character>();


    public Animator PlayerAnimator;
    public TextMeshProUGUI playerName;



    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void SetCharacter(CharacterType characterType, string name)
    {
        var character = GameManager.Instance.CharaterList.Find(item => item.CharacterType == characterType);

        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        playerName.text = name;
    }
}
