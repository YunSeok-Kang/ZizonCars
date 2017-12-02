using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alphaca : SkillSystemRoot
{

    public GameObject alphacaSpit = null;
    public GameObject startSpit = null;

    protected override bool Init()
    {
        if (!base.Init())
        {
            return false;
        }

        // Todo : 초기화 하고싶은 내용 여기에 추가.

        return true;
    }

    public override void UseSkill()
    {
        // 이 클래스를 상속받는 모든 클래스가 바로 아래의 내용을 자동으로 실행시킬 방법은 없을까?
        if (!Init()) { Debug.LogWarning(gameObject.name + "가 초기화 도중 오류 발생."); return; }

        // Todo : 스킬에 추가하고싶은 내용 추가. 

        if (Input.GetKey(KeyCode.Space))
        {
            GameObject createdObj = Instantiate(alphacaSpit);
            createdObj.transform.parent = gameObject.transform.parent;
            createdObj.transform.position = startSpit.transform.position;
            createdObj.transform.rotation = startSpit.transform.rotation;
        }
        /* 해당 주석의 내용은 보기 불편할 시 바로 삭제할 것.
         * 
         * skillUserInfo 필드를 이용해 스킬을 실행시킬 주체의 gameObject를 가지고 올 수 있음.
         * ex) Vector3 vehiclePos = skillUserInfo.gameObject.transform.localPosition;
         */
    }
}
