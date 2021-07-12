**QUESTION 14**
You are developing an application that will convert data into multiple output formats.
The application includes the following code. (Line numbers are included for reference only.)



![image-20201112122145779](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112122145779.png)

You are developing a code segment that will produce tab-delimited output. All output routines implement the following interface:

![image-20201112122218492](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112122218492.png)

You need to minimize the completion time of the GetOutput() method. Which code segment should you insert at line 06?

![image-20201112122236045](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112122236045.png)



A. Option A
B. Option B
C. Option C
D. Option D

**Correct Answer: B
Section: Volume A
Explanation
Explanation/Reference:**
Explanation:
A String object concatenation operation always creates a new object from the existing string and the new data. A StringBuilder object maintains a buffer to accommodate the concatenation of new data. New data is appended to the buffer if room is available; otherwise, a new, larger buffer is allocated, data from the original buffer is copied to the new buffer, and the new data is then appended to the new buffer. The performance of a concatenation operation for a String or StringBuilder object depends on the frequency of memory allocations. A String concatenation operation always allocates memory, whereas a StringBuilder concatenation operation allocates memory only if the StringBuilder object buffer is too small to accommodate
the new data. Use the String class if you are concatenating a fixed number of String objects. In that case, the compiler may even combine individual concatenation operations into a single operation. Use a StringBuilder object if you are concatenating an arbitrary number of strings; for example, if you're using a loop to concatenate a random number of strings of user input.

References: http://msdn.microsoft.com/en-us/library/system.text.stringbuilder(v=vs.110).aspx