using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject audioSourceObject;

    void Start()
    {
        if (audioSourceObject != null)
        {
            audioSourceObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning("AudioSourceObject�� �Ҵ���� �ʾҽ��ϴ�.");
        }
    }
}
