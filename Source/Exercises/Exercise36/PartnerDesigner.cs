using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise36
{
    class Runner
    {
        public void Run()
        {
            Human h1 = new Human(true, "Brown", "Black", 1);
            Human h2 = new Human(false, "White", "Blue", 4);
            Human h3 = new Human(true, "Blond", "Green", 8);

            Console.WriteLine(h1.GetDescription());
            Console.WriteLine(h2.GetDescription());
            Console.WriteLine(h3.GetDescription());
        }
    }

    class Human
    {
        private bool _maleOrFemale;
        private string _eyeColor;
        private string _hairColor;
        private int _heightCategory;

        public Human(bool maleOrFemale, string eyeColor, string hairColor, int heightCategory)
        {
            _maleOrFemale = maleOrFemale;
            _eyeColor = eyeColor;
            _hairColor = hairColor;
            _heightCategory = heightCategory;
        }

        public string GetDescription()
        {
            string description = "You got a " + GetGenderDescription();
            description = description + ", with " + _eyeColor + " eyes";
            description = description + ", " + _hairColor + " hair";
            description = description + ", who is " + GetHeightDescription();
            return description;
        }

        public string GetGenderDescription()
        {
            return _maleOrFemale ? "man" : "woman";
        }

        public string GetHeightDescription()
        {
            switch (_heightCategory)
            {
                case 0: return "Very short";
                case 1: return "Short";
                case 2: return "Medium height";
                case 3: return "Tall";
                case 4: return "Very tall";
                default: return "Unknown height";
            }
        }
    }
}
