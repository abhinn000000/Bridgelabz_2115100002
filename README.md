.dll file v/s .exe file
Ans. 
.dll file (Dynamic Link Library) 
• A Dll is a Dynamic Link Library can not run itself, used as a supportive file to other application.
• The Library Functions are Linked to the Application at Run Time (Dynamically) So the name is Dll. 
• A Dll does not contain an entry point (main function) so can not run individually.
NOTE: Creating a process is an overhead to the operating system so DLL does not contain main function to reduce the burden on the OS.

.exe file 
• An Exe is executable file and is not a supportive file rather itself an application.
• An Exe will contain an entry point (main function) so runs individually.

Access modifiers in C#
public - can be accessed from anywhere.
private - access is limited to only the class definition. It is the default access modifier if nothing has been mentioned.
protected - access is limited to the definition of the class and the class which inherits from it.
internal - access is limited to only the classes in the same project assembly.
protected internal - access is limited to the current assembly, all members in the current project and all members in the derived class can access the variables.
private protected - access is limited to the containing class or types derived from the containing class within the current assembly.

static vs non-static
Ans. A static variable can not be instantiated, memory is allocated once per class and shared by all instances,
Typically used for shared data or constants.
A non-static variable needs to be instantiated using the new keyword, memory is allocated every time the new keyword is used, can have different values for each instance, typically used for storing object specific data.
