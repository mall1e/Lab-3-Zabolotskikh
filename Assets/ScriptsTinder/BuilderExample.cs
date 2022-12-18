using UnityEngine;
using System.Collections.Generic;

namespace NG.builder_pattern.example
{
    
    class Tinder
    {
        public void Construct(MyLoveBuilder myloveBuilder) // наполнение рандомными компонентами 
        {
            
            int[] array = new int[11];
            for(int i = 0; i < 11; i++)
            {
                array[i] = Random.Range(0, 2);
            }
            
            if (array[0] == 1) myloveBuilder.BuildHandsome();
            if (array[1] == 1) myloveBuilder.BuildSmart();
            if (array[2] == 1) myloveBuilder.BuildYoung();
            if (array[3] == 1) myloveBuilder.BuildRich();
            if (array[4] == 1) myloveBuilder.BuildCharismatic();
            if (array[5] == 1) myloveBuilder.BuildNotJealous();
            if (array[6] == 1) myloveBuilder.BuildPurposeful();
            if (array[7] == 1) myloveBuilder.BuildGoodCooking();
            if (array[8] == 1) myloveBuilder.BuildGoodTallking();
            if (array[9] == 1) myloveBuilder.BuildGoodProgramming();
            if (array[10] == 1) myloveBuilder.BuildPlayVideoGames();
        }
    }

    interface MyLoveBuilder // содание интерфейса для компонентов
    {
        SecondCouple couple { get; }

        void BuildHandsome();
        void BuildSmart();
        void BuildYoung();
        void BuildRich();
        void BuildCharismatic();
        void BuildNotJealous();
        void BuildPurposeful();
        void BuildGoodCooking();
        void BuildGoodTallking();
        void BuildGoodProgramming();
        void BuildPlayVideoGames();
    }

    enum CoupleType { Couple }
    class SecondCouple
    {
        public CoupleType coupleType { get; private set; }
        public GameObject parent { get; private set; }
        private List<GameObject> _parts = new List<GameObject>();

        public SecondCouple(CoupleType coupleType)
        {
            this.coupleType = coupleType;
            parent = new GameObject(coupleType.ToString());
        }

        public void AddPart(GameObject part) // добавление компонентов в массив
        {
            _parts.Add(part);
        }

        public string GetPartsList() // добавление компонентов для вывода в консоль
        {
            string partsList = coupleType.ToString() + " parts:\n\t";
            foreach (GameObject part in _parts)
            {
                partsList += part.name + " ";
            }
            return partsList;
        }

        public GameObject MakePart(string name) // создание компонента
        {
            GameObject go = new GameObject();
            go.name = name;
            return go;
        }
    }



}