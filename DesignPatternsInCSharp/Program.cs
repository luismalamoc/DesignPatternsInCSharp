﻿// See https://aka.ms/new-console-template for more information
using AnimalShallow = DesignPatternsInCSharp.DesignPatterns.PrototypeShallow;
using AnimalDeep = DesignPatternsInCSharp.DesignPatterns.PrototypeDeep;
using DesignPatternsInCSharp.DesignPatterns.Singleton;
using DesignPatternsInCSharp.DesignPatterns.FactoryMethod;
using DesignPatternsInCSharp.DesignPatterns.Strategy;

//Console.WriteLine("---BEGIN SINGLETON---");
//Console.WriteLine(SingletonExample.Instance.message);
//SingletonExample.Instance.message = "Hello Mars";
//Console.WriteLine(SingletonExample.Instance.message);
//Console.WriteLine("---END SINGLETON---");

//Console.WriteLine("---BEGIN PROTOTYPE SHALLOW---");
//AnimalShallow.Animal oAnimal = new AnimalShallow.Animal() { Name="Dolly sheep", Legs=4 };
//AnimalShallow.Animal oAnimalClone = oAnimal.Clone() as Animal;
//oAnimalClone.Legs = 5;
//Console.WriteLine(oAnimal.Legs);
//Console.WriteLine("---END PROTOTYPE SHALLOW---");

//Console.WriteLine("---BEGIN PROTOTYPE DEEP---");
//AnimalDeep.Animal oAnimal = new AnimalDeep.Animal() { Name = "Dolly", Legs = 4 };
//AnimalDeep.Characteristics characteristics = new AnimalDeep.Characteristics();
//characteristics.Color = "White";
//characteristics.Breed = "sheep";
//oAnimal.Characteristics = characteristics;
//AnimalDeep.Animal oAnimalClone = oAnimal.Clone() as AnimalDeep.Animal;
//oAnimalClone.Characteristics.Color = "Black";
//oAnimalClone.Name = "Black";
//Console.WriteLine("Original " + oAnimal.Name);
//Console.WriteLine("Cloned " + oAnimalClone.Name);
//Console.WriteLine("Original " + oAnimal.Characteristics.Color);
//Console.WriteLine("Cloned " + oAnimalClone.Characteristics.Color);
//Console.WriteLine("---END PROTOTYPE DEEP---");

//Console.WriteLine("---BEGIN FACTORY METHOD---");
//var drink = BeverageMaker.make(BeverageMaker.BEER);
//Console.WriteLine(drink.HowMuchItIntoxicatesMe());
//Console.WriteLine("---END FACTORY METHOD---");

//Console.WriteLine("---BEGIN STRATEGY---");
//var context = new DrunkenStrategiesContext();
//context.Seduce(DrunkenBehaviorsEnum.EyeWinking);
//context.Seduce(DrunkenBehaviorsEnum.InviteABeer);
//context.Seduce(DrunkenBehaviorsEnum.PutOnAGallantFace);
//Console.WriteLine("---END STRATEGY---");