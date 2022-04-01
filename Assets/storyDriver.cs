using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class storyDriver : MonoBehaviour
{
    // Start is called before the first frame update
    public Text story;
    int counter = 0;
    void Start()
    {
        story.text = "It is said that when children go play in the forest, they get kidnapped by Forest people. (Press Space to Skip)";
        Invoke("line2", 5f);
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            if(counter == 1)
            {
                line2();
            }
            else if(counter == 2)
            {
                line3();
            }
            else if (counter == 3)
            {
                line4();
            }
            else if (counter == 4)
            {
                line5();
            }
            else
            {
                nextseen();
            }
        }
    }
    public void line2()
    {
        story.text = "The forest People teach kids magic. If they succeed, the children become powerful witch doctor else the children die.";
        Invoke("line3", 6f);

    }
    public void line3()
    {
        story.text = "The forest people cave are guarded by magic and it's hard to cross without magic.";
        Invoke("line4", 6f);
    }
    public void line4()
    {
        story.text = "Thought : Today am going to go home and cross this cave.I know basic magic, I can do it.";
        Invoke("line5", 6f);
    }
    public void line5()
    {
        story.text = "So the journey begins.";
        Invoke("nextseen", 6f);

    }
    public void nextseen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
