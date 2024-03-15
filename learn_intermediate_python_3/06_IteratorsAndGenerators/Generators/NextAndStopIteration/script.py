def student_standing_generator():
  student_standings = ['Freshman','Senior', 'Junior', 'Freshman']
  # Write your code below:

  for standing in student_standings:
    if standing == 'Freshman':
      yield 500
  
standing_values = student_standing_generator()
print(next(standing_values))
print(next(standing_values))

# This will cause StopIteration to occur
print(next(standing_values))
