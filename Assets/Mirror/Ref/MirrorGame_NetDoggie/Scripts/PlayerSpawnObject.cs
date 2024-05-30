using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.AI;

public class PlayerSpawnObject : NetworkBehaviour
{
    [Header("Components")]
    public NavMeshAgent NavAgent_Player;
    public Animator Animator_Player;
    public TextMesh TextMesh_HealthBar;
    public TextMesh TextMesh_NetType;
    public Transform Transform_Player;
    [Header("Movement")]
    public float _ratationSpeed = 100.0f;  // _ ������ �������� ����ִ� �� 

    [Header("Attack")]
    public KeyCode _atkKey = KeyCode.Space;
    public GameObject Prefab_AtkObject;
    public Transform Transform_AtkSpawnPos;

    [Header("Stats Server")]
    [SyncVar] public int _health = 4;

    public void Update()
    {
        SetHealthBarOnUpdate(_health);
        if (CheckIsFocusedOnUpdate() == false)
            return;
        CheckIsLocalPlayerOnUpdate();
    }
    private void SetHealthBarOnUpdate(int health)
    {
        TextMesh_HealthBar.text = new string('-', health);//������ ���ͼ��ͷ� �Ѵٰ� �� 
    }
    bool CheckIsFocusedOnUpdate()
    {
        return Application.isFocused;
    }
    void CheckIsLocalPlayerOnUpdate()
    {

    }
    //Ŭ�󿡼� ������ ȣ���� ������ ������ ������ ��������Ʈ �¸�
    [Command]

    private void CommandAtk()
    {

    }

    [ClientRpc]
    private void RpcOnAtk()
    {

    }
    //Ŭ�󿡼� �����Լ��� ������� �ʵ��� ServerCallback�� �޾���
    [ServerCallback]
    //Ŭ�󿡼� �����Լ��� ������� �ʵ��� ServerCallback�� �޾���
    private void OnTriggerEnter(Collider other) //���� Ŭ�� �Ѵ� �ҷ��� �� �־ Ŭ�󿡼��� ������� �ʵ��� �ϱ� ����
    {
        
    }


}
