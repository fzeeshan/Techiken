using UnityEngine;

public class CharacterAnim : MonoBehaviour {

    private Animator anim;
    float dirX;//initialize movement
    float moveSpeed = 4.0f;

    //attack offset after attacking
    float SweepOffset = 3.97f;
    float KickOffset = 1.43f;

    bool isHandSweep = false;
    bool isSkip = false;
    bool isPunch = false;
    bool isKick = false;
    bool isAttack = false;  



    void Start() {
        anim = GetComponent<Animator>();
        if(this.gameObject.name.Equals("Player2")){
            SweepOffset = SweepOffset*-1;
            KickOffset = KickOffset*-1;
        }
    }

    void Update() {

        UpdateMovement();
        HandSweep();
        LowKick();
        FlashPunching();

    }

    void UpdateMovement() {
        if (!isAttack) { //only works in case of no attacks
            if((Input.GetKey(KeyCode.A) && this.gameObject.name.Equals("Player1")) || (Input.GetKey(KeyCode.J) && this.gameObject.name.Equals("Player2"))){
                dirX = -1 * moveSpeed * Time.deltaTime;//algo for movement static type
                transform.position = new Vector2 (transform.position.x + dirX, transform.position.y);
                anim.SetBool ("WalkBacking", true);
            } else {
                anim.SetBool ("WalkBacking", false);
            }
            if((Input.GetKey(KeyCode.D) && this.gameObject.name.Equals("Player1")) || (Input.GetKey(KeyCode.L) && this.gameObject.name.Equals("Player2"))){
                dirX = 1 * moveSpeed * Time.deltaTime;//algo for movement static type
                transform.position = new Vector2 (transform.position.x + dirX, transform.position.y);
                anim.SetBool ("Walking", true);
            } else {
                anim.SetBool ("Walking", false);
            }
        }
    }

    void HandSweep() {
        //Df+1 sweep
        if((Input.GetKey(KeyCode.T) && this.gameObject.name.Equals("Player1")) || (Input.GetKey(KeyCode.P) && this.gameObject.name.Equals("Player2"))){
            isHandSweep = true;
            isAttack = true;
            anim.SetBool("HandSweeping",true);
        } else {
            anim.SetBool("HandSweeping",false);
            if(isHandSweep && !anim.GetCurrentAnimatorStateInfo(0).IsName("hand sweep")){
                if(isSkip){
                    transform.position = new Vector2 (transform.position.x + SweepOffset, transform.position.y);
                    isHandSweep = false;
                    isAttack = false;
                    isSkip = false;
                } else {
                    isSkip = true;
                }
            }
        }
    }

    void LowKick() {
        //low kick
        if((Input.GetKey(KeyCode.G) && this.gameObject.name.Equals("Player1")) || (Input.GetKey(KeyCode.Semicolon) && this.gameObject.name.Equals("Player2"))){
            isKick = true;
            isAttack = true;
            anim.SetBool("LowKicking",true);
        } else {
            anim.SetBool("LowKicking",false);
            if(isKick && !anim.GetCurrentAnimatorStateInfo(0).IsName("lowKick")){
                if(isSkip){
                    transform.position = new Vector2 (transform.position.x + KickOffset, transform.position.y);
                    isKick = false;
                    isSkip = false;
                    isAttack = false;
                } else {
                    isSkip = true;
                }
            }
        }
    }

    void FlashPunching() {
        if((Input.GetKey(KeyCode.Y) && this.gameObject.name.Equals("Player1")) || (Input.GetKey(KeyCode.LeftBracket) && this.gameObject.name.Equals("Player2"))){
            anim.SetBool("FlashPunching",true);
        } else {
            anim.SetBool("FlashPunching",false);
        }
    }
}
