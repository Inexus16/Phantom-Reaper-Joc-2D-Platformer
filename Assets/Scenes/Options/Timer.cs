using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instance;

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    private void Start()
    {
        instance = this;
    }

    IEnumerator stay()
    {
        yield return new WaitForSeconds(0.2f);
    }

    private void Update()
    {
        if (remainingTime > 0)
            remainingTime -= Time.deltaTime;
        else if(remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            stay();
            SceneManager.LoadScene("TimeRunOut");

        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds= Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        
    }
    public float ret_timeRemaining()
    {
        return remainingTime;
    }
}
