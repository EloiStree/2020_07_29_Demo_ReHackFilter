using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPushAtStart : MonoBehaviour
{
    public InputField m_input;
    void Start()
    {
        m_input.text = m_input.text;
        m_input.onValueChanged.Invoke(m_input.text);
    }
    private void Reset()
    {
        m_input = GetComponent<InputField>();
    }
}
