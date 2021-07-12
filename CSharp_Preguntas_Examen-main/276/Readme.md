**QUESTION 276**
DRAG DROP

You are developing a custom collection named LoanCollection for a class named Loan class.
You need to ensure that you can process each Loan object in the LoanCollection collection by using a foreach loop.

You have the following code:

![image-20201112124100642](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112124100642.png)

Which code segments should you include in Target 1, Target 2, and Target 3 to complete the code? To answer, drag the appropriate code segments to the correct targets. Each code segment may be used once, more than once, or not at all. You may need to drag the split bar between panes or scroll to view content.

NOTE: Each correct selection is worth one point.

Select and Place:

![image-20201112124139460](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112124139460.png)



**Correct Answer:**

![image-20201112124158326](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112124158326.png)

**Section: Volume B
Explanation

**
Explanation/Reference:**
Explanation:

Target 1: IEnumerable

Incorrect Answers:
IDisposable: Provides a mechanism for releasing unmanaged resources.
IComparable: Defines a generalized type-specific comparison method that a value type or class implements to order or sort its instances.

Target 2: public IEnumerator GetEnumerator()
Note:
The following code example demonstrates the implementation of the IEnumerable and IEnumerator interfaces for a custom collection. In this example, members of these interfaces are not explicitly called, but they are implemented to support the use of foreach (for each in Visual Basic) to iterate through the collection.

// Collection of Person objects. This class
// implements IEnumerable so that it can be used
// with ForEach syntax.
public class People : IEnumerable
{
private Person[] _people;
public People(Person[] pArray)
{
_people = new Person[pArray.Length];
for (int i = 0; i < pArray.Length; i++)
{
_people[i] = pArray[i];
}
}
// Implementation for the GetEnumerator method.

IEnumerator IEnumerable.GetEnumerator()
{
return (IEnumerator) GetEnumerator();
}

Target 3: return _loanCollection.GetEnumerator();
Use the return statement
Reference:
https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator