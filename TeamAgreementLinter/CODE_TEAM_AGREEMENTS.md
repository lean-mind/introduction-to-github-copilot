# Code Team Agreements

## Team Agreement 1: Explicit names for boolean variables

### Description

Boolean variables should start with `is`, `has`, or `can` to clarify their purpose.

wrong example:

```charp
bool finished;
bool errors;
bool delete;
```

fixed example:

```charp
bool isFinished;
bool hasErrors;
bool canDelete;
```


## Team Agreement 2: Not use '_' in private class variables

### Description

Private class variables should not start with `_`.

wrong example:
    
```charp
private int _count;
private string _name;
```

fixed example:

```charp
private int count;
private string name;
```

## Team Agreement 3: Not use acronyms in variable and method names

### Description

Variable and method names should not use acronyms. Instead, the full name should be used.

wrong example:

```charp
int empCount;
string empName;

void getEmpInfo() { }
```

fixed example:

```charp
int employeeCount;
string employeeName;

void getEmployeeInfo() { }
```


## Team Agreement 4: Not execute logic in constructors

### Description

Constructors should not contain logic. Instead, logic should be placed in factory methods or other 
classes will be responsible for creating objects.

wrong example:

```charp
public class Person
{
    public Person(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty");
        }
    }
}
```

fixed example:

```charp
public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; }
}

public class PersonFactory
{
    public Person CreatePerson(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty");
        }

        return new Person(name);
    }
}
```

> Note: The factory method can be a static method in the same class or a separate class.

## Team Agreement 5: The methods that return a list should be named in plural

### Description

Methods that return a list should be named in plural in order avoid confusion.

wrong example:

```charp
List<string> getEmployee();
```

fixed example:

```charp
List<string> getEmployees();
```


## Team Agreement 6: Not use comparison expressions in conditional statements directly

### Description

Comparison expressions should not be used directly in conditional statements. Instead, they should be
assigned to a boolean variable and then used in the conditional statement. Or the comparison expression
should be extracted to a method that returns a boolean value.

wrong example:

```charp
if (count > 0)
{
    // do something
}
```

fixed example:

```charp
bool isNotEmpty = count > 0;

if (isNotEmpty)
{
    // do something
}
```

or

```charp

bool isNotEmpty(int count)
{
    return count > 0;
}

if (isNotEmpty(count))
{
    // do something
}
```

## Team Agreement 7: Don't use Capital Letters for constants

### Description

Constants should be written in lowercase letters following the PascalCase convention.

wrong example:

```charp
const int MAX_COUNT = 100;
const string ERROR_MESSAGE = "An error occurred";
```

fixed example:

```charp
const int maxCount = 100;
const string errorMessage = "An error occurred";
```


## Team Agreement 8: Tests have to follow the AAA pattern

### Description

Tests should follow the Arrange-Act-Assert pattern. This pattern helps to make the tests more readable and maintainable.

wrong example:

```charp
[Test]
public void TestMethod()
{
    var calculator = new Calculator();
    var result = calculator.Add(1, 2);
    Assert.AreEqual(3, result);
}
```

fixed example:

```charp
[Test]
public void TestMethod()
{
    var calculator = new Calculator();
    var expected = 3;

    var result = calculator.Add(1, 2);

    Assert.AreEqual(expected, result);
}
```

> Note: if the test is simple maybe can be written in one line.

```charp
[Test]
public void TestMethod()
{
    Assert.AreEqual(3, new Calculator().Add(1, 2));
}
```


## Team Agreement 9: Not use complex conditional statements

### Description

Complex conditional statements should be avoided. Instead, the conditional statements should be extracted to a method that returns a boolean value.

wrong example:

```charp
if (count > 0 && name != null && name.Length > 0)
{
    // do something
}
```

fixed example:

```charp
bool isValid(int count, string name)
{
    var isNotEmpty = count > 0
    var isNameValid = name != null && name.Length > 0;
    return isNotEmpty && isNameValid;
}

if (isValid(count, name))
{
    // do something
}
```

## Team Agreement 10: Use english to write the code

### Description

The code should be written in English. This includes variable names, method names, comments, and documentation.

wrong example:

```charp
int cantidad;
string nombre;

void obtenerInformacionEmpleado() { }
```

fixed example:

```charp
int count;
string name;

void getEmployeeInfo() { }
```