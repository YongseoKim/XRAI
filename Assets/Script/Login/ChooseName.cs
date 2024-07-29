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
        // chooseButton을 활성화하고 noButton과 yesButton을 비활성화
        SetActivated(chooseButton, true);
        SetActivated(noButton, false);
        SetActivated(yesButton, false);

        // chooseButton 클릭 이벤트에 메서드 연결
        chooseButton.onClick.AddListener(OnChooseButtonClick);
    }

    // 버튼 활성화/비활성화 메서드
    void SetActivated(Button button, bool isActive)
    {
        button.gameObject.SetActive(isActive);
    }

    // chooseButton 클릭 시 실행될 메서드
    void OnChooseButtonClick()
    {
        // chooseButton을 비활성화하고 noButton과 yesButton을 활성화
        SetActivated(chooseButton, false);
        SetActivated(noButton, true);
        SetActivated(yesButton, true);
    }
}
