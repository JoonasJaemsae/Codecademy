from roster import student_roster
from classroom_organizer import ClassroomOrganizer
import itertools

# Task 1
# student_roster_iterator = iter(student_roster)

# i = 0
# while i in range(0, 10):
#   print(next(student_roster_iterator))
#   i = i + 1

# Task 3
students = ClassroomOrganizer()
for student in students:
  print(student)

# Task 4
combos = students.get_combinations_of_2()
for combo in combos:
  print(combo)

# Task 5
# Retrieve math and science students
math_students = students.get_students_with_subject("Math")
science_students = students.get_students_with_subject("Science")

# Combine the two iterables
combined_list = itertools.chain(math_students, science_students)

# Print out all the 4-student combos
combos = itertools.combinations(combined_list, 4)
for pair in combos:
  print(pair)