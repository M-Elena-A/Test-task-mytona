using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bonus_platform : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody ball;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("increaseP_t"))
        {
            
            gameObject.transform.localScale += new Vector3(1.0f, 0.0f, 0.0f);
            Invoke("SetWall", 10);
        }
        //
        if (other.gameObject.CompareTag("extra_b"))
        {
            Vector3 tempVect = new Vector3(0, -3.5f, 5);
            Rigidbody Bonus;
            Bonus = Instantiate(ball, tempVect, ball.rotation) as Rigidbody;
            
        }
        if (other.gameObject.CompareTag("speed_up"))
        {

            var item = ball.GetComponent<move_ball>();
            item.speed = item.speed * 2f;
            Invoke("SpeedDown", 10);
        }
        if (other.gameObject.CompareTag("speed_down"))
        {
            ball.GetComponent<move_ball>().speed = ball.GetComponent<move_ball>().speed / 2f;
            Invoke("SpeedUp", 10);
        }
    }
    void SetWall()
    { gameObject.transform.localScale -= new Vector3(1.0f, 0.0f, 0.0f); }
    void SpeedDown()
    { ball.GetComponent<move_ball>().speed = ball.GetComponent<move_ball>().speed / 2f; }
    void SpeedUp()
    { ball.GetComponent<move_ball>().speed = ball.GetComponent<move_ball>().speed * 2f; }
}
