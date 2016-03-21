﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceChallenge
{
    public class Vehicle
    {
        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int NumOfGears { get; set; } = 4;
        public int NumOfTires { get; set; } = 4;

        public override string ToString()
        {
            return $"This is a {Make} {Model}";
        }
    }

    [TestClass]
    public class InheritanceChallengeTests
    {
        [TestMethod]
        public void Classes_Inherit()
        {
            Assert.IsTrue(typeof(ElectricCar).IsSubclassOf(typeof(Vehicle)));
            Assert.IsTrue(typeof(Motorcycle).IsSubclassOf(typeof(Vehicle)));
        }

        [TestMethod]
        public void Vehicles_Describe_Themselves()
        {
            var truck = new ElectricCar("Nissan", "Leaf");
            Assert.AreEqual("This is a Nissan Leaf", truck.ToString());

            var motorcycle = new Motorcycle("Honda", "CTX700N");
            Assert.AreEqual("This is a Honda CTX700N", motorcycle.ToString());
        }


        [TestMethod]
        public void Correct_Number_Of_Gears()
        {
            var truck = new ElectricCar("Nissan", "Leaf");
            Assert.AreEqual(1, truck.NumOfGears);

            var motorcycle = new Motorcycle("Honda", "CTX700N");
            Assert.AreEqual(4, motorcycle.NumOfGears);
        }

        [TestMethod]
        public void Correct_Number_Of_Tires()
        {
            var truck = new ElectricCar("Nissan", "Leaf");
            Assert.AreEqual(4, truck.NumOfTires);

            var motorcycle = new Motorcycle("Honda", "CTX700N");
            Assert.AreEqual(2, motorcycle.NumOfTires);
        }


        [TestMethod]
        public void Trike_Creation()
        {
            Assert.IsTrue(typeof(Trike).IsSubclassOf(typeof(Motorcycle)));

            var trike = new Trike("Can-Am", "Spyder");
            Assert.AreEqual(3, trike.NumOfTires);
        }

        
    }


}

