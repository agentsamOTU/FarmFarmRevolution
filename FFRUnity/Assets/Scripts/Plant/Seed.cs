using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public enum Tasks
{
    None,
    Water,
    Till,
    Fertilize
}

public class Seed
{
    private float score;
    public Stack<Tasks> tasksToDo = new Stack<Tasks>();

    public void SetUpTasks(Tasks newTasks)
    {
        tasksToDo.Push(newTasks);
    }

    public void SetScore(float newScore)
    {
        score = newScore;
    }

    public float GetScore()
    {
        return score;
    }

    public Tasks GetTasks() 
    {
        if (tasksToDo.Any())
        {
            return tasksToDo.Peek();
        }
        else
            return Tasks.None;
    }

    public void CompleteTask()
    {
        tasksToDo.Pop();
    }
}
