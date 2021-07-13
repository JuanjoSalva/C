**QUESTION 53**
You are developing an application that includes a class named Order. The application will store a collection of Order objects.
The collection must meet the following requirements:

- Internally store a key and a value for each collection item.
- Provide objects to iterators in ascending order based on the key.
- Ensure that items are accessible by zero-based index or by key.

You need to use a collection type that meets the requirements.
Which collection type should you use?

A. LinkedList
B. Queue
C. Array
D. HashTable
E. SortedList



**Correct Answer: E

Section: Volume A
Explanation
Explanation/Reference:**
Explanation:
SortedList<TKey, TValue> - Represents a collection of key/value pairs that are sorted by key based on the
associated IComparer<T> implementation.
References: http://msdn.microsoft.com/en-us/library/ms132319.aspx