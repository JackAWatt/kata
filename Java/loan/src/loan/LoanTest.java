/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package loan;
import junit.framework.TestCase;

public class LoanTest extends TestCase {
public void testLoan() {
Loan x = new Loan();
assertEquals(0, x.getLoanAmount(), 0.000001);
assertEquals(0, x.getInterestRate(), 0.001);
assertEquals(0, x.getDurationYears());
}
public void testLoanDoubleDoubleInt() {
Loan x = new Loan(10000,6.25,5);
assertEquals(10000, x.getLoanAmount(), 0.001);
assertEquals(6.25, x.getInterestRate(), 0.001);
assertEquals(5, x.getDurationYears());
}
public void testSetGetLoanAmount() {
Loan x = new Loan();
x.setLoanAmount(10000.49);
assertEquals(10000.49, x.getLoanAmount(),0.001);
}
public void testSetGetInterestRate() {
Loan x = new Loan();
x.setInterestRate(5.125);
assertEquals(5.125, x.getInterestRate(),0.001);}
public void testSetGetDurationYears() {
Loan x = new Loan();
x.setDurationYears(5);
assertEquals(5, x.getDurationYears());
}
public void testMonthlyPayment() {
Loan x = new Loan(10000,6.25,5);
try {
assertEquals(194.492, x.monthlyPayment(), 0.001);
x.setInterestRate(0);  // try interest rate of 0 percent
assertEquals(166.666, x.monthlyPayment(), 0.001);
} catch (Exception e) {
fail();
}
}
public void testMonthlyTotalInterest() {
Loan x = new Loan(10000,6.25,5);
try {
assertEquals(1669.557, x.monthlyTotalInterest(), 0.001);
} catch (Exception e) {
fail();
}
}public void testBiweeklyPayment() {
Loan x = new Loan(10000,6.25,5);
try {
assertEquals(89.659, x.biweeklyPayment(), 0.001);
x.setInterestRate(0);  // try interest rate of 0 percent
assertEquals(76.923, x.biweeklyPayment(), 0.001);
} catch (Exception e) {
fail();
}
}
public void testBiweeklyTotalInterest() {
Loan x = new Loan(10000,6.25,5);
try {
assertEquals(1655.665, x.biweeklyTotalInterest(), 0.001);
} catch (Exception e) {
fail();
}
}
public void testWeeklyPayment() {
Loan x = new Loan(10000,6.25,5);
try {
assertEquals(44.806, x.weeklyPayment(), 0.001);
x.setInterestRate(0);  // try interest rate of 0 percent
assertEquals(38.461, x.weeklyPayment(), 0.001);
} catch (Exception e) {
fail();}
}
public void testWeeklyTotalInterest() {
Loan x = new Loan(10000,6.25,5);
try {
assertEquals(1649.708, x.weeklyTotalInterest(), 0.001);
} catch (Exception e) {
fail();
}
}
// test for duration of zero
public void testMonthlyPaymentException1() {
Loan x = new Loan(10000,6.25,0);
try {
x.monthlyPayment();
} catch (InvalidDurationException e) {
assertEquals("Duration of the loan cannot be zero.", e.getMessage());
} catch (NegativeLoanFieldException e) {
fail();
}
}
// test negative loan amount
public void testMonthlyPaymentException2a() {
Loan x = new Loan(-10000,6.25,5);
try {x.monthlyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {
assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}
// test negative interest
public void testMonthlyPaymentException2b() {
Loan x = new Loan(10000,-6.25,5);
try {
x.weeklyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {
assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}
// test negative duration
public void testMonthlyPaymentException2c() {
Loan x = new Loan(10000, 6.25, -5);
try {
x.weeklyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}
// test for duration of zero
public void testWeeklyPaymentException1() {
Loan x = new Loan(10000,6.25,0);
try {
x.weeklyPayment();
} catch (InvalidDurationException e) {
assertEquals("Duration of the loan cannot be zero.", e.getMessage());
} catch (NegativeLoanFieldException e) {
fail();
}
}
// test negative loan amount
public void testWeeklyPaymentException2a() {
Loan x = new Loan(-10000,6.25,5);
try {
x.weeklyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {
assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}// test negative interest
public void testWeeklyPaymentException2b() {
Loan x = new Loan(10000,-6.25,5);
try {
x.weeklyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {
assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}
// test negative duration
public void testWeeklyPaymentException2c() {
Loan x = new Loan(10000, 6.25, -5);
try {
x.weeklyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {
assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}
// test for duration of zero
public void testBiweeklyPaymentException1() {
Loan x = new Loan(10000,6.25,0);
try {x.biweeklyPayment();
} catch (InvalidDurationException e) {
assertEquals("Duration of the loan cannot be zero.", e.getMessage());
} catch (NegativeLoanFieldException e) {
fail();
}
}
// test negative loan amount
public void testBiweeklyPaymentException2a() {
Loan x = new Loan(-10000,6.25,5);
try {
x.biweeklyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {
assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}
// test negative interest
public void testBiweeklyPaymentException2b() {
Loan x = new Loan(10000,-6.25,5);
try {
x.biweeklyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}
// test negative duration
public void testBiweeklyPaymentException2c() {
Loan x = new Loan(10000, 6.25, -5);
try {
x.biweeklyPayment();
} catch (InvalidDurationException e) {
fail();
} catch (NegativeLoanFieldException e) {
assertEquals("Loan fields cannot be negative.", e.getMessage());
}
}
}