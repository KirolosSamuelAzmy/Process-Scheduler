# Process-Scheduler
### It is an Windows based desktop application that is used to simulate different Operating System process scheduleing algorithms.
### It supports 4 different Scheduling Algorithms which are :
* First Come First Served (FCFS).
* Shortest Job First (SJF) , Support both pre-emptive and non pre-emptive.
* Priority Based Scheduler , Support both pre-emptive and non pre-emptive.
* Round Robin (RR).

#### The Application supports any kind of input like float input of arrival time or burst time of the processes 
#### It also can deal with the time gap between the arrival or burst time of the processes.

#### In order to take a look on the application , You should download a Zip file of the repo and then open the Release folder where you will find the .exe file.

#### Here is a tutorial to open and use the application in a proper way : 

![FCFS GAP](https://user-images.githubusercontent.com/66043730/85196895-aab92b80-b2dd-11ea-86d7-f891575d3fe1.PNG)
1. First you will choose the type of the scheduler (If it is pre-emptive based only like Round Robin the non-pre-emptive check box will not be available to be used).
2. After that choose if it is pre-emptive or not if the scheduler supports both.
3. Then , Add process by typing their Arrival time and their burst time (the application supports input error handling), and also the priority of each process if the user chooses the priority based scheduler (You will not be able to go further if you choose priority scheduler and dont add the priority of each process).
4. In every scheduler , There are pre-loaded examples that supports both fractional inputs or gap .
5. In order to simulate the processes , You should click in (Commence Scheduling Procedure).

![FCFS GAP SOL2](https://user-images.githubusercontent.com/66043730/85196892-a987fe80-b2dd-11ea-858b-5a7ea4dca6e1.PNG)

6. The Output should be visualize in 2 charts , The above one is by Bar Chart.

![FCFS GAP SOL](https://user-images.githubusercontent.com/66043730/85196889-a856d180-b2dd-11ea-82e5-972e1cf93a43.PNG)

7. And this by Gantt Chart.
