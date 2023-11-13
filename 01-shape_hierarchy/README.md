# Shape Hierarchy in C#

## Objective
This programming task is designed to assess understanding of object-oriented programming concepts in C#. Participants are expected to implement a hierarchy of shape classes, demonstrating principles like encapsulation, inheritance, polymorphism, and the use of access modifiers.

## Task Instructions

### Base Class - Shape
Create a base class `Shape` with the following specifications:

#### Properties
- `Name` (string): The name of the shape.

#### Methods
- `CalculateArea()` (virtual method): Should be overridden by derived classes to calculate the area of the shape. This method returns the area as a double.

### Derived Classes
Extend the `Shape` class with the following derived classes:

#### Circle
##### Properties
- `Radius` (double): The radius of the circle.

##### Methods
- Override the `CalculateArea()` method to calculate and return the area of the circle using the formula: Area = π * Radius^2.

#### Rectangle
##### Properties
- `Width` (double): The width of the rectangle.
- `Height` (double): The height of the rectangle.

##### Methods
- Override the `CalculateArea()` method to calculate and return the area of the rectangle using the formula: Area = Width * Height.

#### Triangle
##### Properties
- `Base` (double): The length of the base of the triangle.
- `Height` (double): The height of the triangle.

##### Methods
- Override the `CalculateArea()` method to calculate and return the area of the triangle using the formula: Area = (Base * Height) / 2.

### Utility Method
- Implement a method `PrintShapeArea()` that takes a `Shape` object as a parameter and prints its name and area. This should leverage polymorphism to handle various shapes.

### Demonstration
In the `Main` method:
- Instantiate objects of `Circle`, `Rectangle`, and `Triangle`.
- Use the `PrintShapeArea()` method to display the name and area of each instantiated shape.

### Access Modifiers
- Ensure proper encapsulation of properties and methods using appropriate access modifiers.
