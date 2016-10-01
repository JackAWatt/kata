#stuff

4.7. Augmenting Types

JavaScript allows the basic types of the language to be augmented. In Chapter 3, we saw that adding a method

to Object.prototype makes that method available to all objects. This also works for functions, arrays,

strings, numbers, regular expressions, and booleans.

For example, by augmenting Function.prototype, we can make a method available to all functions:

Function.prototype.method = function (name, func) {

this.prototype[name] = func;

return this;

};

By augmenting Function.prototype with a method method, we no longer have to type the name of

the prototype property. That bit of ugliness can now be hidden.

JavaScript does not have a separate integer type, so it is sometimes necessary to extract just the integer 
part of

a number. The method JavaScript provides to do that is ugly. We can fix it by adding an integer method to

Number.prototype. It uses either Math.ceiling or Math.floor, depending on the sign of the

number:

Number.method('integer', function ( ) {

return Math[this < 0 ? 'ceiling' : 'floor'](this);

});

document.writeln((-10 / 3).integer( )); // -3

JavaScript lacks a method that removes spaces from the ends of a string. That is an easy oversight to fix:

String.method('trim', function ( ) {

return this.replace(/^\s+|\s+$/g, '');

});

document.writeln('"' + " neat ".trim( ) + '"');

Our trim method uses a regular expression. We will see much more about regular expressions in Chapter 7.

By augmenting the basic types, we can make significant improvements to the expressiveness of the language.

Because of the dynamic nature of JavaScript's prototypal inheritance, all values are immediately endowed

with the new methods, even values that were created before the methods were created.

The prototypes of the basic types are public structures, so care must be taken when mixing libraries. One

defensive technique is to add a method only if the method is known to be missing:

// Add a method conditionally.

Function.prototype.method = function (name, func) {

if (!this.prototype[name]) {

this.prototype[name] = func;

}

};
