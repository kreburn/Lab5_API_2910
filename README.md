# Lab5_API_2910

# Success!
- First function I wanted to make works upon first try, I am able to call and list out a single entry from the BOTW SPI
- However, it did not have all of the correct attributes, it would only work for the "monster" category
  
 ^^^^ Fixed this by adding all attributes that were listed for the other categories as well

## ERROR: 
When something like a monster (moblin) was called, it has all of it's attributes' values, but has null values for the other attributes that were needed for the other class
- So it would crash bc Moblin didn't have an 'edible' boolean value stored for example

## SOLUTION:
I made each of the values that were category specific specifically only write into the ToString message if it **WAS NOT** null. So when it was null, it could just be ignored and wouldn't crash :)

Bam, first main function done.... and then the issues began :'(

### Big Error
I wanted to make a method that would use the integrated (as in, already in use in the API) call to filter the data by category (monster, material, etc). 
- the original idea was to read the API JSON stuff, and turn it into a list
    > Yeah well that doesn't work. You can't convert JSON to a list or array
    > At this rate I'm not sure you can convert it into anything

### Attempted Solutions
I have now tried:
- Converting the JSON file (which I need to make multiple objects from) into a list or an array
- using JsonConvert with NewtonSoft.JSON (to make a list)
- Getting rid of the list entirely and just trying to write out the data point blank (yeah no)
- Open a webclient reader to parse the info.... I think that may not have been C# code
- Trying to make a streamreader read it, so I can split the data by commas, and make each one it's own object

# End Results
I only ended with one of three methods I had wanted to create and have been caught in a roadblock on how to make **every** monster into an object in a list of some kind, instead of just pulling one at a time
    
