using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Music {

    public Music(List<INote> noteList)
    {
        this.noteList = noteList;
    }

    public List<INote> noteList { get; set; }
    public int accuracy;
}
