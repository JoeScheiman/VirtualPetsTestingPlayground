using System;
using VirtualPetsAmok;
using Xunit;

namespace VirtualpetsAmok.Tests
{
    public class PetTests
    {
        [Fact]
        public void Create_Pet()
        {
            //Create Pet
            VirtualPet pet = new VirtualPet();
        }
        [Fact]
        public void Pet_Name()
        {
            //Create Pet Name
            VirtualPet pet = new VirtualPet
            {
                Name = "Sparky"
            };

            Assert.Equal("Sparky", pet.Name);
        }
        [Fact]
        public void Pet_Age()
        {
            //Create Pet Age
            VirtualPet pet = new VirtualPet
            {
                Age = 7
            };

            Assert.Equal(7, pet.Age);
        }
        [Fact]
        public void Pet_Fullness()
        {
            //Create Pet Fullness Level (will be 1 through 10)
            VirtualPet pet = new VirtualPet();

            //pet.Fullness = 4;

            Assert.Equal(5, pet.Fullness);
        }
        [Fact]
        public void Pet_Species()
        {
            //Create Pet Species
            VirtualPet pet = new VirtualPet
            {
                Species = "kitty",
                Name = "Sam"
            };

            Assert.Equal("kitty", pet.Species);
            Assert.Equal("Sam", pet.Name);
        }
        [Fact]
        public void Pet_Happiness()
        {
            //Create Pet Happiness Level (will be 1 through 10)
            VirtualPet pet = new VirtualPet();

            //default Happiness is 5

            Assert.Equal(5, pet.Happiness);
        }
        [Fact]
        public void Pet_Energy()
        {
            //Create Pet Energy Level (will be 1 through 10)
            VirtualPet pet = new VirtualPet();

            //default Energy is 5

            Assert.Equal(5, pet.Energy);
        }
        [Fact]
        public void Pet_Time_Increment()
        {
            VirtualPet pet = new VirtualPet();

            pet.TimeIncrement();

            Assert.Equal(4, pet.Energy);
            Assert.Equal(4, pet.Happiness);
            Assert.Equal(4, pet.Fullness);
        }
        [Fact]
        public void Pet_Feed_A_Pet()
        {
            VirtualPet pet = new VirtualPet
            {
                Fullness = 5
            };

            //Feeding a pet adds 3 to Fullness
            pet.Feed();

            Assert.Equal(10, pet.Fullness);
        }
        [Fact]
        public void Pet_Play_With_Pet()
        {
            VirtualPet pet = new VirtualPet
            {
                Happiness = 5
            };

            //Playing with a pet adds 3 to Happiness
            pet.Play();

            Assert.Equal(10, pet.Happiness);
        }
        [Fact]
            
            public void Pet_Nap_A_Pet()
        {
            VirtualPet pet = new VirtualPet
            {
                Energy = 5
            };

            //napping a pet adds 3 to Energy
            pet.Nap();

            Assert.Equal(10, pet.Energy);
        }
        /* [Fact]

         public void Shelter_Is_Empty()
        {
            Shelter xxx = new Shelter();
            Assert.Empty(xxx.Pets);

        }*/
       [Fact]
        public void Pet_Is_Added()
        {
            var xxx = new Shelter();
            var billy = new VirtualPet();
            xxx.AddPet(billy);
            Assert.NotEmpty(xxx.Pets);
        }
        /*[Fact]
         public void Pet_Is_Removed()
         {
             var xxx = new Shelter();
             var bob = new VirtualPet();
             xxx.AddPet(bob);
             xxx.RemovePet(0);
             Assert.Empty(xxx.Pets);
         }*/
        [Fact]

        public void Pet_Check_Animal_Type()
        {
            VirtualPet pet = new VirtualPet
            {
                Energy = 5,
                
                
            };

            //napping a pet adds 3 to Energy
            pet.Nap();

            Assert.Equal(10, pet.Energy);
        }
    }
}
