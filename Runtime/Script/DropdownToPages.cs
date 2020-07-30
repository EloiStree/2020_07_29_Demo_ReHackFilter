using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownToPages : MonoBehaviour
{
    public GameObject[] m_pages;
    public int m_valueAtStart;
    private void Start()
    {
        SetPage(m_valueAtStart);
    }
    public void SetPage(int value) {
        if (value < 0 ||value>=m_pages.Length)
            return;
        for (int i = 0; i < m_pages.Length; i++)
        {
            if(m_pages[i]!=null)
                m_pages[i].SetActive(value == i);

        }
    }
}
