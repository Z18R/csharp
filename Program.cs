// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

// // Console.WriteLine("What is your name?");
// // var name = Console.ReadLine();
// // var currentDate = DateTime.Now;
// // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
// // Console.Write($"{Environment.NewLine}Press any key to exit...");
// // Console.ReadKey(true);

//Output
// you can add as many console as you like

// Console.WriteLine("Hello World!");
// Console.WriteLine("I am Learning C#");
// Console.WriteLine("It is awesome!");
// int
/* How you comment -- The code below will print the words 
Hello World to the screen, and it is amazing */
// Console.WriteLine(3 + 3);

// Variables/types

// int myNum = 5;
// double myDoubleNum = 5.99D;
// char myLetter = 'D';
// bool myBool = true;
// string myText = "Hello";
// Console.WriteLine(myNum);
// Console.WriteLine(myDoubleNum);
// Console.WriteLine(myLetter);
// Console.WriteLine(myBool);
// Console.WriteLine(myText);

// string firstName = "Joezer ";
// string lastName = "Cardoza";
// string fullName = firstName + lastName;
// Console.WriteLine(fullName);

// int x = 5;
// int y = 6;
// Console.WriteLine(x + y);

// float is 6 or 7 digits while double is 15 digits long

// float f1 = 35e3F;
// double d1 = 12E4D;
// Console.WriteLine(f1);
// Console.WriteLine(d1);

// converstion of int to string

// int myInt = 10;
// Console.WriteLine(Convert.ToString(myInt));

// Types of Converstion 

// int myInt = 9;
// double myDouble = myInt;       // Automatic casting: int to double

// Console.WriteLine(myInt);      // Outputs 9
// Console.WriteLine(myDouble);   // Outputs 9

// Console.WriteLine("Enter your age:");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your age is: " + age);

// Console.Write("Enter your name: ");

// string myName = Console.ReadLine();

// Console.WriteLine("Your name is "+ myName);

// string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// Console.WriteLine("The length of the txt string is: " + txt.Length);

// Full name
//       string name = "John Doe";

//       Location of the letter D
//       int charPos = name.IndexOf("D");

//       Get last name
//       string lastName = name.Substring(charPos);

//       Print the result
//       Console.WriteLine(lastName);
//       Console.WriteLine(charPos);

// if (20 > 18) 
//       {
//         Console.WriteLine("20 is greater than 18");
//       }   

// int day = 4;
// switch (day) 
// {
//   case 1:
//     Console.WriteLine("Monday");
//     break;
//   case 2:
//     Console.WriteLine("Tuesday");
//     break;
//   case 3:
//     Console.WriteLine("Wednesday");
//     break;
//   case 4:
//     Console.WriteLine("Thursday");
//     break;
//   case 5:
//     Console.WriteLine("Friday");
//     break;
//   case 6:
//     Console.WriteLine("Saturday");
//     break;
//   case 7:
//     Console.WriteLine("Sunday");
//     break;
// }

//while loop

// int i = 0;
// while (i < 5) 
// {
//   Console.WriteLine(i);
//   i++;
// }

// int i = 0;
// do 
// {
//   Console.WriteLine(i);
//   i++;
// }
// while (i < 5);


//for loop
//  for (int i = 0; i <= 10; i = i + 2)
//       {
//         Console.WriteLine(i);
//       } 

//foreach

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//       foreach (string i in cars) 
//       {
//         Console.WriteLine(i);
//       }   

//array

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//       cars[0] = "Opel";
//       Console.WriteLine(cars[0]);    

//for loop

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//       for (int i = 0; i < cars.Length; i++) 
//       {
//         Console.WriteLine(cars[i]);
//       }

//for each

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//       foreach (string i in cars) 
//       {
//         Console.WriteLine(i);
//       }

// C# program to add
// two binary strings

// using System;

// 	// This function adds two
// 	// binary strings and return
// 	// result as a third string
// 	static string addBinary(string a,string b)
// 	{
		
// 		// Initialize result
// 		string result = "";
		
// 		// Initialize digit sum
// 		int s = 0;		

// 		// Traverse both strings starting
// 		// from last characters
// 		int i = a.Length - 1, j = b.Length - 1;
// 		while (i >= 0 || j >= 0 || s == 1)
// 		{
			
// 			// Comput sum of last
// 			// digits and carry
// 			s += ((i >= 0)? a[i] - '0': 0);
// 			s += ((j >= 0)? b[j] - '0': 0);

// 			// If current digit sum is
// 			// 1 or 3, add 1 to result
// 			result = (char)(s % 2 + '0') + result;

// 			// Compute carry
// 			s /= 2;

// 			// Move to next digits
// 			i--; j--;
// 		}
// 	return result;
// 	}
	

// int [] arr = {1,2,3,4,2,3,4,12,24};
// int [] arr2 = {10,12,33,42,21,32,20,12,24};
// Array.Sort(arr);
// Console.WriteLine(arr);

// // C# program for the above approach
// using System;
// using System.Collections.Generic;

// public class GFG {
// 	public static int Solution(int[] arr)
// 	{
// 		int n = arr.Length;
	
// 		// If length of array is even
// 		if (n % 2 == 0)
// 		{
// 			int z = n / 2;
// 			int e = arr[z];
// 			int q = arr[z - 1];

// 			int ans = (e + q) / 2;
// 			return ans;
// 		}
	
// 		// If length if array is odd
// 		else
// 		{
// 			int z = n / 2;
// 			return arr[z];
// 		}
// 	}

// 	// Driver Code
// 	static public void Main (){
		
// 		// TODO Auto-generated method stub
// 		int[] arr1 = { -5, 3, 6, 12, 15 };
// 		int[] arr2 = { -12, -10, -6, -3, 4, 10 };
		
// 		// Merge two array into one array
// 		var myList = new List<int>();
// 		myList.AddRange(arr1);
// 		myList.AddRange(arr2);
// 		int[] arr3 = myList.ToArray();

// 		// Sort the merged array
// 		Array.Sort(arr3);
		
// 		// calling the method
// 		Console.Write("Median = " + Solution(arr3));
// 	}
// }

// //1st Identify Sorted numbers and its Length

// int[] intArray ={ 9, 2, 4, 3, 1, 5 };
// Array.Sort(intArray);
// int length = intArray.Length;
// Console.WriteLine(length);

// // for (int i = 0; i < intArray.Length; i++){
// // 	Console.Write(intArray[i]+ " ");
// // }

// if (length % 2 == 0 ){
// 	int median1 = intArray[length/2];
// 	int median2 = intArray[length/2 - 1];
// 	int median = (median1 + median2) / 2;
// }
// else if{

// }

/*in c# given an array [8,5,2,3,4] create a pseudocode that
will sort it to [2,3,4,5,8]*/


// int [] arr = {8,5,2,3,4};
// Array.Sort(arr);

// for (int i = 0; i < arr.Length; i++){
// 	Console.Write(arr[i]+" ");
// }

// string Name = "Joezer";
// string NewName = Name.Replace('J', 'F');
// System.Console.WriteLine(NewName);

//Find duplicate on the string 

//Write a program in C/C++ that swaps two integer values using Only two varaibles

// int x = 10;
// int y = 20;

// x = x-y;
// y = y+x;
// x = y-x;

// Console.WriteLine("x:"+x);
// Console.WriteLine("y:"+y);

// string [] arr = {"cake", "muffin", "coffe"};
// string [] arr2 = {"lemonade", "soda", "water"};
// string [] finalarr = {arr + arr2[1]};

// for(int i = 0; i < finalarr.Length; i++){
// 	System.Console.WriteLine(finalarr);
// }

/*string manipulation "Hello World" = "Jello World" */

// string NameHello = "Hello World";
// string NewName = NameHello.Replace("lo" , "bob");
// System.Console.WriteLine(NewName);


//make a program string to int

// Console.Write("This is your input: ");

// string NameHello = Console.ReadLine();

// int NewName = Int32.Parse(NameHello);

// if(NewName == 10){
// 	System.Console.WriteLine("ten");
// }else if(NewName != 12)
// {
// 	System.Console.WriteLine("Hmm");
// }else{
// 	System.Console.WriteLine("Rggtr");
// }

// string Fname = "Hello World";
// string NewName = Fname.Replace("Hello","Jello");

// System.Console.WriteLine(NewName);

//pass the value of a variable to another variable
// int y = 10;
// int x = 20;
// x = y;

// System.Console.WriteLine(y);

//get the highest number in an array

// int[] arr = {8,5,2,3,4};
// System.Console.WriteLine(arr);
// System.Console.WriteLine(arr.Max());

//get the lowest number in an array

// int[] arr = {8,5,2,3,4};
// System.Console.WriteLine(arr.Min());

// #include<stdio.h>

// void main(){
//     int x = 10;
//     int y = 20;
//     int z = 30;
//         x = ++y+z;
/*			x= (1+20)+30 21+30 = 51
			y =(1+20) = 21
			z = 30
*/
//         printf("x: %d\n",x);
//         printf("y: %d\n",y);
//         printf("z: %d\n",(z++));
// }

/*Write a program in c/c#/c++ language that swaps two integer
values using only two variables
*/

// int x = 20;
// int y = 10;

// x = x-y;
// y = y+x;
// x = y-x;

// System.Console.WriteLine("x: " + x);
// System.Console.WriteLine("y: " + y);

/*given in an array [8,5,2,3,4] create a pseudocode that
will sort it to [2,3,4,5,8] */

// int[] arr = {8,5,2,3,4};
// Array.Sort(arr);

// for(int i = 0; i < arr.Length; i++){
// 	System.Console.WriteLine(arr[i]);
// }

/*given in an array [8,5,2,3,4] create a pseudocode that
will reverse it to [8,5,4,3,2] */

// int[] arr = {8,5,2,3,4};
// Array.Sort(arr);
// Array.Reverse(arr);

// for(int i = 0; i < arr.Length; i++){
// 	System.Console.Write(arr[i]+ " ");
// }

 // declaring and initializing the array
        // int[] arr = new int[] {1, 9, 6, 7, 5, 9};
  
        // // Sort array in ascending order.
        // Array.Sort(arr);
  
        // // reverse array
        // Array.Reverse(arr);
  
        // // print all element of array
        // foreach(int value in arr)
        // {
        //     Console.Write(value + " ");
		// }

//get the median of an array

// int[] arr = {1,9,6,7,5,9};
// Array.Sort(arr);
// int lengthArr = arr.Length;
// int median;


// if (lengthArr % 2 == 0){
// 	median = arr[(lengthArr/2 ) -1 ] + arr[(lengthArr/2 - 3)/ 2] / 2;
// }
// else{
// 	median = arr[(lengthArr/2)];
// }
// System.Console.WriteLine(median);


//create a program that output even or odd
// System.Console.Write("Enter a number: ");
// int myNum = Int32.Parse(Console.ReadLine());

// if(myNum % 2 == 0){
//     System.Console.WriteLine("Even");
// }
// else{
//     System.Console.WriteLine("Odd");
// }


//string manipulation Hello World to Jello World

// string Fname = "Hello World!";
// string NewName = Fname.Replace("Hello","Jello");

// System.Console.WriteLine(NewName);

//swaps two integer values using only two variables x , y

// int x , y ;

// x = 20;
// y = 10;

// x = x-y;
// y = y+x;
// x = y-x;

// System.Console.WriteLine("x:" + x);
// System.Console.WriteLine("y:" + y);

//get the highest number in an array

// int [] arr = {8,5,2,3,4};
// System.Console.WriteLine(arr.Max());

//Pass the value of a variable to another variable

// int x, y;

// x = 10;
// y = 20;

// y = x;

// System.Console.WriteLine(y);

// given an array [8,5,2,3,4] create an array that will sort it

int [] arr = {8,5,2,3,4};
Array.Sort(arr);

for(int i = 0; i < arr.Length; i++){
    System.Console.Write(arr[i] + " ");
}