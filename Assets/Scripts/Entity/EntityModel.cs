using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityModel : MonoBehaviour
{
    [field: SerializeField] public Transform HandLeft { private set; get; }
    [field: SerializeField] public Transform HandRight { private set; get; }
}
