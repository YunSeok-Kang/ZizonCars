using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillUserInfo
{
    // 사용 주체
    public GameObject gameObject;
}

public class SkillSystemRoot : MonoBehaviour {

    protected SkillUserInfo skillUserInfo = null;

    protected virtual bool Init()
    {
        SkillUserInfo userInfo = new SkillUserInfo();
        userInfo.gameObject = gameObject;
        // Todo : SkillUserInfo 클래스에 필드가 추가되면 해당 위치에서 초기화 시켜줄 것.

        skillUserInfo = userInfo;
        return true;
    }

    public virtual void UseSkill()
    {
        // 이 클래스를 상속받는 모든 클래스가 바로 아래의 내용을 자동으로 실행시킬 방법은 없을까?
        if (!Init()) { Debug.LogWarning(gameObject.name + "가 초기화 도중 오류 발생."); return; }

        // Todo : 스킬에 추가하고싶은 내용 추가.
    }
}
