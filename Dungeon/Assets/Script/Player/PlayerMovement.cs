using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerStatus")]
    [SerializeField]
    public int moveSpeed;
    public int playerHp;

    protected Animator animator;

    private Camera camera;
    private Vector3 destination;
    
    //캐릭터 제어 변수
    private bool isMove;
    public bool comboAttack;
    public bool isAttack;
    private float mouseX;
    private float mouseZ;
    private void Awake()
    {
        camera = Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Horizontal");
        mouseZ = Input.GetAxis("Vertical");
        GetPosition();
        Move();
        Attack();
    }

    private void SetDestination(Vector3 dest)
    {
        destination = dest;
        isMove = true;
        animator.SetBool("isMove", true);
    }

    private void GetPosition()
    {
        if(Input.GetMouseButton(1))
        {
            RaycastHit hit;
            if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit, 100f,
                1 << LayerMask.NameToLayer("Floor")))
            {
                if (Vector3.Distance(animator.transform.position, hit.point) >= 0.1f)
                {
                    SetDestination(hit.point);
                }
            }
        }
    }

    private void Move()
    {
        if(isMove)
        {
            var dir = destination - animator.transform.position;
            if (animator.transform.forward != dir)
            {
                //TOdo. 이동중 캐릭터 바로 뒤쪽을 찍을 경우 회전하지 않는 현상
                animator.transform.forward += dir * Time.deltaTime * 8f;
            }
            animator.transform.position += dir.normalized * Time.deltaTime * moveSpeed;
        }

        if(Vector3.Distance(animator.transform.position, destination) <= 0.1f)
        {
            isMove = false;
            animator.SetBool("isMove", false);
        }
    }

    private void LookMouseCursor()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            Vector3 forward = new Vector3(hit.point.x, animator.transform.position.y, hit.point.z ) - animator.transform.position;
            animator.transform.forward = forward;
        }
    }
    private void Attack()
    {
        if(Input.GetMouseButton(0))
        {
            LookMouseCursor();
            if (!isAttack)
            {
                isAttack = true;
                animator.SetTrigger("normalAttack");
            }
            else if(isAttack)
            {
                comboAttack = true;
            }
        }
    }

    public void CheckCombo()
    {
        if(comboAttack)
        {
            animator.SetBool("Combo", true);
        }
        else
        {
            animator.SetBool("Combo", false);
        }
    }

    public void ResetCombo()
    {
        comboAttack = false;
    }
}
