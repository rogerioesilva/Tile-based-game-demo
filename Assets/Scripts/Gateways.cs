using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gateways : MonoBehaviour
{
    public List<string> Rooms;
    public List<Vector2> Minimum;
    public List<Vector2> Maximum;
    public float titleDuration = 4f;
    public Text refTitleUI;
    public Soundtracks SoundtracksRef;

    private int currentRoom = -1;
    private CameraGame cameraRef;

    // Start is called before the first frame update
    void Start()
    {
        cameraRef = Camera.main.GetComponent<CameraGame>();
        EnterRoom(0);
    }
    public void EnterRoom(int number)
    {
        GetComponent<AudioSource>().Play();

        currentRoom = number;
        SoundtracksRef.PlayTrack(currentRoom);
        cameraRef.minPosition = Minimum[currentRoom];
        cameraRef.maxPosition = Maximum[currentRoom];

        StartCoroutine(ShowTitleUI());
    }
    private IEnumerator ShowTitleUI()
    {
        refTitleUI.text = Rooms[currentRoom];
        yield return new WaitForSeconds(titleDuration);
        refTitleUI.text = "";
    }
    public int getCurrentRoom()
    {
        return currentRoom;
    }
}
