def student_standing_generator():
  student_standings = ['Freshman','Senior', 'Junior', 'Freshman']
  # Write your code below:

  for standing in student_standings:
    if standing == 'Freshman':
      yield 500
  