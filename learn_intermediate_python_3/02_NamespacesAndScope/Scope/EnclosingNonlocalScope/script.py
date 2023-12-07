def calc_paint_amount(width, height):

  square_feet = width * height
  # Write your code below!
  def calc_gallons():
    return square_feet / 400

  return calc_gallons()

print('Number of paint gallons needed: ')
print(str(calc_paint_amount(30,20)))

def outer_function():
  enclosing_value = 'Enclosing Value'
  
  def nested_function():
    print(enclosing_value)
    # The below would not work. Immutable objects can be
    # referenced but not modified in nested functions.
    # enclosing_value += 'changed'
  
  nested_function()
  print(enclosing_value)

outer_function()