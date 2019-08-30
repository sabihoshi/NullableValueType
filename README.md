# NullableValueType

A bug in resharper/rider where it does not recognize `T?` as a valid return value for a generic method that has a constraint of a nullable type.

```cs
public T? Foo<T>() where T : Bar
//     ^^ CS862A: nullable type parameter must be known to be a value type or non-nullable reference type.
```