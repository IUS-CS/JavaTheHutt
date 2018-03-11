

# Design Patterns

### 1)

At present, we are using something akin to the interpreter pattern. This is found in the logic that parses an input string of a chemical equation and interprets/transforms it into a usable state so that it can then be worked with and properly balanced. 

### 2)

It would be possible to use an iterator pattern to walk through the input equation and allow for the equation to be worked on. Also, it would be possible to store the information of the equation in a singleton so that its information can be more easily accessed by the various methods that need to access that information so that they can do their work. Likewise, the object in the singleton could be broken up into many smaller separate objects and then controlled through an observer; however, this is likely to be terribly unnecessary and would likely only serve to introduce bugs and needless complexity.

### 3)

Further modules will be designed on an as needed basis in order to increase the functionality of the program. Now with this resource, it should be a simple matter to review the standard patterns and pick ones that fit our needs in order to keep within industry best practices and increase our productivity.

