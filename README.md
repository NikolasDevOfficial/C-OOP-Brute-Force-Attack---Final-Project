# CsharpBruteForceFinal
# V 0.1 - Created the base structure of the application by creating folders and core classes for the next features to be implemented.
#  Designed the base UI by adding all of the UI elements (such as buttons, panels, progress bar, labels) that which will be utilized for the application. 
# This was done at the start for the purpose of having a consistent visual layout to make subsequent development easier.
# 
# V 0.2 - Implemented password gen, hashing, and salting (by adding a fixed salt to be used in the hasing process) , as well as the option to select a type of password to be generated. 
# Hashing is being done by first creating an instance oof the SHA256 Algorithm that comes from the Cryptography namespace (System.Security.Cryptography) namespace which has it and represents it.
# The Create() Method creates an instance of the algorithm. Later, the command sha256.ComputeHash(Encoding.UTF8.GetBytes(...)) computes the hash by converting the string into a byte array using UTF-8 encoding. 
#
# V 0.3 - In this iteration I implement the main logic for bruteforce. I split the functionality into three sections:
# The generator, the validator, and then the program. 
# For the generator, I use recursion to generate all the possible combinations for the characters. Where,
# We first start with an empty string, and then we recursively generate combinations for the next character position where for each character in the set we append to the current string, and after it gives each combination as its generated.
# Th validator takes the given iteration for each combination and compares it to the target password, and it returns true if it matches, otherwise it continues.
# Brute Force Program utilizes both the combination class and the validator class within its logic, and it calculates the total number of combinations for the progress tracking class, and creates one at its initialization. 
# During its running it gets all the combinations for each length from 1 to 6, increments the attempt counter, updates the tracker, and validates whether the combination matches or not. In case it does, it raises the PasswordFound event and returns, to be then used in Form1.
# The progress tracker tracks the total number of combinations, the current attempt count, and the progress percentage.
# I'm currently running into the difficulty of properly implementing the progress bar to properly move along as the attempt numbers increase and get nearer to the max possible combinations.
# At the present moment it tracks the each attempt at intervals.
#
# v0.4 Implemented multi-threading, implementation of max cpu cores -1, and parallel execution, and thread management. The way i impelement multi threading is by using the Parallel.For method with ParallelOptions to execute the brute force attempts across multiple threads at the same time.
# While each thread processes different operations for shared variables. The system detects how many available cpu cores there are by using the Environment.PorocessorCount and limits the number of threads to the task requirement of CPU Cores -1 by using the
# MaxDegreeOfParallelism property, and falling back to a single thread completion. When the password is found or in the case the user click the button Stop, all running threads are immediately terminated by using CancellationTokenSource.
#
# V0.5 Attempted an implementation for the performance longer but it's still dysfunctional, to be fixed.
#
# V0.6 - Bug fixing -  Repaired the  StopAttemptButton fixing a problem in Form1 Designer where the click was absent and adding additional logging in case of dysfunction.
# Due to crashes occurring, combinations were adjusted to better support bruteforcing for more complex password complexity cases. This was done by changing to a LINQ implementation instead, where I use Enumerable.Range to generate to a given 
# specified max value, then SelectMany flattens the combinations into a sequence where the Enumerable.Repeat creates the cartesian product which computes all possible character combinations before converting them to strings with Select. 
# Redid the performance logger, and used a Label instead of TextBox to prevent potential issues that may have been caused as a result of it. Corrected display for results, and added password output for both methods for validating comparison to the originally created password.
# Fixed cancellation issue by properly instantiating a new CancellationTokenSource for each run. Fixed restart by adding proper reset of session state for new tests.
# Added a state stop and  CancellationTokenSource cancel to make sure that all threads are force stopped instead of waiting on loops to finish.
