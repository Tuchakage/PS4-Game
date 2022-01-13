using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{

    public GameObject cp;
    public GameObject CheckpointHolder;

    public GameObject[] Players;
    public Transform[] CheckpointPositions;
    public GameObject[] CheckpointForEachPlayer;

    private int totalPlayers;
    private int totalCheckpoints;
    // Start is called before the first frame update
    void Start()
    {
        totalPlayers = Players.Length;
        totalCheckpoints = CheckpointHolder.transform.childCount;
        setCheckpoints();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setCheckpoints()
    {
        CheckpointPositions = new Transform[totalCheckpoints];

        for (int i = 0; i < totalCheckpoints; i++)
        {
            CheckpointPositions[i] = CheckpointHolder.transform.GetChild(i).transform;
        }

        CheckpointForEachPlayer = new GameObject[totalPlayers];

        for (int i = 0; i < totalPlayers; i++)
        {
            CheckpointForEachPlayer[i] = Instantiate(cp, CheckpointPositions[0].position, CheckpointPositions[0].rotation);
            CheckpointForEachPlayer[i].name = "CP" + i;
            CheckpointForEachPlayer[i].layer = 6 + i;
            CheckpointForEachPlayer[i].layer = 7 + i;
        }
    }
}
