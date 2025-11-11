/* 
An enum is a type that defines a group of constants.

By default the associated constant values of enum members 
are of type int and start with 0 and increase by 1 
following the definition text order.

If you wish for the values to start at a different value than 0,
and then continue in increments of 1, you only need to specify 
the first value

You can also explicitly specify the associated 
constant values for each enum.
 */

enum Season // enum declaration
{
    Winter = 1, // Initialization. The numbering is optional; it starts at 0 by default.
    Spring, // The rest will be numbered 2-4 automatically.
    Summer,
    Autumn,
}
