using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject {
    public string kitchenObjectName;
    public Sprite kitchenObjectIcon;
    public Transform kitchenObjectPrefab;
}
