using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NoteSpawner : MonoBehaviour
{
    public GameObject noteObjectToSpawn;
    public GameObject objectHitbox;

    public List<INote> notes;
    private int noteIndex;

    void Start()
    {
        noteIndex = 0;
    }

    void FixedUpdate()
    {
        //If there's any notes left
        if (noteIndex < notes.Count)
            //Spawn the note in the desired second
            if (Time.fixedTime == (notes[noteIndex].msToSpawn / 1000))
                spawnNote(notes[noteIndex]);
    }

    private void spawnNote(INote note)
    {
        //Spawn the object
        var objNote = Instantiate(noteObjectToSpawn, this.transform.position, this.transform.rotation) as GameObject;
        //Set its destination
        objNote.GetComponent<GameNote>().hitbox = objectHitbox;

        objNote.GetComponent<GameNote>().note = note;

        noteIndex++;
    }
}