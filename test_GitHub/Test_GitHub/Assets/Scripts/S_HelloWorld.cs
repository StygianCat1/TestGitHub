using Unity.VisualScripting;
using UnityEngine;

public class S_HelloWorld : MonoBehaviour
{
    private float A = 10 / 3;
    
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
        Debug.Log (A);
    }

    // Update is called once per frame
    void Update()
    {
        print("Miaou");
        print("mIAOU");
        _numberOfTick++;
        Debug.Log(_numberOfTick);
        If(Type.GetType(State.Miaou) == typeof(int), () =>;
        {
            Debug.Log("l'enum state des chats est de " + State.Mia + " puisque le dieu Miaou le veux");
        }
    }
}
