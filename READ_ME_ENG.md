This program is in the C# programming language,
Models the work of task planners in multiprocessor system resource management methods.
when processing task packages with interrupts using the LPT algorithm, which consists in scheduling
with minimal problem solving time. Tasks are pre-ordered in order of decreasing complexity.
the time to solve and assign these tasks to the processors being released.
Creating a schedule for solving problems is possible by entering a predetermined number of cycles for one stage of solving a problem.
and thanks are ordered by decreasing complexity of tasks.

The main module UpravlenieResursamiMnogoprocessornihSystemAlgLPT contains the main function Main
- performing the task of entering the number of common tasks for all processors, the number of identical processors for
processing of these common tasks and entering a known number of clocks at one stage of solving the problem.
Also in this function, a random array initialization occurs with different execution times for
user-entered tasks, sorting an array with decreasing permutation of elements,
checking all processors to perform tasks, where a new task is assigned to the vacant processor.
This function checks whether all processors have done all the work, using data from
method CheckProcessors and at the end of all processors displays data about the optimal schedule
and the number of cycles passed.
  
Method CheckProcessors - gets data about the processor array from the main function Main,
checks whether all processors are free or not free, and transmits the state of the processors to the main function Main.