//Integral Data Types


	char - //represents characters, that is letters, digits and special symbols each char is enclosed within single quotation marks - EX - 'A' '*' ' '
	short
	int 
	long
	bool - true , false
	unsigned char
	unsigned short
	unsigned int
	unsigned long
	
//Floating Point Data Types
	float
	double
	long double - /*most newer compilers is same as*/ double
	
//Decleration of Variables
	dataType identifier, identifier,...;
		EX
			double amount, taxRate;
			char letter;
	//initialize at declaration time
		double amount = 1200.99;
		int age = 20, counter = 1;
		char letter = ' '
	//C++ does not auto initialize variables when they are declared
	// meaning that if they are called they will refer to garbage
	// in ram
	//Named Constant
		const dataType IDENTIFIER = value;
		
		const int age = 20, counter = 1;
		const double amount = 1200.99;
		
//Comments
	Single line comments // example
	
	Multi line comments /*
	
	everything within  is a comment
	
	*/
	
Output & input
	cout<<  expression/manipulator
	cin>>  expression/manipulator
	
	/*expression
		value is printed to current cursor position on the screen
	*/
	
		/* stream insertion operator
		*/ << /* output
		*/ >> /* input
	*/
	
	/* Examples out output statments
		Statement						Output*/
		cout << "4 + 7 = “ << 4 + 7;	4 + 7 = 11
		cout << 2 + 3 * 5;				17
		cout << "Hello \nthere. ";		Hello
										there.
										
	//example of extraction operator
		cin >> miles;  //where miles is a variable
		cin >> feet >> inch; //both being variables
		
/*manipulator
	manipulates the output. the simplest is */ endl /* which causes the cursor to move to the beginning of the next line
	*/ \  /* is called escape character
	*/ \n /* cursor moves to the beginning of the next line
	*/ \t /* cursor moves to the next tab stop
	*/ \b /* cursor moves one space to te left
	*/ \r /* cursor moves to the beginning of the current line
	*/ \\ /* backslash is printed
	*  \' /* single quote is printed(commented due to quotes)
	*  \" /* double quote is printed(commented due to quotes)
	*/

	//Syntax of manipulators
		// Need a manip and expression
		cout << manipulators << “Text”;
		// can be long statement with lots of
		// manips and strings and variables
		cout << manipulators << variable 
				 << manipulator  << “Text”;
		// turn on once to use in entire pgm
		cout << manipulator; 

	
	
// Header files
	#include <headerfilename>
		#include <iostream>
		#include <math.h>
			
			
//Math in C++
	+
	-
	*
	/
	% //remainder (mod operator)
		//example of mod
			2 % 5 = 1
			//because 5 divided by two leaves a remainder of 1 if dealing with int data types

/*Functions in C++
	/*prototypes
		defined before main, layout of function
		requires */ dataTypes /* only
		variable names are optional here
		/* syntax example */
			void FtnName(sendtype [VarName1]
                  [,sendtype [VarName2]]);
			
		/* real examples */
				void ScreenTitle(void);
				void GetInfo(long);
				void CalcInfo(double price);
				void Ftn(double, char, long);
				void FtnName(long sum, long num);

			
	
	/* function itself:
		requires */ dataTypes & variables /*
		code in function */
		return /* statment
		
		/* syntax example */
			FtnName(var1 [, var2] [, var3]);
		
		/* real examples */
			ScreenTitle();
			GetInfo(number);
			CalcInfo(price);
			Ftn(num, letter, total);
			FtnName(sum, num);
			
		void FtnName (senttype varname1
                            [, senttype varname2]){
			// code for function

			return;  // transfer control back
		}
	
		void CalcTotal(long num1, long num2){
		  long total;
		  
		  total = num1 + num2;

		  // code to display total
		  
		  return;
		}

	/*points about functions//sending 
	
		 sending-> use brackets after ftn name
		 prototype must have */dataType/* 
		 prototype can have variable name
		 function call must have variable name
		 function header must have both:
		 */dataType /* and variable name
		 like redeclaring the */variables /*
		 do not declare the vars again in ftn
		 
		Ftn does not use same memory
		for variable, but creates new:
		Pass By Copy 
		
		order is important
		 variable names within functions do NOT
		   have to be the same as the ones sent in
		 C++ is only sending the value of the
		  variable at that moment, not its memory
		  location
		 variables local to a ftn die once the ftn ends */
		 
	// Assignment statement:
		number = GetInfo();


	//Within an assignment statement:
		total = 18 + num + Ftn();
		num += FtnName();


	//Within a control structure:
		if (ValidData()){
		
	//Example
			long calc_total(){
			long num1, num2, total;
		  
				// read in num1 and num2

				total = num1 + num2;

					// 2 ways to return the total
					// method 1 is return total
					// method 2 is return num1 + num2

				return total;
			}

			




	

		
	
	
	
		
	

	
	
	