# CsharpBruteForceFinal
# V 0.1 - Created the base structure of the application by creating folders and core classes for the next features to be implemented.
#  Designed the base UI by adding all of the UI elements (such as buttons, panels, progress bar, labels) that which will be utilized for the application. 
# This was done at the start for the purpose of having a consistent visual layout to make subsequent development easier.
# V 0.2 - Implemented password gen, hashing, and salting (by adding a fixed salt to be used in the hasing process) , as well as the option to select a type of password to be generated. 
# Hashing is being done by first creating an instance oof the SHA256 Algorithm that comes from the Cryptography namespace (System.Security.Cryptography) namespace which has it and represents it.
# The Create() Method creates an instance of the algorithm. Later, the command sha256.ComputeHash(Encoding.UTF8.GetBytes(...)) computes the hash by converting the string into a byte array using UTF-8 encoding. 