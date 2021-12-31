using System;
using System.Collections.Generic;

namespace UnityLessonCsharpClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();
            creature.Breath();

            Person person = new Person();
            person.Breath();

            Dog dog = new Dog();
            dog.Breath();

            Yellowman yellowman1 = new Yellowman();
            Blackman blackman1 = new Blackman();
            Whiteman whiteman1 = new Whiteman();

            yellowman1.TwoLeggedWalker();
            blackman1.TwoLeggedWalker();
            whiteman1.TwoLeggedWalker();

            iTweoLeggedWalker yellowman1_iTwoLeggedWalker = yellowman1;
            iTweoLeggedWalker blackman1_iTwoLeggedWalker = blackman1;
            iTweoLeggedWalker whiteman1_iTwoLeggedWalker = whiteman1;

            List<iTwoLeggedWalker> List_TwoLeggedWalker = new List<iTwoLeggedWalker>();
            list_TwoLeggedWalker.Add(yellowman1_iTwoLeggedWalker);
            list_TwoLeggedWalker.Add(blackman1_iTwoLeggedWalker);
            list_TwoLeggedWalker.Add(whiteman1_iTwoLeggedWalker);

            foreach(iTwoLeggedWalker twoLeggedWalker in list_TwoLeggedWalker)
            {
                twoLeggedWalker.TwoLeggedWalk();
            }
        }
    }
}
