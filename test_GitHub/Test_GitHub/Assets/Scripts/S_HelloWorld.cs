using Unity.VisualScripting;
using UnityEngine;

public class S_HelloWorld : MonoBehaviour
{
    [SerializeField] private int _numberOfTick = 0;
    private enum State
    {
        M,
        Mi,
        Mia,
        Miao,
        Miaou
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Miaou");
    }

    // Update is called once per frame
    void Update()
    {
        _numberOfTick++;
        Debug.Log(_numberOfTick);
        Debug.Log(State.Miao);
    }
}
