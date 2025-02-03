# Uninitialized Property Access in C# Example

This repository demonstrates a common C# error: accessing a class property before it has been initialized.  Uninitialized properties can lead to subtle bugs that are difficult to track down.  The provided code shows the issue and its solution.

## Problem

The `MyClass` class contains a property `MyProperty`.  In `MyMethod()`, this property is accessed before it's given a value.  This can lead to the method operating on the property's default value (0 for integers), which might not be what you expect.

## Solution

The solution involves explicitly initializing `MyProperty` either in the constructor or when it's assigned.

## Files:

* `UninitializedProperty.cs`: Shows the bug.
* `UninitializedPropertySolution.cs`: Demonstrates the corrected code.