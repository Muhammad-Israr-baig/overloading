#Arithmetic Operations in C# 

This project demonstrates method overloading in C# to perform basic arithmetic operations such as addition, subtraction, and multiplication using multiple parameters.

##📁 Project Structure
This simple console application is written in C# and includes a class A that contains overloaded methods for arithmetic operations:

sum(int, int)

sum(int, int, int)

sub(int, int)

sub(int, int, int)

mul(int, int)

mul(int, int, int)

##🚀 How It Works

The Main method creates an instance of class A and calls the overloaded methods with different sets of arguments.

Example Output:

80
90
100
200
600
24000

##📄 Code Overview

public int sum(int a, int b)               // Adds two integers
public int sum(int a, int b, int c)        // Adds three integers
public int sub(int a, int b)               // Subtracts b from a
public int sub(int a, int b, int c)        // Subtracts b and c from a
public int mul(int a, int b)               // Multiplies two integers
public int mul(int a, int b, int c)        // Multiplies three integers

##✅ Features
Demonstrates method overloading.

Simple structure and easy to understand.

Suitable for beginners learning OOP concepts in C#.

##🛠️ Requirements
.NET SDK (version 5.0 or higher)

A C# IDE or editor such as:

Visual Studio

Visual Studio Code (with C# extension)


##📚 License
This project is licensed under the MIT License. See the LICENSE file for details.


