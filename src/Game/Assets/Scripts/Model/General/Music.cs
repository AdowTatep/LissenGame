using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Music {

    /// <summary>
    /// Note list. List of the notes to be spawned/played
    /// </summary>
    public List<INote> noteList { get; set; }

    /// <summary>
    /// Current player's score
    /// </summary>
    public static int score;

    /// <summary>
    /// Current player's accuracy
    /// </summary>
    public static int accuracy;

    public Music(List<INote> noteList)
    {
        this.noteList = noteList;
    }
}
