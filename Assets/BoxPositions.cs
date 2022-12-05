using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPositions : MonoBehaviour
{
    public static BoxPositions instance;

    [SerializeField] private Transform angelBoxPosition;
    [SerializeField] private Transform dogBoxPosition;
    [SerializeField] private Transform catBoxPosition;

    #region singleton
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            return;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
    }
    #endregion

    public Transform AngelBoxPosition { get => angelBoxPosition; }
    public Transform DogBoxPosition { get => dogBoxPosition; }
    public Transform CatBoxPosition { get => catBoxPosition; }
}
