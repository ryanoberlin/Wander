# MSSA Individual Project Write Up

### Ryan Oberlin

#### The Traveling Salesman Problem
The Traveling Salesman Problem (TSP) is a well know problem in theoretical computer science. It is one of those most studied decision problems in computational  
complexity theory. The problem has been around in one form or another for quite some time, but the current form appears to have originated in the 1930s.  
The general form of TSP asks given a number of cities and the distances between each pair of cities, compute the shortest route between them that visits each city once  
while returning to the original starting point. The problem is described as NP-hard  There several exact algorithms are known, one of the most efficient is known as the Held-Karp  
algorithm, which operates in O(n^22^n) time and O(n2^n) space.  

#### Real Life Use Cases
While it may seem a novel problem on the surface there are many real world applications that are variations of the TSP. One of the more obvious applications is a delivery  
company wanting to find the most efficient route for package delivery. Less obvious applications include integrated circuit and circuit board design, DNA sequencing, or maximizing the   
use of a large space telescope. All these problems have a cost (distance) associated with them as well as constraints (cities) that limit the number of solutions.  

#### Project Outline
My main goal of this project is to facilitate my learning and further my understand in several areas of computer science. My initial focus will be to build a very basic database  
to use as reference inputs to increase my understanding of SQL. Following the implementation of a database, I intend to develop a simple console application written in C# that executes  
different algorithms using supplied inputs, eventually transitioning from a console application to a GUI. Given proper functionality of the application and resources I will focus on  
adding functionality in the form of taking input data through the use of various Web Map APIs. Any data obtained via Map API should be retained locally in the database for quicker  
access for future use. The program should at a minimum, provide the ability to choose the type of algorithm being used, take the number of cities(upper bounded for certain algorithms)   
and the distance between each pair of cities as inputs. The output should be a route and run time analysis.                        

#### Purpose for choosing this project  
My purpose for choosing this as a project has several goals associated with it. As previously stated, my primary goal is to facilitate overall understanding.  
My intent is to use this project to cover many aspects of computing. By picking a problem like TSP it will provide an opportunity to examine the P versus NP problem.  
In doing so I will also have to study computational complexity theory and algorithm efficiency. A basic understanding of relational databases will be needed to   
implement the initial SQL database. The C# console application will require a working understanding of Object Oriented Programming, along with algorithm efficiency,   
and simple I/O from a SQL database. Transitioning to a GUI gives me the opportunity to develop using the UWP and xaml formats, as well implement a graphical design.  
By adding additional functionality, like the use of Web Map APIs, I hope to gain an understanding of processing JSON and passing the information into a SQL database.  
Lastly, I hope to achieve a level of functionality that I am comfortable with and begin experimenting with quantum algorithms using the recently released Microsoft Q# SDK. 
