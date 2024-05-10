using UnityEngine;

public class TopDownLookRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private Animator characterAnimator;

    private TopDownController controller;

    private bool IsWalk = false;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        characterAnimator = GetComponent<Animator>();
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
            characterAnimator.SetBool("IsWalk", false);
        }
    else
        {
            IsWalk = true;
            characterAnimator.SetBool("IsWalk", true);
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
        AnimatorStateInfo stateInfo = characterAnimator.GetCurrentAnimatorStateInfo(0);
        float syncTime = stateInfo.normalizedTime % 1;

        switch (visionRange)
        {
            case 0:
                characterAnimator.Play("PlayerWalkUp", 0, syncTime);
                break;
            case 1:
                characterAnimator.Play("PlayerWalkDown", 0, syncTime);
                break;
            case 2:
                characterRenderer.flipX = false;
                characterAnimator.Play("PlayerWalkSide", 0, syncTime); //����
                break;
            case 3:
                characterRenderer.flipX = true;
                characterAnimator.Play("PlayerWalkSide", 0, syncTime); //������
                break;
            default:
                break;
        }
    }

    private void ChangeAnimationStay(int visionRange)
    {
        AnimatorStateInfo stateInfo = characterAnimator.GetCurrentAnimatorStateInfo(0);
        float syncTime = stateInfo.normalizedTime % 1;

        switch (visionRange)
        {
            case 0:
                characterAnimator.Play("PlayerUp", 0, syncTime);
                break;
            case 1:
                characterAnimator.Play("PlayerDown", 0, syncTime);
                break;
            case 2:
                characterRenderer.flipX = false;
                characterAnimator.Play("PlayerSide", 0, syncTime); //����
                break;
            case 3:
                characterRenderer.flipX = true;
                characterAnimator.Play("PlayerSide", 0, syncTime); //������
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