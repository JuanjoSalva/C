*QUESTION 54*
You are developing an application that includes the following code segment. (Line numbers are included for
reference only.)

![image-20201112115627558](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112115627558.png)

You need to ensure that the application accepts only integer input and prompts the user each time non-integer input is entered.

Which code segment should you add at line 19?

![image-20201112115732872](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112115732872.png)



A. Option A
B. Option B
C. Option C
D. Option D



Correct Answer: A
Section: Volume A
Explanation
Explanation/Reference:
Explanation:
Int32.TryParse - Converts the string representation of a number to its 32-bit signed integer equivalent. A return
value indicates whether the conversion succeeded.
Incorrect Answers:
B, C: These will throwan exception when user enters non-integer value.
D: This is exactly the opposite what we want to achieve.
References: http://msdn.microsoft.com/en-us/library/f02979c7.aspx