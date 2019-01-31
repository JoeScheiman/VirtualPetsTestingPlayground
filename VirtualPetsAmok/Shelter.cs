using System.Collections.Generic;

namespace VirtualPetsAmok
{
    public class Shelter
    {
        public List<VirtualPet> Pets { set; get; }

        public Shelter()
        {
            Pets = new List<VirtualPet>();

            Pets.Add(new VirtualPet("Dog", "Buster", 3));
            Pets.Add(new VirtualPet("Cat", "Billy", 7));
            Pets.Add(new VirtualPet("Cat", "Dexter", 2));
        }
        
        public void AddPet(VirtualPet aPet)
        {
            Pets.Add(aPet);
        }
 
        public void RemovePet(int n)
        {
            Pets.RemoveAt(n);
        }
        public string GetShelterPet(int n)
        {
            string s = "";
            s += Pets[n].Name.PadRight(12);
            s += Pets[n].Species.PadRight(12);
            s += Pets[n].Age.ToString().PadRight(4);
            return (s);
            //s += Pets[n].Name.PadRight(12);
            //s += Pets[n].Name.PadRight(12);
        }
    }
    
}
