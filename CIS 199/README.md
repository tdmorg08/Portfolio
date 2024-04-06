#CIS-199 Program 4 descripton



Purpose: This assignment explores the creation of a reusable class and separate console application that creates a list of objects.

For this program, you are to create a console application that has three classes in separate files. One class will contain the Main method, a public class named Cats, and the third is a public class named Dogs. The class containing the Main method should create and display five Cat objects AND five Dog objects. Both the Cats and Dogs objects will have the same basic information for their respective animals: Name (string), Breed (string), Sex (string), Age (int), Fur Color (string), Price (double), and Availability status (bool).

First, you will need to create a public class named Cats. The following is a list of requirements that MUST be included within this class:
A 6-parameter constructor that accepts the cat’s name (string), breed (string), sex (string), age (int), fur color (string), and price (double). When a cat is created, it will not be adopted yet. Use the set properties for all relevant fields (except the Adopted status, which does not have a property) to establish their initial values (instead of directly changing instance variables). No other constructor exists for this class (there is NO parameter-less constructor for this class).

A String property named CatName with a get and set. No validation need to be done on the name at this time. You may use an auto-implemented property.
A String property named CatBreed with a get and set. No validation need to be done on the name at this time. You may use an auto-implemented property.
A String property named CatGender with a get and set. No validation need to be done on the name at this time. You may use an auto-implemented property.
A Int property named CatAge with a get and set. To practice validation, you must provide validation in the set accessor. It must ensure that the age value is a non-negative and greater than 0 when attempting to set; otherwise, set the age to a default value of 3.
A String property named CatFurColor with a get and set. No validation need to be done on the name at this time. You may use an auto-implemented property.
A Double property named CatPrice  with a get and set. No validation need to be done on the name at this time. You may use an auto-implemented property.
A method named isAvailable() that returns no data (void) and accepts no parameters. This method will change the cat’s adoption status to reflect that the cat is not yet adopted by setting the Availability status to false.
A method named isAdopted() that returns no data (void) and accepts no parameters. This method will change the cat’s adoption status to reflect that the cat is not yet adopted by setting the Availability status to true.
A method named Availability() that returns a bool and accepts no parameters. This method will return a true value when the cat is adopted and a false value when the cat is available for adoption. In other words, return the value of the bool on cat availability status instance variable.
A method named ToString() that returns a String and accepts no parameters. Remember, you must also use keyword override when defining a ToString method. This method will create a formatted string that has the cat's name, breed, gender, age, fur color, price, and availability status each on a separate line. Precede each item with an identifying label. You may use string interpolation to create the formatted text that the method will return. Instead of concatenating the string literal "\n" to add a newline to the string, use the string constant Environment.NewLine instead. Note well, the ToString method just builds and returns a string. It does no output of its own. That is up to client classes to perform, as the output may be directed to the console or a GUI or a web page. See the PayrollSystem or Time examples from class for an example of how ToString() should be written.
 
For the Dogs class, follow the same steps you did for the Cats class. It will have similar properties, however, they have “Dog” instead of “Cat” in the property names. Everything else should be the same, including the set validation and methods.
 
In addition to these classes, you will need to write a simple Console application to test your animals. In your other class file (where the Main method is located), your simple test program must do the following:
Create at least 5 Cats objects and 5 Dogs objects (you may hard code your test data) and store them in an array.
Using two methods, print out all the Cat and Dog’s original data to the Console. Your method should be static void and will accept the array of cat and dog objects as their parameters.
Next, for each cat and dog object, use the appropriate properties and methods to change either the animal’s availability, name, age, or price. These changes can be hard coded (not in a loop).
Again, using the methods you wrote previously, print out all the cats' and dogs’ new data to the console by passing the arrays of cat and dog objects again to the method.
Call the appropriate  Dog method to change each dog’s status to adopted (Is Available: False).
Finally, print all cat and dog data to the console (using the methods you wrote previously) one last time.
Since you are printing each animal’s data to the console several times, you must write two methods to accomplish this task in your test application program. As noted earlier, the method should be static, void and will accept the arrays of cat and dog objects as their parameters.
 
