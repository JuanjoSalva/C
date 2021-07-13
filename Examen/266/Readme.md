**QUESTION 266**
You are developing a C# application. The application includes the following code segment. (Line numbers are included for reference only.)

![image-20201112123825473](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112123825473.png)

The application fails at line 17 with the following error message: "An item with the same key has already been added."

You need to resolve the error.

Which code segment should you insert at line 16?

![image-20201112123854192](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112123854192.png)

A. Option A
B. Option B
C. Option C
D. Option D

**Correct Answer: B
Section: Volume B
Explanation

**Explanation/Reference:**
Explanation:
Use if statement with ContainsKey method to check if dictionary already contains the specified key.

References:
https://msdn.microsoft.com/en-us/library/kw5aaea4(v=vs.110).aspx
https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-find-a-key-in-a-dictionary-with-C-Sharp/