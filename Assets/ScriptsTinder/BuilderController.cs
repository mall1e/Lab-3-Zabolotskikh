using UnityEngine;
using NG.builder_pattern.example;

public class BuilderController : MonoBehaviour
{
    void Start() // создание билдера
    {
        Tinder tinder = new Tinder();
        CoupleBuilder coupleBuilder = new CoupleBuilder();

        tinder.Construct(coupleBuilder);
        SecondCouple couple = coupleBuilder.couple;
        Debug.Log(couple.GetPartsList()); // вывод выбранных компонентов в консоль
    }

    void Update()
    {

    }
}