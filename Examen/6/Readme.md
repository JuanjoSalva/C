**QUESTION 6**
DRAG DROP

You are developing an application by using C#. The application includes an array of decimal values named loanAmounts. You are developing a LINQ query to return the values from the array.
The query must return decimal values that are evenly divisible by two. The values must be sorted from the lowest value to the highest value.
You need to ensure that the query correctly returns the decimal values.
How should you complete the relevant code? (To answer, drag the appropriate code segments to the correct locations in the answer area. Each code segment may be used once, more than once, or not at all. You may need to drag the split bar between panes or scroll to view content.)
**Select and Place:**

![image-20201112121957811](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112121957811.png)

**Section: Volume A
Explanation
Explanation/Reference:**
Explanation:
Note: In a query expression, the orderby clause causes the returned sequence or subsequence (group) to be sorted in either ascending or descending order.

Examples:
// Query for ascending sort.
IEnumerable<string> sortAscendingQuery =
from fruit in fruits
orderby fruit //"ascending" is default
select fruit;
// Query for descending sort.
IEnumerable<string> sortDescendingQuery =
from w in fruits
orderby w descending
select w;



