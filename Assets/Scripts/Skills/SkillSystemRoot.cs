using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillUserInfo
{
    // 사용 주체
    public GameObject gameObject;
}

public class SkillSystemRoot : MonoBehaviour {

    SkillUserInfo skillUserInfo = null;

    protected bool Init()
    {
        SkillUserInfo userInfo = new SkillUserInfo();
        userInfo.gameObject = gameObject;
        // Todo : SkillUserInfo 클래스에 필드가 추가되면 해당 위치에서 초기화 시켜줄 것.

        skillUserInfo = userInfo;
        return true;
    }

    public virtual void UseSkill()
    {

    }
}
