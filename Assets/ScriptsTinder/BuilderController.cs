using UnityEngine;
using NG.builder_pattern.example;

public class BuilderController : MonoBehaviour
{
    void Start() // �������� �������
    {
        Tinder tinder = new Tinder();
        CoupleBuilder coupleBuilder = new CoupleBuilder();

        tinder.Construct(coupleBuilder);
        SecondCouple couple = coupleBuilder.couple;
        Debug.Log(couple.GetPartsList()); // ����� ��������� ����������� � �������
    }

    void Update()
    {

    }
}