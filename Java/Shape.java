/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package shapetest;

/**
 * Base class used to be inherited to circle, rectangle, and triangle classes 
 * @author Jack Watt
 */
public abstract class Shape {
	protected int colour;

        /*
         * not implemented at this level
         */
	public void draw() { }
        /*
         * not implemented at this level
         */
  	public void erase() { } 
	
	//returns the area of the Shape
	public  double computeArea() {
		return -1.0;  // not implemented at this level
	}  

	//returns the distance around the Shape
	public double computePerimeter() {
		return -1.0;  // not implemented at this level
	}
}

