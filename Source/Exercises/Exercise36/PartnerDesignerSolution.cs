using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise36
{
    class RunnerSolution
    {
        public void Run()
        {
            HumanSolution h1 = new HumanSolution(GenderSolution.Male, EyeColorSolution.Brown, HairColorSolution.Black, HeightCategorySolution.Short);
            HumanSolution h2 = new HumanSolution(GenderSolution.Female, EyeColorSolution.Green, HairColorSolution.Blond, HeightCategorySolution.VeryTall);

            Console.WriteLine(h1.GetDescription());
            Console.WriteLine(h2.GetDescription());
        }
    }

    enum GenderSolution { Male, Female };
    enum EyeColorSolution { Green, Blue, Black, Brown };
    enum HairColorSolution { Brown, Black, Blond };
    enum HeightCategorySolution { VeryShort, Short, MediumHeight, Tall, VeryTall };

    class HumanSolution
    {
        private GenderSolution _gender;
        private EyeColorSolution _eyeColor;
        private HairColorSolution _hairColor;
        private HeightCategorySolution _heightCategory;

        public HumanSolution(GenderSolution gender, EyeColorSolution eyeColor, HairColorSolution hairColor, HeightCategorySolution heightCategory)
        {
            _gender = gender;
            _eyeColor = eyeColor;
            _hairColor = hairColor;
            _heightCategory = heightCategory;
        }

        public string GetDescription()
        {
            string description = "You got a " + _gender;
            description = description + ", with " + _eyeColor + " eyes";
            description = description + ", " + _hairColor + " hair";
            description = description + ", who is " + _heightCategory;
            return description;
        }
    }
}
