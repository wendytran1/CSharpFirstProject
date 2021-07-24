﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie(); //now I have a new Cookie object
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Car,
                Make = "Honda",
                Model = "Civic"
            };
        }
    }
}
