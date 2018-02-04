# Abstraction Refresh Project

The notes are divided in two parts
- Implemented Step Description
- Some Sweet Theory

## Implemented Step Description

**Class Model**

- BankAccount.cs (base class //LD STEP0)
  - SavingsAccount : BankAccount

- AbstractBankAccount (abstract)
  printAccountSentence (abstract member)
  getAccountSentence (virtual member)
  - DebitAccountFromAbstractBankAccount : AbstractBankAccount 
  - SavingsAccountFromAbstractBankAccount : AbstractBankAccount

**Steps**

- //LD STEP0 -> base class definition for all Bank Accounts
- //LD STEP1 -> declare inheriting class
- //LD STEP3 -> definition of abstract class containing and abstract and a virtual method.
- //LD STEP4 -> inheriting from abstract class
- //LD STEP5 -> inheriting from abstract class


## Some Sweet Theory 

**INHERITANCE**

The concept of inheritance brings something of a real-world view to programming. It allows a class to be defined which has a number of characteristics and then other classes to be created which are derived from that class. The derived class inherits all of the features of the parent class and typically then adds some features of its own. By deriving classes we create what is often referred to as a class hierarchy. The class at the top of the hierarchy is known as the base class and the derived classes as subclasses. Any number of classes may be derived from a class. It is only possible for a derived class to inherit from one class. As such, C# is known as a single inheritance programming language. Classes need not only be derived from a base class. For example, a subclass can also inherit from another subclass.

**INTERFACES**

In an interface all the members are implicitly abstract and all the members of the interface must override to its derived class. Interfaces are even more conceptual than abstract classes, since no method bodies are allowed at all. So an interface is kind of like an abstract class with nothing but abstract methods, and since there are no methods with actual code, there is no need for any fields. Properties are allowed though, as well as indexers and events. You can consider an interface as a contract - a class that implements it is required to implement all of the methods and properties. However, the most important difference is that while C# doesn't allow multiple inheritance, where classes inherit more than a single base class, it does in fact allow for implementation of multiple interfaces! Access modifiers in interfaces are public by default. To be honest, you can go a long way without needing an abstract class, but they are great for specific things, like frameworks, which is why you will find quite a bit of abstract classes within the .NET framework it self. A good rule of thumb is that the name actually makes really good sense - abstract classes are very often, if not always, used to describe something abstract, something that is more of a concept than a real thing.

**ABSTRACT CLASS**

Abstract class is a special type of class which cannot be instantiated and acts as a base class for other classes. Abstract class members marked as abstract must be implemented by derived classes. The purpose of an abstract class is to provide basic or default functionality as well as common functionality that multiple derived classes can share and override. An Abstract method must be implemented in the non-Abstract class using the override keyword. After overriding the abstract method is in the non-Abstract class. We can derive this class in another class and again we can override the same abstract method with it. This is a great way to create a base class for something, while still maintaining a certain amount of control of what the subclasses should be able to do.

**ABSTRACT MEMBERS**

A C# abstract class contains abstract members which define what a subclass should contain. These abstract members only declare that a member of a particular type is required, it does not implement the member. Implementation of abstract members takes place within the derived class. A subclass which derives from an abstract class and fails to implement abstract methods will fail to compile. Abstract methods are only allowed within abstract classes

**DIFFERENCE BETWEEN ABSTRACT AND VIRTUAL MEMBERS**

So far we have only looked at abstract class members. As discussed above an abstract member is not implemented in the base class and must be implemented in derived classes in order for the class to compile. Another type of member is a virtual member. A member defined as virtual must be implemented in the base class, but may be optionally overriden in the derived class if different behavior is required.

**FEATURES**

An abstract calss can inherit from a class and one or more interfaces. An abstract class can implement code with non-Abstract methods. An Abstract class can have modifiers for methods, properties etc. An Abstract class can have constants and fields. An abstract class can implement a property. An abstract class can have constructors or destructors. An abstract class cannot be inherited from by structures. An abstract class cannot support multiple inheritance. An abstract class cannot be a sealed class An abstract method cannot be private. An abstract method cannot have the modifier virtual. Because an abstract method is implicitly virtual.

**DESIGN GUIDELINES FOR ABSTRACT CLASS**

- Don't define public constructors within abstract class. Since abstract class cannot be instantiate and constructors with public access modifiers provides visibility to the classes which can be instantiated. 
- Define a protected or an internal constructor within an abstract class. Since a protected constructor allows the base class to do its own initialization when sub-classes are created and an internal constructor can be used to limit concrete implementations of the abstract class to the assembly which contains that class.

**WHEN TO USE**

Need to create multiple versions of your component since versioning is not a problem with abstract class. You can add properties or methods to an abstract class without breaking the code and all inheriting classes are automatically updated with the change.
Need to to provide default behaviors as well as common behaviors that multiple derived classes can share and override.
