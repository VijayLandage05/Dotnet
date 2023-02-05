ThreadStart

• ThreadStart is a delegate which represents a method to be invoked  when this thread begins executing.
• Thread(ThreadStart) Constructor is used to initialize a new instance of a Thread class. 
This constructor will give ArgumentNullException if the value of the parameter is null.

• Syntax : 

public Thread(ThreadStart start);