using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenu : MonoBehaviour
{
    [SerializeField] GameObject EntryPrefab;

    [SerializeField] float Radius = 200f;

    [SerializeField] List<Texture> Icons;

    List<RadialMenuEntry> Entries;

    public bool isOpen=false;
    public bool isCreate=false;

    private void Start()
    {
        Entries = new List<RadialMenuEntry>();
    }

    void AddEntry(string pLabel, Texture picon)
    {
        GameObject entry = Instantiate(EntryPrefab, transform);

        RadialMenuEntry rme = entry.GetComponent<RadialMenuEntry>();
        rme.SetLabel(pLabel);
        rme.SetIcon(picon);

        Entries.Add(rme);
    }

    public void Open()
    {
        if (!isOpen&&!isCreate)
        {
            isCreate = true;
            isOpen = true;

            for (int i = 0; i < 8; i++)
            {
                AddEntry("Button" + i.ToString(), Icons[i]);
            }
            Rearrange();
        }

        else if (isOpen&&isCreate)
        {
            Close();
        }
        else if (!isOpen && isCreate)
        {
            OpenUI();
        }


    }
    void OpenUI()
    {
        for (int i = 0; i < 8; i++)
        {
            Entries[i].gameObject.SetActive(true);
        }
    }
    private void Close()
    {
        for (int i = 0; i < 8; i++)
        {
            Entries[i].gameObject.SetActive(false);
        }

    }

    public void Rearrange()
    {
        float radiansOfSeparation = (Mathf.PI * 2) / Entries.Count;
        for (int i = 0; i < Entries.Count; i++)
        {
            float x = Mathf.Sin(radiansOfSeparation * i) * Radius;
            float y = Mathf.Cos(radiansOfSeparation * i) * Radius;

            Entries[i].GetComponent<RectTransform>().anchoredPosition = new Vector3(x, y, 0);
        }
    }
}