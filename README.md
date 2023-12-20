# Inheritance

In Javascript, every array you ever created has methods like `.map()`, `.filter()`, & `.forEach()`, but you didn't write those methods so how are they part of every array?

The answer is inheritance. JavaScript has a kind of inheritance called prototypal inheritance ([check out Steve's keynote slide deck](https://stevebrownlee.keybase.pub/OLOO/assets/player/KeynoteDHTMLPlayer.html#0)). [Classical Inheritance](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance) 🏛 in C# looks and acts different, but has a very similar effect to how it acts in JavaScript.

It might be helpful to familiarize yourself with [JavaScript inheritance](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Inheritance_and_the_prototype_chain) as well.
These [first 4 articles](https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Objects/Basics) look helpful and in depth.

## Inheritance

Inheritance is for defining straightforward `is-a` relationships. When you have many types in your system, and you discover that several of them share the same properties and/or behaviors, you may want to consider designing an inheritance system.

Consider that you are building software to keep track of sporting equipment. You find yourself defining classes for baseballs, soccer balls, footballs, golf balls, softballs, etc.

After defining each class, you discover that you have defined the same properties on each one. For example:

1. Weight
2. Radius
3. Material

These are properties that **all of them** have in common. You can design your system so that each specific type inherits those properties from a parent class.

```csharp
/*
    This parent class will contain properties that
    are common across all of the specific kinds of
    balls in our program.
*/
class Ball
{
    public double radius { get; set; }
    public double weight { get; set; }
}

/*
    By putting `: Ball` after the definition of
    Baseball, any object created from this class
    would automatically have the two properties of
    radius and weight.
*/
class Baseball : Ball
{
    // Stitches is not common to every kind of ball
    public int stitches { get; set; }
}

// All soccer balls will also have radius and weight
class SoccerBall : Ball
{
    // Panels is not common to every kind of ball
    public int panels { get; set; }
}
```

Inheritance is a mechanism in which a single object obtains properties and methods from 1, or more, parent class. In software, we also deal with situations in which two distinct, separate objects have a relationship with each other. 

### Composition

Composition is for things that make up other things. If the container object is destroyed, so will all of its composing parts. The composition pattern describes objects that are made up of other objects, and are tightly coupled, instead of existing independently of each other.  Composition is based on a `has-a` relationship instead of an `is-a` relationship

Consider the human body. It is composed of many individual parts that can be defined separately, but canot exist separately from each other.

```csharp
class Pancreas
{    
	public bool filtering { get; set; }
}

class Liver
{    
	public bool poisoned { get; set; }
}

class Body
{    
/*Making these private. Don't want anyone messing around with my liver and pancreas    */    
	private Pancreas _pancreas;    
  private Liver _liver;    
	public Body ()    
	{        
		// Create a brand new pancreas and assign it to this body        
		_pancreas = new Pancreas(){ filtering = true }; 
    // Create a brand new liver and assign it to this body        
		_liver = new Liver(){ poisoned = false };
  }
}
```

### Aggregation

Aggregation is for adding objects that are needed for the operation of another object, but both of the objects in the relationship can exist without the other. Consider the relationship between a bank and its customers.

When a bank closes, it doesn’t kill the customers. They continue to live happy lives using another bank. Likewise, if a customer dies, the bank doesn’t go out of business. It just finds different customers.

A customer `has-a` bank. A bank `has-a` customer. Well, hopefully many customers.

This scenario is aggregation.

```csharp
using System;
using System.Collections.Generic;

class Customer {
  public string AccountNumber {
    get;
    set;
  }
  public string FirstName {
    get;
    set;
  }
  public string LastName {
    get;
    set;
  }
}

class Bank {
  public string Name {get;set;}
  public string Address {get;set;} // Customers are aggregated into the bank    
  public List<Customer> Customers {get;set;} = new List<Customer>();
}

class Program {
  public static void Main() {
    // Create a bank        
    var FirstTennessee = new Bank() {
      Name = "First Tennessee",
      Address = "100 Infinity Way"
    };
    
		// Create a customer        
    var steve = new Customer();
    steve.FirstName = "Steve";
    steve.LastName = "Brownlee";
    steve.AccountNumber = "110405821101"; // Add Steve to First Tennessee's list of customers    
    
		FirstTennessee.Customers.Add(steve); // Add another customer using in-line, concise syntax        
    
		FirstTennessee.Customers.Add(new Customer() {
      FirstName = "Caitlin",
      LastName = "Stein",
      AccountNumber = "0592382394589"
    });

    // Iterate over the list of customers and display the first name 
    foreach(Customer cust in FirstTennessee.Customers) {
      Console.WriteLine(cust.firstName);
    }
  }
}
```

## Abstract classes

[Abstract classes](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract) can only be inherited from and cannot be instantiated (with the `new` keyword). They are meant to serve as a base class to a series of related things that may want to share functionality.

You can also add the `abstract` keyword to methods inside
of an abstract class if you only want to define the method signature,
but you don't want to define any functionality at that time. When you
define the functionality in the inheriting class, you will use the `override` keyword in front of the method signature.

Even if you want to provide an implementation, but still allow
inheriting classes to override the functionality, then you will use the `virtual` keyword in front fo the method signature.
