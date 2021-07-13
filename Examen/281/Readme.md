**QUESTION 281**
HOTSPOT
You are evaluating the following C# method.

![image-20201112123213151](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201112123213151.png)

The receiver of the data has a copy of the public key.
For each of the following statements, select Yes if the statement is true. Otherwise, select No.
**NOTE**: Each correct selection is worth one point.
**Hot Area:**

![image-20201118151818007](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20201118151818007.png)

**Section: Volume B
Explanation

Explanation/Reference:**
Explanation:

Box 1: No

Box 2: Yes
In cryptography, a public key certificate, also known as a digital certificate or identity certificate, is an electronic document used to prove the ownership of a public key. The certificate includes information about the key, information about the identity of its owner (called the subject), and the digital signature of an entity that has verified the certificate's contents (called the issuer). If the signature is valid, and the software examining the certificate trusts the issuer, then it can use that key to communicate securely with the certificate's subject.

Box 3: Yes
References:
https://docs.microsoft.com/en-us/dotnet/api/
system.security.cryptography.rsapkcs1signatureformatter.createsignature
https://en.wikipedia.org/wiki/Public_key_certificate