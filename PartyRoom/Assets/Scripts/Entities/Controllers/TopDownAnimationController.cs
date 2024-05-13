using UnityEngine;

public class TopDownAnimationController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private Animator animatorA;
    [SerializeField] private AnimatorOverrideController[] otheranims;

    private TopDownController controller;

    private bool IsWalk = false;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        animatorA = GetComponent<Animator>();
        
        switch(GameManager.instance.savePlayerData.characterChangePath)
        {
            case "A":
                break;
            case "B":
                animatorA.runtimeAnimatorController = otheranims[0];
                break;
            case "C":
                animatorA.runtimeAnimatorController = otheranims[1];
                break;
            case "D":
                animatorA.runtimeAnimatorController = otheranims[2];
                break;
            case "E":
                animatorA.runtimeAnimatorController = otheranims[3];
                break;
            default:
                Debug.LogError("characterChangePath�� �̸��� Ʋ��");
                break;
        }
    }

    void Start()
    {
        controller.OnMoveEvent += OnWalk;
        // ���콺�� ��ġ�� ������ OnLookEvent�� ���. ĳ���� �̹��� ������ȯ�� ���.
        controller.OnLookEvent += OnAim;
    }

    public void OnWalk(Vector2 playerMovement)
    {
        //�켱�� �����Ӹ� �����ϵ��� ����.
        if (playerMovement == Vector2.zero)
        {
            IsWalk = false;
            animatorA.SetBool("IsWalk", false);
        }
    else
        {
            IsWalk = true;
            animatorA.SetBool("IsWalk", true);
        }
    }

    public void OnAim(Vector2 newAimDirection)
    {
        // OnLook
        playerVision(newAimDirection);
    }

    private void playerVision(Vector2 direction)
    {
        // ���� ���.
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        int playerVisionRange = GetMouseDirection(rotZ);

        if (IsWalk)
        {
            ChangeAnimationWalk(playerVisionRange);
        }
        else
        {
            ChangeAnimationStay(playerVisionRange);
        }
    }

    private void ChangeAnimationWalk(int visionRange)
    {
        AnimatorStateInfo stateInfo = animatorA.GetCurrentAnimatorStateInfo(0);
        float syncTime = stateInfo.normalizedTime % 1;

        switch (visionRange)
        {
            case 0:
                animatorA.Play("PlayerWalkUp", 0, syncTime);
                break;
            case 1:
                animatorA.Play("PlayerWalkDown", 0, syncTime);
                break;
            case 2:
                characterRenderer.flipX = false;
                animatorA.Play("PlayerWalkSide", 0, syncTime); //����
                break;
            case 3:
                characterRenderer.flipX = true;
                animatorA.Play("PlayerWalkSide", 0, syncTime); //������
                break;
            default:
                break;
        }
    }

    private void ChangeAnimationStay(int visionRange)
    {
        AnimatorStateInfo stateInfo = animatorA.GetCurrentAnimatorStateInfo(0);
        float syncTime = stateInfo.normalizedTime % 1;

        switch (visionRange)
        {
            case 0:
                animatorA.Play("PlayerUp", 0, syncTime);
                break;
            case 1:
                animatorA.Play("PlayerDown", 0, syncTime);
                break;
            case 2:
                characterRenderer.flipX = false;
                animatorA.Play("PlayerSide", 0, syncTime); //����
                break;
            case 3:
                characterRenderer.flipX = true;
                animatorA.Play("PlayerSide", 0, syncTime); //������
                break;
            default:
                break;
        }
    }

    private int GetMouseDirection(float angle)
    {
        if (angle >= -45f && angle < 135f)
        {
            if (angle >= 45f)
            {
                return 0;
            }
            else
            {
                return 3;
            }
        }
        else
        {
            if (Mathf.Abs(angle) < 135f)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}