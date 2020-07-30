using UnityEngine;

public class RestreamChatMessageFilterDemoAdded : MonoBehaviour
{
    public RestreamChatMessageFilterDemo m_demo;

    public void SetListenWordsSplitBySpace(string text)
    {
        if (text == null)
            return;

        m_demo.m_lookingFor = text.Split(' ');
    }
    
    public void SetListenWords(string [] wordsToListen)
    {
        m_demo.m_lookingFor = wordsToListen;
    }
}
