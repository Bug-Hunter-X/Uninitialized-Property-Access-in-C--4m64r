# Uninitialized Property Access in C#

This example highlights a potential issue in C# where accessing a property before it's explicitly assigned a value can lead to unpredictable behavior.

## The Problem

In C#, class properties have default values (0 for integers, null for references, etc.). However, relying on these default values without explicit initialization can make code less predictable and prone to errors, especially in complex scenarios.  The compiler doesn't warn about this, which makes it an easily overlooked issue. 

## Solution

The best practice is to always initialize properties, either in the constructor or directly within the property declaration using an initializer.