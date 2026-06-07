# CsharpBruteForceFinal
# V 0.1 - Created the base structure of the application by creating folders and core classes for the next features to be implemented.
#  Designed the base UI by adding all of the UI elements (such as buttons, panels, progress bar, labels) that which will be utilized for the application. 
# This was done at the start for the purpose of having a consistent visual layout to make subsequent development easier.
# V 0.2 - Implemented password gen, hashing, and salting (by adding a fixed salt to be used in the hasing process) , as well as the option to select a type of password to be generated. 
# Hashing is being done by first creating an instance oof the SHA256 Algorithm that comes from the Cryptography namespace (System.Security.Cryptography) namespace which has it and represents it.
# The Create() Method creates an instance of the algorithm. Later, the command sha256.ComputeHash(Encoding.UTF8.GetBytes(...)) computes the hash by converting the string into a byte array using UTF-8 encoding. 
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
