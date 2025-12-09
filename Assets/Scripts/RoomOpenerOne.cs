using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomOpenerOne : MonoBehaviour
{
    public BoxCollider2D doorCollider;
    public UnityEvent puzzleDone;
    public UnityEvent puzzleWrong;
    public int numberOfLevers;
    public readonly List<int> leverOrder = new();
    public bool isPuzzleFinished = false;
    //levers 1 -> 4 -> 2 -> 3
    public void OnLeverFlicked(int lever)
    {
        if (isPuzzleFinished) return;
        leverOrder.Add(lever);
        if (leverOrder.Count == numberOfLevers)
        {
            int current = 1;
            foreach(int item in leverOrder)
            {
                if (item == current)
                {
                    current++;
                }
                else
                {
                    puzzleWrong.Invoke();
                    leverOrder.Clear();
                    return;
                }
            }
            puzzleDone.Invoke();
            doorCollider.enabled = false;
            isPuzzleFinished = true;
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
