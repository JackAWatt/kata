import java.text.NumberFormat;
import java.util.InputMismatchException;
import java.util.Scanner;
//modified by jack watt
//added extra line for errors
public class InvoiceApp
{
    public static void main(String[] args)
    { //entry point for main
        Scanner sc = new Scanner(System.in);
        boolean continueProgram = true;
      
        
        
        while (continueProgram) {
            //gives customerType initial value to fall in loop
            //also is put in loop to reset all values if user wants to go again
            String choice = "y";
            double subtotal = 0;
            boolean isValid = false;
            String customerType = " ";
            
            
//            
//            // get the input from the user
//            while (!customerType.equalsIgnoreCase("r") && !customerType.equalsIgnoreCase("c"))
//            { //entry point for comparision loop based on if customerType isNot r OR "c"
//                System.out.print("Enter customer type (r/c): ");
//                customerType = sc.next();
//                if (customerType.equalsIgnoreCase("r") || customerType.equalsIgnoreCase("c")) 
//                {//entry point if customerType meets criteria
//                    sc.nextLine();
//                }  
//                 else 
//                {//entry point if input does not meet criteria
//                    
//                 System.out.println("Error: Invalid input\n");
//                 sc.nextLine();
//                }
//                
//            }
//            //reset value incase user wants to re Run program
            customerType = getValidCustomerType(sc);
            
            
//         
//            while (!isValid) 
//            {
//                System.out.print("Enter subtotal:   ");
//                isValid = sc.hasNextDouble();
//                if (isValid)
//                {//entry point if end user inputed a double
//                    
//                    subtotal = sc.nextDouble();
//                }
//                else
//                {
//                    System.out.println("You fucked up, try again\n");
//                    sc.nextLine();
//                    
//                }
//            }
            subtotal = getValidSubtotal(sc);
            sc.nextLine();


            
            
            // get the discount percent
            double discountPercent = 0;
            if (customerType.equalsIgnoreCase("R"))
            {
                if (subtotal < 100)
                    discountPercent = 0;
                else if (subtotal >= 100 && subtotal < 250)
                    discountPercent = .1;
                else if (subtotal >= 250)
                    discountPercent = .2;
            }
            else if (customerType.equalsIgnoreCase("C"))
            {
                if (subtotal < 250)
                    discountPercent = .2;
                else
                    discountPercent = .3;
            }
            else
            {
                discountPercent = .1;
            }
     
            
            // calculate the discount amount and total
            double discountAmount = subtotal * discountPercent;
            double total = subtotal - discountAmount;
            
            // format and display the results
            NumberFormat currency = NumberFormat.getCurrencyInstance();
            NumberFormat percent = NumberFormat.getPercentInstance();
            System.out.println(
                    "Discount percent: " + percent.format(discountPercent) + "\n" +
                    "Discount amount:  " + currency.format(discountAmount) + "\n" +
                    "Total:            " + currency.format(total) + "\n");
            
            // see if the user wants to continue
            System.out.print("Continue? (y/n): ");
            choice = sc.next();
            //checks to see if end user inputed y for start again
            while (!choice.equalsIgnoreCase("y")) {
                //checks to see if input was n
                //if not n , means user inputed wrong
                
            if (choice.equalsIgnoreCase("n")){
                //if program reaches this point shows they end user 
                //did not want to go again
                continueProgram = false;
                break;
                       
            }
            //if program reaches this point shows invalid input
            //start them again on if they want to continue
            System.out.print("Error: Input invalid\n");
            System.out.print("Continue? (y/n): ");
            choice = sc.next();
            
            }
            sc.nextLine();
            System.out.println();
        
            }
    
}
    private static Double getValidSubtotal(Scanner sc) {
               boolean isValid = false;
               double subtotal = 0;
            while (!isValid) 
            {
                System.out.print("Enter subtotal:   ");
                //initial check is only if it's a valid double
                isValid = sc.hasNextDouble();
                if (isValid)
                {//entry point if end user inputed a double
                    //checks to make sure in range
                    //if not set isValid back to false
                    subtotal = sc.nextDouble();
                    if (subtotal < 0 || subtotal > 10000) {
                        isValid = false;
                        System.out.println("Error: Not valid input(1-9999)\n");
                    }
                }
                else
                {
                    System.out.println("Error: Not a valid number\n");
                    sc.nextLine();
                    
                }
            }
        
        
        
        return subtotal;
        
    }
    private static String getValidCustomerType(Scanner sc) {
            String customerType = " ";
            while (!customerType.equalsIgnoreCase("r") && !customerType.equalsIgnoreCase("c"))
            { //entry point for comparision loop based on if customerType isNot r OR "c"
                System.out.print("Enter customer type (r/c): ");
                customerType = sc.next();
                if (customerType.equalsIgnoreCase("r") || customerType.equalsIgnoreCase("c")) 
                {//entry point if customerType meets criteria
                    sc.nextLine();
                }  
                 else 
                {//entry point if input does not meet criteria
                 
                 System.out.println("Error: Invalid input\n");
                 sc.nextLine();
                }
                
            }
        
        return customerType;
    }
    
    
}

   // static char getValidCustomerType() {
    
    //    return 0;
  //  }
//}
