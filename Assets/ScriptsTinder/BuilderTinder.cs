using UnityEngine;

namespace NG.builder_pattern.example
{
    class CoupleBuilder : MyLoveBuilder
    {
        private SecondCouple _couple;
        public SecondCouple couple
        {
            get
            {
                return _couple;
            }
        }

        public CoupleBuilder()
        {
            _couple = new SecondCouple(CoupleType.Couple);
        }


        // объявление компонентов

        public void BuildHandsome()
        {
            GameObject handsome = _couple.MakePart("handsome");
            _couple.AddPart(handsome);
        }

        public void BuildSmart()
        {
            GameObject smart = _couple.MakePart("smart");
            _couple.AddPart(smart);
        }
        public void BuildYoung()
        {
            GameObject young = _couple.MakePart("young");
            _couple.AddPart(young);
        }
        public void BuildRich()
        {
            GameObject rich = _couple.MakePart("rich");
            _couple.AddPart(rich);
        }
        public void BuildCharismatic()
        {
            GameObject charismatic = _couple.MakePart("charismatic");
            _couple.AddPart(charismatic);
        }
        public void BuildNotJealous()
        {
            GameObject notJealous = _couple.MakePart("not jealous");
            _couple.AddPart(notJealous);
        }
        public void BuildPurposeful()
        {
            GameObject purposeful = _couple.MakePart("purposeful");
            _couple.AddPart(purposeful);
        }
        public void BuildGoodCooking()
        {
            GameObject goodCooking = _couple.MakePart("good cooking");
            _couple.AddPart(goodCooking);
        }
        public void BuildGoodTallking()
        {
            GameObject goodTallking = _couple.MakePart("good tallking");
            _couple.AddPart(goodTallking);
        }
        public void BuildGoodProgramming()
        {
            GameObject goodProgramming = _couple.MakePart("good programming");
            _couple.AddPart(goodProgramming);
        }
        public void BuildPlayVideoGames()
        {
            GameObject playVideoGames = _couple.MakePart("play video games");
            _couple.AddPart(playVideoGames);
        }
    }
}