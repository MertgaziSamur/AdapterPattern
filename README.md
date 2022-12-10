### AdapterPattern <br/>

Adapter design pattern is in the category of structural design pattern.

***Purpose of usage;***

- It allows us to use two incompatible interfaces together.
- We do not have to edit the previously written code. After all, we assume that the relevant code has worked before.
- Since we do not make any changes on the class we will adapt, we do not need to make any changes in any place where it is used in the application. 

<br/> <br/>

Convert the interface of one class to the interface that another class expects. An adapter is a combination of classes that cannot work due to incompatible interfaces.
provides their work. It is the most understandable of the structural patterns. <br/>
What needs to be done is to solve the adaptation problem in a class that will ensure harmony. This class connects the existing client with the class with the incompatible interface.
will make it workable. This class is Adapter. <br/>
The Adapter class falls between the incompatible class and the interface that the client knows to work with, and the incompatible class becomes compatible with that interface.
makes it.
