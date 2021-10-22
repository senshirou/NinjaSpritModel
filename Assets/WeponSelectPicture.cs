using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponSelectPicture : MonoBehaviour
{
    [SerializeField] GameObject WeponSelect;
    [SerializeField] GameObject Wepon1Slash;
    [SerializeField] GameObject Wepon2Bakutiku;
    [SerializeField] GameObject Wepon3IronBall;
    [SerializeField] MyPlayerScript Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.NowWepon == "Slash")
        {
            WeponSelect.transform.position = Wepon1Slash.transform.position;
        }

        else if(Player.NowWepon == "Bakutiku")
        {
            WeponSelect.transform.position = Wepon2Bakutiku.transform.position;
        }

        else if (Player.NowWepon == "IronBall")
        {
            WeponSelect.transform.position = Wepon3IronBall.transform.position;
        }
    }

    public void Bakutiku()
    {

    }
}
