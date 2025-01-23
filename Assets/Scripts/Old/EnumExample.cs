using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{
    enum myEnum
    {
        e0,
        e1,
        e2,
    }

    enum seEnum
    {
        e0 = 5,
        e1, e2 = 10,
    }

    enum Day
    {
        Sun,
        Mon,
        Tues,
        Wednes,
        Thurs,
        Fry,
        Satur
    }

    [Flags]
    enum Days
    {
        Sun = 0,
        Mon = 1,
        Tues = 2,
        Wednes = 4,
        Thurs = 8,
        Fry = 16,
        Satur = 32,
    }

    enum Month:Byte
    {
        Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nob, Dec
    }

    int[] li = new int[] {1,2, 4};

    enum GameState
    {
        ready,
        play,
        gameOver,
    }

    public void StateGame()
    {
        GameState gameState = GameState.ready;
        if(gameState == GameState.ready)
        {

        }
        else if(gameState == GameState.play)
        {

        }
        else if(gameState == GameState.gameOver)
        {

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Day today = Day.Wednes;
        int dayNumber = (int)today;
        Debug.Log($"{today}'s day number is {dayNumber}");

        Month thisMonth = Month.Jan;
        byte monthNumber = (byte)thisMonth;
        Debug.Log($"{thisMonth}'s day number is {monthNumber}");

        Days workingDays = Days.Mon | Days.Tues | Days.Wednes | Days.Thurs | Days.Fry;

        Debug.Log($"working day is {workingDays}");

        Days today2 = Days.Wednes;
        if(workingDays.HasFlag(today2))
        {
            Debug.Log("today is working day");
        }
        else
        {
            Debug.Log("Today is holiday");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
