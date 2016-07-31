using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

public class MusicManager : MonoBehaviour
{
    private Music music;

    void Start()
    {
        //Placeholder note list
        List<INote> listAdd = new List<INote>();
        listAdd.Add(new DrumNote() { msToSpawn = 1000, type = DrumTypes.Crash });
        listAdd.Add(new DrumNote() { msToSpawn = 3000, type = DrumTypes.Crash });
        listAdd.Add(new DrumNote() { msToSpawn = 6000, type = DrumTypes.Crash });
        listAdd.Add(new DrumNote() { msToSpawn = 9000, type = DrumTypes.Crash });
        listAdd.Add(new DrumNote() { msToSpawn = 11000, type = DrumTypes.Crash });

        music = new Music(listAdd);

        //Creates a list of the existing types from the note list
        //So we set the notes only for those types that actually exists in the list.
        var availableTypes = listAdd.Select(note => note.type).ToList();
        
        //For each type that we want, we get its value.
        foreach (DrumTypes value in availableTypes)
        {
            //Find the game object with the tag name that corresponds the "value"
            var noteObj = GameObject.FindGameObjectWithTag(Enum.GetName(typeof(DrumTypes), value));
            //Find its note spawner and put there every note that it is from this "value" type
            noteObj.GetComponent<NoteSpawner>().notes = listAdd.FindAll(note => note.type == value);
        }
    }    
}
