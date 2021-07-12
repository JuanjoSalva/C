**QUESTION 102**
You are developing an application that will be deployed to multiple computers. You set the assembly name.
You need to create a unique identity for the application assembly.
Which two assembly identity attributes should you include in the source code? Each correct answer presents part of the solution.
NOTE: Each correct selection is worth one point.

A. AssemblyTitleAttribute
B. AssemblyCultureAttribute
C. AssemblyVersionAttribute
D. AssemblyKeyNameAttribute
E. AssemblyFileVersion
F. AssemblyProductAttribute
G. AssemblyDelaySignAttribute
H. AssemblyCompanyAttribute

**Correct Answer: BC
Section: Volume B
Explanation
Explanation/Reference:**
Explanation:

The AssemblyName object contains information about an assembly, which you can use to bind to that assembly. An assembly's identity consists of the following:
Simple name
Version number
Cryptographic key pair
Supported culture

B: AssemblyCultureAttribute
Specifies which culture the assembly supports.
The attribute is used by compilers to distinguish between a main assembly and a satellite assembly. A main assembly contains code and the neutral culture's resources. A satellite assembly contains only resources for a particular culture, as in [assembly:AssemblyCultureAttribute("de")]

C: AssemblyVersionAttribute
Specifies the version of the assembly being attributed. The assembly version number is part of an assembly's identity and plays a key part in binding to the assembly and in version policy.
Reference:
https://docs.microsoft.com/en-us/dotnet/framework/app-domains/assembly-names