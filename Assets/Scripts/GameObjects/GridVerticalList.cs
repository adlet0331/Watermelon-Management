using UnityEngine;

public class GridVerticalList : MonoBehaviour
{
    [SerializeField] private GameObject ContentObject;

    public void AddChild(GameObject child)
    {
        child.gameObject.transform.SetParent(ContentObject.gameObject.transform);
    }
}
