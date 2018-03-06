# FooBarQixKata

## Description

Write a program that prints numbers from 1 to 100, one number per line. For each printed number, use the following rules:

* if the number is divisible by 3 or contains 3, replace 3 by "Foo";
* if the number is divisible by 5 or contains 5, replace 5 by "Bar";
* if the number is devisible by 7 or contains 7, replace 7 by "Qix".

Example: 1 2 FooFoo 4 BarBar Foo QixQix 8 Foo Bar

More details:

* divisors have high precedence, ex: 51 -> FooBar
* the content is analysed in the order they appear, ex: 53 -> BarFoo
* 13 contains 3 so we print "Foo"
* 15 is divisible by 3 and 5 and contains 5, so we print “FooBarBar”
* 33 contains 3 two times and is divisible by 3, so we print “FooFooFoo”

## Architecture decision record (ADR)

* Since divisors have high precedence we have to guarantee the order. SortedDictionary is suitable for this purpose since the order of Dictionary is undefined. Also, the dictionary is readonly so we're assuring thread-safety.
* The Transform function validates the argument before further processing.
* Notice we're using the StringBuilder since we're performing repeated operation to the final string. Quick reminder: string is immutable. This means that for each operation we perform on our string, a new instance will be created. The overhead associated with creating a new String object can be costly. Therefore, StringBuilder fits the case.
