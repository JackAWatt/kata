/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package shapetest;

/**
 *Extends shape class
 * used for Rectangle shapes
 * @author Jack Watt
 */
public class Rectangle extends Shape {
	private double length;
	private double width;
  	
        
        /**
         * outputs that a Rectangle was drawn
         */
	public void draw() { 
		System.out.println("Rectangle.draw()"); 
  	}
         /**
         * outputs that a Rectangle was erased
         */
  	public void erase() { 
		System.out.println("Rectangle.erase()"); 
  	}
        
         /**
         * Calculate area of Rectangle
         * @return area
         */
        public  double computeArea() {
            double area = getLength() * getWidth();
		return area;  // not implemented at this level
	}  

	/**
         * calculates perimeter of Rectangle
         * @return perimeter
         */
	public double computePerimeter() {
            double perimeter = (getLength() * 2) + (getWidth() * 2);
            return perimeter;  // not implemented at this level
	}
        
        /**
         * default constructor
         * @param length
         * @param width 
         */
        public Rectangle(double length, double width) {
            this.length = length;
            this.width = width;
            
            
        }

    /**
     * @return the length
     */
    public double getLength() {
        return length;
    }

    /**
     * @param length the length to set
     */
    public void setLength(double length) {
        this.length = length;
    }

    /**
     * @return the width
     */
    public double getWidth() {
        return width;
    }

    /**
     * @param width the width to set
     */
    public void setWidth(double width) {
        this.width = width;
    }
}


