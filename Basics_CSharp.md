### **Basic Theory of C#**

C# (pronounced "C-sharp") is a modern, object-oriented programming language developed by Microsoft. It is part of the .NET framework and is designed to be simple, flexible, and powerful. C# is used for developing a wide range of applications, including web, mobile, desktop, and game development.

Here's a basic overview of C# theory to help you get started:

---

### **1. C# Overview:**

- **Object-Oriented Language**: C# is an object-oriented programming (OOP) language, which means it focuses on organizing code into objects and classes.
- **Type-Safe**: C# is type-safe, meaning the compiler ensures that operations are done on compatible data types, reducing errors at runtime.
- **Managed Code**: C# runs on the .NET Common Language Runtime (CLR), which provides memory management, garbage collection, and other runtime services.
- **Cross-Platform**: With the .NET Core and .NET 5/6+ versions, C# has become a cross-platform language, allowing development for Windows, macOS, and Linux.
  
---

### **2. Key Features of C#:**

#### **2.1. Syntax**:
C# syntax is similar to other C-based languages like C++ and Java. It uses curly braces `{}` to define code blocks and semicolons `;` to terminate statements.

```csharp
Console.WriteLine("Hello, World!"); // A simple statement
```

#### **2.2. Variables and Data Types**:
Variables store data, and each variable has a specific **data type** that defines the kind of data it can hold.

- **Common Data Types**:
  - `int`: Integer values (e.g., 5, -3)
  - `double`: Floating-point numbers (e.g., 3.14)
  - `char`: Single characters (e.g., 'a')
  - `string`: Sequence of characters (e.g., "Hello")
  - `bool`: Boolean values (`true` or `false`)
  
Example:

```csharp
int age = 25;
double temperature = 98.6;
char grade = 'A';
string name = "John Doe";
bool isActive = true;
```

#### **2.3. Constants**:
A **constant** is a value that cannot be changed after it is assigned.

```csharp
const double Pi = 3.14159;
```

#### **2.4. Variables Initialization**:
C# supports both **implicit** and **explicit** variable initialization.

- **Implicit**: The type is inferred by the compiler from the value assigned.
  
```csharp
var number = 10; // The type 'int' is inferred
```

- **Explicit**: You explicitly declare the type of the variable.
  
```csharp
int number = 10; // 'int' type is explicitly declared
```

---

### **3. Control Flow in C#**:

#### **3.1. Conditional Statements**:
- **if-else**: Used to execute code based on a condition.
  
```csharp
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Not an Adult");
}
```

- **switch-case**: A control structure used to handle multiple conditions based on the value of a variable.
  
```csharp
switch (grade)
{
    case 'A':
        Console.WriteLine("Excellent");
        break;
    case 'B':
        Console.WriteLine("Good");
        break;
    default:
        Console.WriteLine("Need Improvement");
        break;
}
```

#### **3.2. Loops**:
C# provides various types of loops to repeat actions based on conditions.

- **for loop**: Used for a known number of iterations.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); // Prints 0, 1, 2, 3, 4
}
```

- **while loop**: Used when the number of iterations is not known in advance.
  
```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```

- **foreach loop**: Used to iterate through collections like arrays or lists.

```csharp
string[] names = { "Alice", "Bob", "Charlie" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
```

---

### **4. Functions (Methods)**:
Functions (or methods) are blocks of code that perform specific tasks. In C#, methods are defined inside classes.

```csharp
public class Program
{
    static void Main(string[] args)
    {
        Greet("John");  // Calling the method
    }

    // A simple method that prints a greeting
    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
```

- **Parameters**: Methods can take **parameters** (inputs) and can **return** values.

```csharp
public int AddNumbers(int a, int b)
{
    return a + b;
}
```

- **Method Overloading**: C# allows you to define multiple methods with the same name but different parameters (number or type of parameters).

```csharp
public void PrintMessage(string message)
{
    Console.WriteLine(message);
}

public void PrintMessage(string message, int times)
{
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine(message);
    }
}
```

---

### **5. Object-Oriented Programming (OOP) Concepts in C#:**

#### **5.1. Classes and Objects**:
A **class** is a blueprint for creating objects (instances). It can have properties (fields) and methods (functions).

```csharp
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    
    public void Start()
    {
        Console.WriteLine("Car is starting...");
    }
}

// Creating an object (instance) of the class
Car myCar = new Car();
myCar.Make = "Toyota";
myCar.Model = "Corolla";
myCar.Start();  // Calling method of the object
```

#### **5.2. Inheritance**:
Inheritance allows one class (subclass/child) to inherit properties and methods from another class (superclass/parent).

```csharp
class Animal
{
    public void Eat() => Console.WriteLine("Eating...");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking...");
}

// Creating an object of subclass
Dog myDog = new Dog();
myDog.Eat();  // Inherited method
myDog.Bark(); // Method of Dog
```

#### **5.3. Encapsulation**:
Encapsulation is the concept of **hiding** the internal details of an object and exposing only what is necessary (through **public methods**). It is often done using **properties** with **get** and **set** methods.

```csharp
class Person
{
    private string name;  // Private field

    public string Name   // Public property
    {
        get { return name; }
        set { name = value; }
    }
}
```

#### **5.4. Polymorphism**:
Polymorphism allows objects of different types to be treated as objects of a common base type. This can be achieved using method overriding or interfaces.

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is speaking");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Dog();
        myAnimal.Speak();  // Outputs "Woof!" (polymorphism in action)
    }
}
```

---

### **6. Exception Handling**:
Exception handling in C# is done using `try`, `catch`, `finally` blocks. It allows you to catch errors and handle them without crashing the application.

```csharp
try
{
    int result = 10 / 0;  // This will throw a DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("This will always run.");
}
```

---

### **7. Collections**:
C# provides several **collections** like arrays, lists, dictionaries, and queues to store and manipulate groups of data.

- **Arrays**: Fixed-size collections of elements.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
```

- **Lists**: Dynamic collections that can grow or shrink.

```csharp
List<int> numbersList = new List<int>();
numbersList.Add(1);
numbersList.Add(2);
```

---

### **Conclusion**:
C# is a versatile language with strong object-oriented principles and modern features. Its combination of simplicity, power, and support for various types of applications makes it a great choice for a wide range of programming tasks.

The key concepts to focus on when learning C# include:
- Basic syntax and data types
- Control flow (if-else, loops)
- Functions (methods) and parameters
- Object-Oriented Programming (classes, inheritance, polymorphism, encapsulation)
- Exception handling
- Collections

Mastering these foundational concepts will set you up for success as you dive deeper into more advanced C# topics!
### **Basic Theory of C#**

C# (pronounced "C-sharp") is a modern, object-oriented programming language developed by Microsoft. It is part of the .NET framework and is designed to be simple, flexible, and powerful. C# is used for developing a wide range of applications, including web, mobile, desktop, and game development.

Here's a basic overview of C# theory to help you get started:

---

### **1. C# Overview:**

- **Object-Oriented Language**: C# is an object-oriented programming (OOP) language, which means it focuses on organizing code into objects and classes.
- **Type-Safe**: C# is type-safe, meaning the compiler ensures that operations are done on compatible data types, reducing errors at runtime.
- **Managed Code**: C# runs on the .NET Common Language Runtime (CLR), which provides memory management, garbage collection, and other runtime services.
- **Cross-Platform**: With the .NET Core and .NET 5/6+ versions, C# has become a cross-platform language, allowing development for Windows, macOS, and Linux.
  
---

### **2. Key Features of C#:**

#### **2.1. Syntax**:
C# syntax is similar to other C-based languages like C++ and Java. It uses curly braces `{}` to define code blocks and semicolons `;` to terminate statements.

```csharp
Console.WriteLine("Hello, World!"); // A simple statement
```

#### **2.2. Variables and Data Types**:
Variables store data, and each variable has a specific **data type** that defines the kind of data it can hold.

- **Common Data Types**:
  - `int`: Integer values (e.g., 5, -3)
  - `double`: Floating-point numbers (e.g., 3.14)
  - `char`: Single characters (e.g., 'a')
  - `string`: Sequence of characters (e.g., "Hello")
  - `bool`: Boolean values (`true` or `false`)
  
Example:

```csharp
int age = 25;
double temperature = 98.6;
char grade = 'A';
string name = "John Doe";
bool isActive = true;
```

#### **2.3. Constants**:
A **constant** is a value that cannot be changed after it is assigned.

```csharp
const double Pi = 3.14159;
```

#### **2.4. Variables Initialization**:
C# supports both **implicit** and **explicit** variable initialization.

- **Implicit**: The type is inferred by the compiler from the value assigned.
  
```csharp
var number = 10; // The type 'int' is inferred
```

- **Explicit**: You explicitly declare the type of the variable.
  
```csharp
int number = 10; // 'int' type is explicitly declared
```

---

### **3. Control Flow in C#**:

#### **3.1. Conditional Statements**:
- **if-else**: Used to execute code based on a condition.
  
```csharp
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Not an Adult");
}
```

- **switch-case**: A control structure used to handle multiple conditions based on the value of a variable.
  
```csharp
switch (grade)
{
    case 'A':
        Console.WriteLine("Excellent");
        break;
    case 'B':
        Console.WriteLine("Good");
        break;
    default:
        Console.WriteLine("Need Improvement");
        break;
}
```

#### **3.2. Loops**:
C# provides various types of loops to repeat actions based on conditions.

- **for loop**: Used for a known number of iterations.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); // Prints 0, 1, 2, 3, 4
}
```

- **while loop**: Used when the number of iterations is not known in advance.
  
```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```

- **foreach loop**: Used to iterate through collections like arrays or lists.

```csharp
string[] names = { "Alice", "Bob", "Charlie" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
```

---

### **4. Functions (Methods)**:
Functions (or methods) are blocks of code that perform specific tasks. In C#, methods are defined inside classes.

```csharp
public class Program
{
    static void Main(string[] args)
    {
        Greet("John");  // Calling the method
    }

    // A simple method that prints a greeting
    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
```

- **Parameters**: Methods can take **parameters** (inputs) and can **return** values.

```csharp
public int AddNumbers(int a, int b)
{
    return a + b;
}
```

- **Method Overloading**: C# allows you to define multiple methods with the same name but different parameters (number or type of parameters).

```csharp
public void PrintMessage(string message)
{
    Console.WriteLine(message);
}

public void PrintMessage(string message, int times)
{
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine(message);
    }
}
```

---

### **5. Object-Oriented Programming (OOP) Concepts in C#:**

#### **5.1. Classes and Objects**:
A **class** is a blueprint for creating objects (instances). It can have properties (fields) and methods (functions).

```csharp
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    
    public void Start()
    {
        Console.WriteLine("Car is starting...");
    }
}

// Creating an object (instance) of the class
Car myCar = new Car();
myCar.Make = "Toyota";
myCar.Model = "Corolla";
myCar.Start();  // Calling method of the object
```

#### **5.2. Inheritance**:
Inheritance allows one class (subclass/child) to inherit properties and methods from another class (superclass/parent).

```csharp
class Animal
{
    public void Eat() => Console.WriteLine("Eating...");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking...");
}

// Creating an object of subclass
Dog myDog = new Dog();
myDog.Eat();  // Inherited method
myDog.Bark(); // Method of Dog
```

#### **5.3. Encapsulation**:
Encapsulation is the concept of **hiding** the internal details of an object and exposing only what is necessary (through **public methods**). It is often done using **properties** with **get** and **set** methods.

```csharp
class Person
{
    private string name;  // Private field

    public string Name   // Public property
    {
        get { return name; }
        set { name = value; }
    }
}
```

#### **5.4. Polymorphism**:
Polymorphism allows objects of different types to be treated as objects of a common base type. This can be achieved using method overriding or interfaces.

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is speaking");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Dog();
        myAnimal.Speak();  // Outputs "Woof!" (polymorphism in action)
    }
}
```

---

### **6. Exception Handling**:
Exception handling in C# is done using `try`, `catch`, `finally` blocks. It allows you to catch errors and handle them without crashing the application.

```csharp
try
{
    int result = 10 / 0;  // This will throw a DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("This will always run.");
}
```

---

### **7. Collections**:
C# provides several **collections** like arrays, lists, dictionaries, and queues to store and manipulate groups of data.

- **Arrays**: Fixed-size collections of elements.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
```

- **Lists**: Dynamic collections that can grow or shrink.

```csharp
List<int> numbersList = new List<int>();
numbersList.Add(1);
numbersList.Add(2);
```

---

### **Conclusion**:
C# is a versatile language with strong object-oriented principles and modern features. Its combination of simplicity, power, and support for various types of applications makes it a great choice for a wide range of programming tasks.

The key concepts to focus on when learning C# include:
- Basic syntax and data types
- Control flow (if-else, loops)
- Functions (methods) and parameters
- Object-Oriented Programming (classes, inheritance, polymorphism, encapsulation)
- Exception handling
- Collections

Mastering these foundational concepts will set you up for success as you dive deeper into more advanced C# topics!
### **Basic Theory of C#**

C# (pronounced "C-sharp") is a modern, object-oriented programming language developed by Microsoft. It is part of the .NET framework and is designed to be simple, flexible, and powerful. C# is used for developing a wide range of applications, including web, mobile, desktop, and game development.

Here's a basic overview of C# theory to help you get started:

---

### **1. C# Overview:**

- **Object-Oriented Language**: C# is an object-oriented programming (OOP) language, which means it focuses on organizing code into objects and classes.
- **Type-Safe**: C# is type-safe, meaning the compiler ensures that operations are done on compatible data types, reducing errors at runtime.
- **Managed Code**: C# runs on the .NET Common Language Runtime (CLR), which provides memory management, garbage collection, and other runtime services.
- **Cross-Platform**: With the .NET Core and .NET 5/6+ versions, C# has become a cross-platform language, allowing development for Windows, macOS, and Linux.
  
---

### **2. Key Features of C#:**

#### **2.1. Syntax**:
C# syntax is similar to other C-based languages like C++ and Java. It uses curly braces `{}` to define code blocks and semicolons `;` to terminate statements.

```csharp
Console.WriteLine("Hello, World!"); // A simple statement
```

#### **2.2. Variables and Data Types**:
Variables store data, and each variable has a specific **data type** that defines the kind of data it can hold.

- **Common Data Types**:
  - `int`: Integer values (e.g., 5, -3)
  - `double`: Floating-point numbers (e.g., 3.14)
  - `char`: Single characters (e.g., 'a')
  - `string`: Sequence of characters (e.g., "Hello")
  - `bool`: Boolean values (`true` or `false`)
  
Example:

```csharp
int age = 25;
double temperature = 98.6;
char grade = 'A';
string name = "John Doe";
bool isActive = true;
```

#### **2.3. Constants**:
A **constant** is a value that cannot be changed after it is assigned.

```csharp
const double Pi = 3.14159;
```

#### **2.4. Variables Initialization**:
C# supports both **implicit** and **explicit** variable initialization.

- **Implicit**: The type is inferred by the compiler from the value assigned.
  
```csharp
var number = 10; // The type 'int' is inferred
```

- **Explicit**: You explicitly declare the type of the variable.
  
```csharp
int number = 10; // 'int' type is explicitly declared
```

---

### **3. Control Flow in C#**:

#### **3.1. Conditional Statements**:
- **if-else**: Used to execute code based on a condition.
  
```csharp
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Not an Adult");
}
```

- **switch-case**: A control structure used to handle multiple conditions based on the value of a variable.
  
```csharp
switch (grade)
{
    case 'A':
        Console.WriteLine("Excellent");
        break;
    case 'B':
        Console.WriteLine("Good");
        break;
    default:
        Console.WriteLine("Need Improvement");
        break;
}
```

#### **3.2. Loops**:
C# provides various types of loops to repeat actions based on conditions.

- **for loop**: Used for a known number of iterations.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); // Prints 0, 1, 2, 3, 4
}
```

- **while loop**: Used when the number of iterations is not known in advance.
  
```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```

- **foreach loop**: Used to iterate through collections like arrays or lists.

```csharp
string[] names = { "Alice", "Bob", "Charlie" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
```

---

### **4. Functions (Methods)**:
Functions (or methods) are blocks of code that perform specific tasks. In C#, methods are defined inside classes.

```csharp
public class Program
{
    static void Main(string[] args)
    {
        Greet("John");  // Calling the method
    }

    // A simple method that prints a greeting
    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
```

- **Parameters**: Methods can take **parameters** (inputs) and can **return** values.

```csharp
public int AddNumbers(int a, int b)
{
    return a + b;
}
```

- **Method Overloading**: C# allows you to define multiple methods with the same name but different parameters (number or type of parameters).

```csharp
public void PrintMessage(string message)
{
    Console.WriteLine(message);
}

public void PrintMessage(string message, int times)
{
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine(message);
    }
}
```

---

### **5. Object-Oriented Programming (OOP) Concepts in C#:**

#### **5.1. Classes and Objects**:
A **class** is a blueprint for creating objects (instances). It can have properties (fields) and methods (functions).

```csharp
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    
    public void Start()
    {
        Console.WriteLine("Car is starting...");
    }
}

// Creating an object (instance) of the class
Car myCar = new Car();
myCar.Make = "Toyota";
myCar.Model = "Corolla";
myCar.Start();  // Calling method of the object
```

#### **5.2. Inheritance**:
Inheritance allows one class (subclass/child) to inherit properties and methods from another class (superclass/parent).

```csharp
class Animal
{
    public void Eat() => Console.WriteLine("Eating...");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking...");
}

// Creating an object of subclass
Dog myDog = new Dog();
myDog.Eat();  // Inherited method
myDog.Bark(); // Method of Dog
```

#### **5.3. Encapsulation**:
Encapsulation is the concept of **hiding** the internal details of an object and exposing only what is necessary (through **public methods**). It is often done using **properties** with **get** and **set** methods.

```csharp
class Person
{
    private string name;  // Private field

    public string Name   // Public property
    {
        get { return name; }
        set { name = value; }
    }
}
```

#### **5.4. Polymorphism**:
Polymorphism allows objects of different types to be treated as objects of a common base type. This can be achieved using method overriding or interfaces.

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is speaking");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Dog();
        myAnimal.Speak();  // Outputs "Woof!" (polymorphism in action)
    }
}
```

---

### **6. Exception Handling**:
Exception handling in C# is done using `try`, `catch`, `finally` blocks. It allows you to catch errors and handle them without crashing the application.

```csharp
try
{
    int result = 10 / 0;  // This will throw a DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("This will always run.");
}
```

---

### **7. Collections**:
C# provides several **collections** like arrays, lists, dictionaries, and queues to store and manipulate groups of data.

- **Arrays**: Fixed-size collections of elements.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
```

- **Lists**: Dynamic collections that can grow or shrink.

```csharp
List<int> numbersList = new List<int>();
numbersList.Add(1);
numbersList.Add(2);
```

---

### **Conclusion**:
C# is a versatile language with strong object-oriented principles and modern features. Its combination of simplicity, power, and support for various types of applications makes it a great choice for a wide range of programming tasks.

The key concepts to focus on when learning C# include:
- Basic syntax and data types
- Control flow (if-else, loops)
- Functions (methods) and parameters
- Object-Oriented Programming (classes, inheritance, polymorphism, encapsulation)
- Exception handling
- Collections

Mastering these foundational concepts will set you up for success as you dive deeper into more advanced C# topics!
