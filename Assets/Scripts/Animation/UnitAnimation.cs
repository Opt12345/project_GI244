using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    
    private Animator anim;
    private Unit unit;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        unit = GetComponent<Unit>();
    }
    
    void Update()
    {
        ChooseAnimation(unit);
    }
    
    private void ChooseAnimation(Unit u)
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsMove", false);
        anim.SetBool("IsAttack", false);
        anim.SetBool("IsBuilding", false);
        anim.SetBool("IsMoveToResource", false);
        anim.SetBool("IsGather", false);


        switch (u.State)
        {
            case UnitState.Idle:
                anim.SetBool("IsIdle", true);
                break;
            case UnitState.Move:
                anim.SetBool("IsMove", true);
                break;
            case UnitState.Attack:
                anim.SetBool("IsAttack", true);
                break;
            case UnitState.MoveToBuild:
                anim.SetBool("IsMove", true);
                break;
            case UnitState.BuildProgress:
                anim.SetBool("IsBuilding", true);
                break;
            case UnitState.MoveToResource:
                anim.SetBool("IsMoveToResource", true);
                break;
            case UnitState.Gather:
                anim.SetBool("IsGather", true);
                break;
        }
    }
    
}
