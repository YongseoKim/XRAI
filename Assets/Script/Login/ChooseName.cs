using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseName : MonoBehaviour
{
    public Button chooseButton;
    public Button noButton;
    public Button yesButton;

    void Start()
    {
        // chooseButton�� Ȱ��ȭ�ϰ� noButton�� yesButton�� ��Ȱ��ȭ
        SetActivated(chooseButton, true);
        SetActivated(noButton, false);
        SetActivated(yesButton, false);

        // chooseButton Ŭ�� �̺�Ʈ�� �޼��� ����
        chooseButton.onClick.AddListener(OnChooseButtonClick);
    }

    // ��ư Ȱ��ȭ/��Ȱ��ȭ �޼���
    void SetActivated(Button button, bool isActive)
    {
        button.gameObject.SetActive(isActive);
    }

    // chooseButton Ŭ�� �� ����� �޼���
    void OnChooseButtonClick()
    {
        // chooseButton�� ��Ȱ��ȭ�ϰ� noButton�� yesButton�� Ȱ��ȭ
        SetActivated(chooseButton, false);
        SetActivated(noButton, true);
        SetActivated(yesButton, true);
    }
}
