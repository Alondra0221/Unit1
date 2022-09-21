using System;
namespace Cars
{
    internal class Register
    {
        private static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.code = 01;
            person1.age = 18;
            person1.name = "Sebastian";
            person1.surname = "Ramirez";
            person1.gender = "Male";
            person1.suspiciosFraud = false;


            License license1 = new License();
            license1.codeP = person1.code;
            license1.initial = new DateTime(2015 , 12 , 01);
            license1.expiration = new DateTime(2018,12,01);
            license1.status = "Active";
            license1.type = "A";

            //License license8 = new License();
            //license8.codeP = person1.code;
            //license8.initial = new DateTime(2020, 12, 01);
            //license8.expiration = new DateTime(2024, 12, 01);
            //license8.status = "Active";
            //license8.type = "A";


            Vehicle vehicle1= new Vehicle();
            vehicle1.type = license1.type;
            vehicle1.year = 2022;
            vehicle1.brand = "Ford";
            vehicle1.description = "Automovil";
            vehicle1.wheels = 4;
            vehicle1.color = "Whith";

            License license2 = new License();
            license2.codeP = person1.code;
            license2.initial = new DateTime(2019 ,12 , 01);
            license2.expiration = new DateTime(2022, 12, 01);
            license2.status = "Active";
            license2.type = "B";

            Vehicle vehicle2 = new Vehicle();
            vehicle2.type = license2.type;
            vehicle2.year = 2022;
            vehicle2.brand = "Toyota";
            vehicle2.description = "Camion";
            vehicle2.wheels = 4;
            vehicle2.color = "Red";

            License license3 = new License();
            license3.codeP = person1.code;
            license3.initial = new DateTime(2020 , 12 , 01);
            license3.expiration = new DateTime(2023, 12, 01);
            license3.status = "Active";
            license3.type = "c";

            Vehicle vehicle3 = new Vehicle();
            vehicle3.type = license3.type;
            vehicle3.year = 2022;
            vehicle3.brand = "Ford";
            vehicle3.description = "Autobus";
            vehicle3.wheels = 8;
            vehicle3.color = "Blue";


            Vehicle vehicle4 = new Vehicle();
            vehicle4.type = license1.type;
            vehicle4.year = 2022;
            vehicle4.brand = "Toyota";
            vehicle4.description = "Camioneta";
            vehicle4.wheels = 4;
            vehicle4.color = "Blue";

            Vehicle vehicle5 = new Vehicle();
            vehicle5.type = license2.type;
            vehicle5.year = 2022;
            vehicle5.brand = "Toyota";
            vehicle5.description = "Camion";
            vehicle5.wheels = 6;
            vehicle5.color = "Green";

            Vehicle vehicle6 = new Vehicle();
            vehicle6.type = license3.type;
            vehicle6.year = 2022;
            vehicle6.brand = "Ford";
            vehicle6.description = "Camion";
            vehicle6.wheels = 8;
            vehicle6.color = "Black";

            //Another person

            Person person2 = new Person();
            person2.code = 01;
            person2.age = 18;
            person2.name = "Ari";
            person2.surname = "Martinez";
            person2.gender = "Female";
            person2.suspiciosFraud = false;


            License license4 = new License();
            license4.codeP = person2.code;
            license4.initial = new DateTime(2020 , 12 , 01);
            license4.expiration = new DateTime(2025, 12, 01);
            license4.status = "Active";
            license4.type = "A";


            Vehicle vehicle7 = new Vehicle();
            vehicle7.type = license4.type;
            vehicle7.year = 2022;
            vehicle7.brand = "Audi";
            vehicle7.description = "Automovil";
            vehicle7.wheels = 4;
            vehicle7.color = "Yellow";


            person1.addLicense(license1);
            person1.addCar(vehicle1);
            //person1.addLicense(license8);

            person1.addCar(vehicle2);
            person1.addLicense(license2);

            person1.addCar(vehicle3);
            person1.addLicense(license3);

            person1.addCar(vehicle4);
            person1.addCar(vehicle5);
            person1.addCar(vehicle6);

            person2.addLicense(license4);
            person2.addCar(vehicle7);



            person1.checkSupiciosFraud();
            //person1.cancelCar(vehicle2.type);


            person2.checkSupiciosFraud();


        }


    }
}

